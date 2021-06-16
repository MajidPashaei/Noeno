using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModel.Entities.User {
  public class Vm_Details {
    [Key]
    public int Id { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public string Status { get; set; }
    public int Bazrasi { get; set; }
    public int Komision { get; set; }
    public int MyProperty { get; set; }
    public string one {get; set;}
    
  }
}