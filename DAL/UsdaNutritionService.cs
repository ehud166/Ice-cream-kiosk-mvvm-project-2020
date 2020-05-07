﻿using BE;
using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows;

namespace DAL
{
    public class UsdaNutritionService : INutritionService
    {
        private static readonly String API_KEY = "vTSmnaKUAdhjUfTW1qxFxixciJPdUH8nMmrsdf5c";

        public Nutritions GetNutritionInformation(string productName)
        {
            try
            {
                Nutritions nutrients = new Nutritions();
                var nutritionsDict = GetProductNutritions(GetProductID(productName));
                nutrients.Cholesterol = nutritionsDict["Cholesterol"];
                nutrients.Fiber = nutritionsDict["Fiber, total dietary"];
                nutrients.Carbohydrate = nutritionsDict["Carbohydrate, by difference"];
                nutrients.Energy = nutritionsDict["Energy"];
                nutrients.Protein = nutritionsDict["Protein"];
                nutrients.Sugars = nutritionsDict["Sugars, total including NLEA"];
                nutrients.TotalFat = nutritionsDict["Total lipid (fat)"];
            return nutrients;
            }
            catch { throw; }
            
            //Nutritions nutrients = new Nutritions();
            //string url = "https://api.nal.usda.gov/ndb/V2/";
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(url);
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));

            //    HttpResponseMessage response = await client.GetAsync(string.Format("reports?ndbno={0}&type=f&format=json&api_key={1}", GetProductID(productName), API_KEY));
            //    HttpContent content = response.Content;
            //    string result = await content.ReadAsStringAsync();

            //    JObject jobject = JObject.Parse(result);
            //    var nutrientsList = jobject["foods"][0]["food"]["nutrients"];
            //    foreach (var item in nutrientsList)
            //    {
            //        string nutrientId = item["nutrient_id"].ToString();
            //        double nutrientValue = double.Parse(item["value"].ToString());
            //        string nutrientName = item["name"].ToString();

            //        switch (nutrientId)
            //        {
            //            case "203":
            //                nutrients.Protein = nutrientValue;
            //                break;
            //            case "204":
            //                nutrients.TotalFat = nutrientValue;
            //                break;
            //            case "205":
            //                nutrients.Carbohydrate = nutrientValue;
            //                break;
            //            case "208":
            //                nutrients.Energy = nutrientValue;
            //                break;
            //            case "269":
            //                nutrients.Sugars = nutrientValue;
            //                break;
            //            case "291":
            //                nutrients.Fiber = nutrientValue;
            //                break;
            //            case "601":
            //                nutrients.Cholesterol = nutrientValue;
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}
            //return nutrients;
        }

        public string GetProductID(string foodParms)
        {
            var client = new RestClient("https://api.nal.usda.gov/fdc/v1/foods/search?api_key=" + API_KEY
                                        + "&pageSize=1&pageNumber=1&query=" + foodParms);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            object deserializeContent = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(response.Content);
            JObject contentAsJSON = JObject.Parse(deserializeContent.ToString());
            var res = contentAsJSON["foods"][0]["fdcId"].ToString();

            return res;
        }

        public Dictionary<string, double> GetProductNutritions(string id)
        {
            var client = new RestClient("https://api.nal.usda.gov/fdc/v1/food/" + id
                                        + "?api_key=" + API_KEY);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            object deserializeContent = JsonConvert.DeserializeObject<object>(response.Content);
            JObject contentAsJSON = JObject.Parse(deserializeContent.ToString());
            Dictionary<string, double> nutritions = new Dictionary<string, double>();
            foreach (var item in contentAsJSON["foodNutrients"].ToList())
            {
                string name = item["nutrient"]["name"].ToString();
                try
                {
                    double amount = item["amount"].ToObject<double>();
                    nutritions.Add(name, amount);
                }
                catch (Exception) { }
            }
            return nutritions;
        }
    }
}
