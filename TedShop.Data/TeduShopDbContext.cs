using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;

namespace TedShop.Data
{
    public class TeduShopDbContext: DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            //khi load ban cha thi khong tu dong load them bang con
            this.Configuration.LazyLoadingEnabled = false;
        }

        //trái tim của entities codefirst
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        //ghi đè phuong thức OnModelCreating của DbContext
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //phuong thức này sẽ chạy khi khởi tạo entities frameword
        }
    }
}
