using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModel.AdminViewModel.AdminPay {
    public class Vm_AdminPay 
    {
        [Key]
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string Detail { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
        public string TypePay { get; set; }
    }

}