

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Models
{
    public class CategoryAddModel
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }


        public DateTime Creation_Date { get; set; }
        public int Creation_User { get; set; }

    }
}
