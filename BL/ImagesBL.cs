﻿using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ImagesBL
    {
        private const string baseUrl = "https://icecream-88e4b.web.app/?imageName=";
        private const string downloadUrl = "https://firebasestorage.googleapis.com/v0/b/icecream-88e4b.appspot.com/o/images%2F";

        private INutritionService nutritionService = new UsdaNutritionService();
        private ImageService imageService = new ImageService();
        public async Task <Nutritions> GetIceCreamNutritionAsync(int productId)
        {
            return await nutritionService.GetNutritionInformationAsync(productId);
        }

        public async Task<bool> IsImageContainsIceCream(string imageName)
        {
            return await imageService.IsImageContainsItem(WebUtility.UrlEncode(downloadUrl) + imageName + "%3Falt%3Dmedia" , "ice cream");
        }

        public async Task<byte []> GetImageFromUri(string uri)
        {
            return await imageService.GetImageFromUri(uri);
        }

        public async Task<byte[]> GetImageFromStore(string imageName)
        {
            return await GetImageFromUri(downloadUrl + imageName + "?alt=media");
        }

       static public byte[] GetQrCode(string imageName,Bitmap icon)
        {            
            return ImageService.GetQrCode(baseUrl + imageName,icon);
        }

        
    }
}