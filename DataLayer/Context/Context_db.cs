using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//////////////////////////////////////////////////Admin Using
using DataLayer.AdminEntities.Address;
using DataLayer.AdminEntities.Agency;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Category;
using DataLayer.AdminEntities.Price;
using DataLayer.AdminEntities.Comment;
using DataLayer.AdminEntities.Experts;
using DataLayer.AdminEntities.Financial;
using DataLayer.AdminEntities.Gallery;
using DataLayer.AdminEntities.Logo;
using DataLayer.AdminEntities.Message;
using DataLayer.AdminEntities.Order;
using DataLayer.AdminEntities.Originality;
using DataLayer.AdminEntities.Product;
using DataLayer.AdminEntities.Slider;
using DataLayer.AdminEntities.SocialNetwork;
using DataLayer.AdminEntities.Teaser;
using DataLayer.AdminEntities.User;
using DataLayer.AdminEntities.Baner;
using DataLayer.AdminEntities.Richat;
using DataLayer.AdminEntities.wallet;
using DataLayer.AdminEntities.AdminPay;

/////////////////////////////////////////////End Using Admin
namespace DataLayer.Context {
    public class Context_db : DbContext {
        public Context_db (DbContextOptions<Context_db> options) : base (options) {

        }
        public DbSet<Tbl_SendNumberCode> Tbl_SendNumberCodes { get; set; }
        public DbSet<Tbl_User> Tbl_Users { get; set; }
        public DbSet<Tb_Price> Tbl_Price { get; set; }
        public DbSet<Tbl_Advertising> tbl_Advertisings { get; set; }
        public DbSet<Tb_Address> Tbl_Adress { get; set; }
        public DbSet<Tb_Agency> Tbl_Agencie { get; set; }
        public DbSet<Tb_Blog> Tbl_Blog { get; set; }
        public DbSet<Tb_Comment> Tbl_Comments { get; set; }
        public DbSet<Tb_Category> tbl_category { get; set; }
        public DbSet<Tb_Experts> Tbl_Experts { get; set; }
        public DbSet<Tb_Financial> Tbl_Financial { get; set; }
        public DbSet<Tb_Gallery> Tbl_Gallery { get; set; }
        public DbSet<Tb_ImageGallery> tb_ImageGalleries {get; set;}
        public DbSet<Tb_Logo> Tbl_Logo { get; set; }
        public DbSet<Tb_Message> Tbl_Message { get; set; }
        public DbSet<Tb_Order> Tbl_Order { get; set; }
         public DbSet<Tb_Factor> Tbl_Factors { get; set; }
        public DbSet<Tb_Originality> Tbl_Originality { get; set; }
        public DbSet<Tb_Product> Tbl_Product { get; set; }
        public DbSet<Tb_Slider> Tbl_Slider { get; set; }
        public DbSet<Tb_Baner> Tbl_Baner { get; set; }
        public DbSet<AdminPay> AdminPays { get; set; }
        public DbSet<Tbl_Richat> Tbl_Richats { get; set; }
        public DbSet<Tb_SocialNetwork> Tbl_SocialNetwork { get; set; }
        public DbSet<Tb_Teaser> Tbl_Teaser { get; set; }
        public DbSet<Tb_User> Tbl_User { get; set; }
         public DbSet<Tb_GalleryProduct> tb_GalleryProducts  { get; set; }
         public DbSet<Tbl_pay> tbl_Pays  { get; set; }
         public DbSet<Tbl_Factor> Tbl_Factors2  { get; set; }
         public DbSet<Tbl_MyFavorite> Tbl_MyFavorites  { get; set; }

////////////////////////////////////////////////////////////////////////////End Admin 

    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<Context_db> {
        public Context_db CreateDbContext (string[] args) {
            var builder = new DbContextOptionsBuilder<Context_db> ();
            builder.UseSqlServer ("Data Source=.;initial Catalog=NewProject_db;integrated Security=SSPI;MultipleActiveResultSets=true");
            return new Context_db (builder.Options);
        }
    }
}