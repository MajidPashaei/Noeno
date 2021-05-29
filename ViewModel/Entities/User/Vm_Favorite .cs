using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModel.Entities.User {
  public class Vm_Favorite {
    [Key]
    public int Id { get; set; }
    public string Title_Pro { get; set; }
    public string Image { get; set; }
    public string Main_Price { get; set; }
    public string Discount_Price { get; set; }
  }
}