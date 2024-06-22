using ShopApp.DAL.Core;


namespace ShopApp.DAL.Entities
{
    public class Shipper : BaseEntity
    {
        public int ShipperId { get; set; }
        public string? Name { get; set; }

    }
}
