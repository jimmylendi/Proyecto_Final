using ShopApp.DAL.Core;


namespace ShopApp.DAL.Entities
{
    public class Supplier : BaseEntity
    {
        public int SupplierId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
    }
}
