using MauiGalleryApp.Models;
using MauiGalleryApp.Views.Layouts;

namespace MauiGalleryApp.Repositories
{
    public class CategoryRepository
    {
        public CategoryRepository()
        {
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description = "Stack Layout Page",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component {
                        Title = "Grid",
                        Description = "Grid Layout Page",
                        Page = typeof(GridLayoutPage)
                    }
                }
            });

            return categories;
        }
    }
}
