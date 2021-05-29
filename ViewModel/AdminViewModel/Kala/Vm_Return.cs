using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ViewModel.AdminViewModel.Kala {
    public class Vm_Return {
        [Key]
        public int Id { get; set; }
        public string Description  { get; set; }
        public string TimeReturn  { get; set; }
        public string WhyReturn  { get; set; }
        public int iD  { get; set; }
        public string Special  { get; set; }
       


    }

}