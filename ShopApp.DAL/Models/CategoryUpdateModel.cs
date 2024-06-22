

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Models
{
    public class CategoryUpdateModel
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }


        public DateTime? Modify_Date { get; set; }
        public int? Modify_User { get; set; } = 0;

    }
}
