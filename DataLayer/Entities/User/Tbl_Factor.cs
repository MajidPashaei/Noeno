using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.User {
       public class Tbl_Factor 
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public int IdSeller { get; set; }
        public int IdKala { get; set; }
        public int Count { get; set; }
        public int prices { get; set; }
        public int Date { get; set; }
        public int Address { get; set; }
        public int Ordertype { get; set; }
        public int Inspection { get; set; }
        public int Orderstatus { get; set; }
        public int Reference { get; set; }
        public int Code { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


    }
    }