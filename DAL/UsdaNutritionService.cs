using BE;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsdaNutritionService : INutritionService
    {
        private static readonly String API_KEY = "vTSmnaKUAdhjUfTW1qxFxixciJPdUH8nMmrsdf5c";

        public async Task<Nutritions> GetNutritionInformationAsync(int productID)
        {
            Nutritions nutrients = new Nutritions();
            string url = "https://api.nal.usda.gov/ndb/V2/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));

                HttpResponseMessage response = await client.GetAsync(string.Format("reports?ndbno={0}&type=f&format=json&api_key={1}", productID, API_KEY));
                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();

                JObject jobject = JObject.Parse(result);
                var nutrientsList = jobject["foods"][0]["food"]["nutrients"];
                foreach (var item in nutrientsList)
                {
                    string nutrientId = item["nutrient_id"].ToString();
                    double nutrientValue = double.Parse(item["value"].ToString());
                    string nutrientName = item["name"].ToString();

                    switch (nutrientId)
                    {
                        case "203":
                            nutrients.Protein = nutrientValue;
                            break;
                        case "204":
                            nutrients.TotalFat = nutrientValue;
                            break;
                        case "205":
                            nutrients.Carbohydrate = nutrientValue;
                            break;
                        case "208":
                            nutrients.Energy = nutrientValue;
                            break;
                        case "269":
                            nutrients.Sugars = nutrientValue;
                            break;
                        case "291":
                            nutrients.Fiber = nutrientValue;
                            break;
                        case "601":
                            nutrients.Cholesterol = nutrientValue;
                            break;
                        default:
                            break;
                    }
                }
            }
            return nutrients;
        }
    }
}
