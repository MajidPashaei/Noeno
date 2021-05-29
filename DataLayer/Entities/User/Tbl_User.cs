using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.User
{
    public class Tbl_User
    {
        [Key]
        public int Id { get; set; }
        public string Phone { get; set; }
        public DateTime TimeLogIn { get; set; }
        public string Password { get; set; }
        public int Random_Link { get; set; }
        public string RPass { get; set; }
        public string NameFamily { get; set; }
        public string State { get; set; }


        public string city { get; set; }
        public string Post { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public string TokenPhone { get; set; }
        public string CodeNational { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string CardNumber { get; set; }

    }
}