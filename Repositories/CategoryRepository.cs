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
                        Description = "Some Description",
                        Page = new StackLayoutPage() 
                    } 
                }
             });

            return categories;
        }
    }
}
