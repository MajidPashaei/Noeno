using System;
using System.ComponentModel.DataAnnotations;
namespace ViewModels.AdminViewModel.Wallet
{
    public class Vm_Pay
    {
        
          [Key]
          public int Id { get; set; }
          public string Phone{ get; set; }
          public string NameFamily { get; set; }
          public int Pay { get; set; }
          public int Harvest { get; set; }
          public string Paytime { get; set; }
          public string havesttime { get; set; }
           public bool status { get; set; }
            public int iduser { get; set; }
            public int Id_Factro { get; set; }
         
    }
}