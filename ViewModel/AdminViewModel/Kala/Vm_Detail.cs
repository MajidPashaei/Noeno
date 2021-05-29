using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ViewModel.AdminViewModel.Kala {
    public class Vm_Detail {
        [Key]
        public int Id { get; set; }
        
        public string FatherCat { get; set; }
        public string Cat { get; set; }
        public string ChildCat { get; set; }
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
        public string Auction_Start_Time { get; set; }

        //////////////////////////////////////////////// قیمت ثابت و مشخص 
        
  
        public string Main_Price { get; set; }

        public string Discount_Price { get; set; }

        public string Online_Exchange { get; set; }

        public string Take_Discount { get; set; }
        public  List<IFormFile> upload_imgs { get; set; }
        
        

        //////////////////////////////////////////////////////////////////////////////////////////////////پایان نوع قیمت گذاری

        public string Time  { get; set; }
        public int Total  { get; set; }
        public string NameCrator  { get; set; }
        public string city { get; set; }
        public string PhoneCreator  { get; set; }
        public string State { get; set; }
        public string Description  { get; set; }
        public string Special  { get; set; }
        public string TimeReturn  { get; set; }
        public string WhyReturn  { get; set; }
       


    }

}