using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Tbl_MyFavorite
    {
        [Key]
        public int Id { get; set; }
        public int IdKala { get; set; }
        public int IdUser { get; set; }
    }
}