using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class Tbl_SendNumberCode {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LessonName { get; set; }
        public int Number { get; set; }
    }
}