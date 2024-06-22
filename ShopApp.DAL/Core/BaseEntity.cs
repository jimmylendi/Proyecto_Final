

namespace ShopApp.DAL.Core
{
    public abstract class BaseEntity
    {

        public DateTime Creation_Date { get; set; }
        public int Creation_User { get; set; }
        public DateTime? Modify_Date { get; set; }
        public int? Modify_User { get; set; }
        public int? Delete_User { get; set; }
        public DateTime? Delete_Date { get; set; }
        public bool Deleted { get; set; }
    }
}
