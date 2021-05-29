using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.Price {
    public class Tb_Price {
        [Key]
        public int Id { get; set; }
        public string Cat_Type { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Price { get; set; }

    }

}