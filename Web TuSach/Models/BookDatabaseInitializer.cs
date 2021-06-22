using System.Collections.Generic;
using System.Data.Entity;

namespace TuSach.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Sach Moi"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sach kinh doanh"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Sach thieu nhi"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Tieu thuyet"
                },
            };

            return categories;
        }

       
    }
}