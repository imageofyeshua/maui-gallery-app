using MauiGalleryApp.Models;
using MauiGalleryApp.Views.Components.Mains;
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
                    },
                    new Component {
                        Title = "Absolute",
                        Description = "Absolute Layout Page",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component {
                        Title = "Flex",
                        Description = "Flex Layout Page",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Components (Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "BoxView Page",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Label Page",
                        Page = typeof(LabelPage)
                    }
                }
            });

            return categories;
        }
    }
}
