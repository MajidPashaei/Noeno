using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.AdminPay {
    public class AdminPay {
        [Key]
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string Detail { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
        public string TypePay { get; set; }
        
        

    }

}