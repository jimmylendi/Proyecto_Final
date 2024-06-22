using ShopApp.DAL.Core;

using System.ComponentModel.DataAnnotations;




namespace ShopApp.DAL.Entities
{
    public class Customers : BaseEntity
    {

        [Key]

        public int CustId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        
    }
}
