using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Exceptions;
using ShopApp.DAL.Interface;
using ShopApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.DAL.Daos
{
    public class CategoryDb : ICategoryDb
    {
        private readonly ShopContext context;

        public CategoryDb(ShopContext context)
        {
            this.context = context;
        }

        public void RemoveCategory(int categoryId)
        {
            try
            {
                var category = context.Categories.Find(categoryId);
                if (category == null)
                    throw new EntidadNoEncontradaException($"Categoría con ID {categoryId} no encontrada.");
                if (category.Deleted)
                    throw new EntidadYaEliminadaException($"Categoría con ID {categoryId} ya está eliminada.");

                category.Deleted = true;
                category.Delete_Date = DateTime.Now;
                category.Delete_User = GetCurrentUserId();

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new OperacionBaseDatosException("Error al eliminar la categoría.", ex);
            }
        }

        public void SaveCategory(CategoryAddModel categoryAdd)
        {
            try
            {
                var category = new Category
                {
                    CategoryName = categoryAdd.CategoryName,
                    Description = categoryAdd.Description,
                    Creation_Date = DateTime.Now,
                    Creation_User = GetCurrentUserId(),
                    Deleted = false
                };

                context.Categories.Add(category);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new OperacionBaseDatosException("Error al guardar la categoría.", ex);
            }
        }

        public void UpdateCategory(CategoryUpdateModel categoryUpdate)
        {
            try
            {
                var category = context.Categories.Find(categoryUpdate.CategoryId);
                if (category == null)
                    throw new EntidadNoEncontradaException($"Categoría con ID {categoryUpdate.CategoryId} no encontrada.");
                if (category.Deleted)
                    throw new EntidadYaEliminadaException($"Categoría con ID {categoryUpdate.CategoryId} ya está eliminada.");

                category.CategoryName = categoryUpdate.CategoryName;
                category.Description = categoryUpdate.Description;
                category.Modify_Date = DateTime.Now;
                category.Modify_User = GetCurrentUserId();

                context.SaveChanges();
            }
            catch (EntidadNoEncontradaException)
            {
                throw;
            }
            catch (EntidadYaEliminadaException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new OperacionBaseDatosException("Error al actualizar la categoría.", ex);
            }
        }

        public List<CategoryModel> GetCategories()
        {
            try
            {
                return context.Categories
                    .Where(c => !c.Deleted)
                    .Select(category => new CategoryModel
                    {
                        CategoryId = category.CategoryId,
                        CategoryName = category.CategoryName,
                        Description = category.Description,
                        CreationDate = category.Creation_Date,
                        CreationUser = category.Creation_User,
                        ModifyDate = category.Modify_Date,
                        ModifyUser = category.Modify_User,
                        DeleteUser = category.Delete_User,
                        DeleteDate = category.Delete_Date,
                        Deleted = category.Deleted
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new OperacionBaseDatosException("Error al recuperar las categorías.", ex);
            }
        }

        public CategoryModel GetCategoryDb(int id)
        {
            try
            {
                var category = context.Categories.Find(id);
                if (category == null)
                    throw new EntidadNoEncontradaException($"Categoría con ID {id} no encontrada.");
                if (category.Deleted)
                    throw new EntidadYaEliminadaException($"Categoría con ID {id} ya está eliminada.");

                return new CategoryModel
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                    CreationDate = category.Creation_Date,
                    CreationUser = category.Creation_User,
                    ModifyDate = category.Modify_Date,
                    ModifyUser = category.Modify_User,
                    DeleteUser = category.Delete_User,
                    DeleteDate = category.Delete_Date,
                    Deleted = category.Deleted
                };
            }
            catch (Exception ex)
            {
                throw new OperacionBaseDatosException("Error al obtener la categoría.", ex);
            }
        }

        private int GetCurrentUserId()
        {
            // Implementación temporal
            return 1;
        }

        public CategoryModel GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
