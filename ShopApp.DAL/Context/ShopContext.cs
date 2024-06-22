
using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Entities;


namespace ShopApp.DAL.Context
{
    public partial class ShopContext : DbContext
    {
        #region "Constructor"
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        #endregion

        #region  "DbSets"
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        #endregion

    }
}
