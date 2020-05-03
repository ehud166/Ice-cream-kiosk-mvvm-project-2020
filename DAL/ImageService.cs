using Newtonsoft.Json.Linq;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageService
    {
        public async Task<bool> IsImageContainsItem(string imageUrl, string item)
        {
            string apiKey = "acc_800d837796a799b";
            string apiSecret = "c0951db577672beb1d8493df67c282d2";
            List<string> labelList = new List<string>();
            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.imagga.com/v2/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", basicAuthValue));
                try
                {
                    using (HttpResponseMessage response = await client.GetAsync(String.Format("tags?image_url={0}", imageUrl)))
                    {
                        HttpContent content = response.Content;
                        string result = await content.ReadAsStringAsync();
                        JObject jobject = JObject.Parse(result);

                        if (jobject["result"] != null)
                        {
                            labelList = (from t in jobject["result"]["tags"]
                                         where (double)t["confidence"] > 70
                                         select (string)t["tag"]["en"]).ToList();
                        }
                        else
                        {
                            throw new Exception(jobject["status"]["text"].ToString());
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
            return labelList.Contains(item);
        }

        public async Task<byte[]> GetImageFromUri(string uri)
        {
            byte[] bytes = null;
            using (var wc = new WebClient())
            {
                bytes = await wc.DownloadDataTaskAsync(new Uri(uri));
            }
            return bytes;
        }

        public static byte[] GetQrCode(string url, Bitmap icon)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(qrCode.GetGraphic(20, Color.Purple, Color.White, icon, 20), typeof(byte[]));
        }
       
    }


}
