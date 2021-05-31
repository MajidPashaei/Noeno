using System.Collections.Generic;
using DataLayer.AdminEntities.Category;
using DataLayer.AdminEntities.Logo;
using DataLayer.AdminEntities.SocialNetwork;
using DataLayer.Entities.User;
namespace New_Project.Models
{
    public static class menu
    {
         public static List<Tb_Category> cat = new List<Tb_Category>();
         public static int resiver,sender,total_user,new_order,new_comment,idrezerv=0;
         public static string logo,Title,img,favicon,enemad;
         public static List<Tb_SocialNetwork> social = new List<Tb_SocialNetwork>();
         public static string Richat;
         public static int order_count;
        public static List<Tb_Category> D = new List<Tb_Category>();
        public static List<Tb_Category> A = new List<Tb_Category>();
        public static List<Tb_Category> kh = new List<Tb_Category>();
        public static List<Tb_Category> M = new List<Tb_Category>();
        public static List<Tb_Category> Kitchen = new List<Tb_Category>();
        public static List<Tb_Category> L = new List<Tb_Category>();
        public static List<Tb_Category> N = new List<Tb_Category>();
        public static List<Tb_Category> S = new List<Tb_Category>();
        public static List<Tbl_Advertising> j = new List<Tbl_Advertising>();
        public static List<string> find { get; set; }
        
        
    }
}