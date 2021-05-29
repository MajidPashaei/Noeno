using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ViewModel.Entities.User {
    public class Vm_Advertising {
        [Key]
        public int Id { get; set; }
        
        public string Category { get; set; }
        public string Id_creator { get; set; }
        
        public string Image { get; set; }
        
        public IFormFile Img { get; set; }
        
        public string Image1 { get; set; }
        
        public IFormFile Img1 { get; set; }
        
        public string Image2 { get; set; }
        
        public IFormFile Img2 { get; set; }
        
        public string Image3 { get; set; }
        
        public IFormFile Img3 { get; set; }
        public string Title_Pro { get; set; }
        
        public string Discreption_Pro { get; set; }
        
        public string Type_pro { get; set; }
        
        public string Type_Transaction { get; set; }
        //////////////////////////////////////////////////////////////////////////////////////////////////شروع نوع قیمت گذاری
        //////////////////////////////////////////////// بالاترین پیشنهاد خریدار(مزایده) 
        public string Main_Price_Auction { get; set; }
        public string Auction_Time { get; set; }
        public int PriceB { get; set; }
        public int Pricek { get; set; }
        public int PricekC { get; set; }
        public string Auction_Start_Time { get; set; }

        //////////////////////////////////////////////// قیمت ثابت و مشخص 
        
  
        public string Main_Price { get; set; }

        public string Discount_Price { get; set; }

        public string Online_Exchange { get; set; }

        public string Take_Discount { get; set; }
        public  List<IFormFile> upload_imgs { get; set; }
        public  List<IFormFile> files { get; set; }
        
        

        //////////////////////////////////////////////////////////////////////////////////////////////////پایان نوع قیمت گذاری

        public string Time  { get; set; }
        public string State { get; set; }
        public string Description  { get; set; }
        public string Special  { get; set; }
        public int Number { get; set; }
         public int status { get; set; }
          public string FatherIdCat { get; set; }
        public string Father { get; set; }
        
        

    }

}