using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace DataLayer.AdminEntities.Order
{
    public class Tb_Factor
    {
        [Key]
        public int Id { get; set; }
        public int Id_Order { get; set; }
        public int Id_creator { get; set; }
        public int Id_Factro { get; set; }

        public int Product_Id { get; set; }
        public string product_Name { get; set; }
        public DateTime Date_Order { get; set; }
        public int Product_Count { get; set; }
        public int product_Price { get; set; }
        public int Total_sum { get; set; }
        public string StatusA { get; set; }
        public string StatusM { get; set; }
        public string Type_Transaction { get; set; }
        public string TellBuy { get; set; }
        public string TellSel { get; set; }
        public int IdUser { get; set; }
        public string Post { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FirstAddress { get; set; }
        public int PriceB { get; set; }
        public int PriceK { get; set; }
        public string NameBuy { get; set; }
        public string NameSel { get; set; }
        public string Image { get; set; }
        public string Pay { get; set; }
        public string Send_Sales_Code { get; set; }
        public string Send_Order_Code { get; set; }
        public string Send_Admin_Code { get; set; }
        public string Why_Return_Admin_Bazrasi { get; set; }
        public string Why_Return_Request { get; set; }
        public string ImageReturn { get; set; } 




    }

}