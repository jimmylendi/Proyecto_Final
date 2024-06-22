

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}

