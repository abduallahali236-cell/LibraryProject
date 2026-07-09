using Library.Business.Global;
using Library.DataAccess;
using Library.Models;

namespace Library.Business;

public class CategoryService
{
    public bool Add(Category category)
    {
        Authorization.EnsureAdmin();

        Validate(category);

        return CategoryData.Add(category);
    }

    public bool Update(Category category)
    {
        Authorization.EnsureAdmin();

        Validate(category);

        return CategoryData.Update(category);
    }

    public bool Delete(int categoryId)
    {
        Authorization.EnsureAdmin();

        if (!CategoryData.Exists(categoryId))
            throw new InvalidOperationException("Category not found.");

         if (BookData.HasBooks(categoryId))
             throw new InvalidOperationException(
                 "Cannot delete a category that contains books.");

        return CategoryData.Delete(categoryId);
    }

    public Category? GetById(int categoryId)
    {
        Authorization.EnsureLibrarianOrAdmin();

        return CategoryData.GetById(categoryId);
    }

    public List<Category> GetAll()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return CategoryData.GetAll();
    }

    private static void Validate(Category category)
    {
        if (category == null)
            throw new ArgumentNullException(nameof(category));

        if (string.IsNullOrWhiteSpace(category.CategoryName))
            throw new ArgumentException("Category name is required.");

        if (category.CategoryName.Length > 100)
            throw new ArgumentException("Category name is too long.");
    }
}