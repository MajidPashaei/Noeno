using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModel.AdminViewModel.Price {
    public class Vm_Price {
        [Key]
        public int Id { get; set; }
        public string Cat_Type { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Price { get; set; }
       

    }

}