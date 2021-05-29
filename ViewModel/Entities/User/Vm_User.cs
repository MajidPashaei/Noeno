using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModel.Entities.User {
  public class Vm_User {
    [Key]
    public int Id { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string RPass { get; set; }
    public string NameFamily { get; set; }
    public string city { get; set; }
    public string Code { get; set; }
    public string TokenPhone { get; set; }
    public string CodeNational { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public IFormFile Img { get; set; }
    public string CardNumber { get; set; }
    public string TimeLogIn { get; set; }
    public string State { get; set; }
    
    public string Post { get; set; }
    
    public string Address { get; set; }
    public string Price { get; set; }
  }
}