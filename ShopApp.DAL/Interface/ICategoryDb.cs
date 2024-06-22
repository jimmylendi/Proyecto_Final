
using ShopApp.DAL.Models;

namespace ShopApp.DAL.Interface
{
    public interface ICategoryDb
    {
        List<CategoryModel> GetCategories();

        CategoryModel GetCategoryDb(int id);

        CategoryModel GetCategory(int id);

        void SaveCategory(CategoryAddModel categoryAdd);
        void UpdateCategory(CategoryUpdateModel categoryUpdate);
        void RemoveCategory(int categoryId);
    }
}
