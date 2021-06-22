using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class Category : System.Web.UI.Page
    {
        public IQueryable<Models.Book> books; //truy van dl
        public string tentheloai;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
           
              
            if (Request.QueryString.Get("id") == null)
            {       
                id = 1;
  
            } else
            {
               
                id = Int32.Parse(Request.QueryString.Get("id"));
            }
           
            books = GetBooks(id);
            tentheloai = getname(id);
            
           

        }

        public IQueryable<Models.Book> GetBooks(int categoryId)
        {
            var _db = new TuSach.Models.BookContext();
            IQueryable<Models.Book> query = _db.Books;

                query = query.Where(p => p.CategoryID == categoryId);
     
            return query;

        }

        public string getname(int id)
        {
            var _tl = new TuSach.Models.BookContext();
            IQueryable<Models.Category> query = _tl.Categories;
            query = query.Where(p => p.CategoryID == id);

            return 
                query.First<Models.Category>().CategoryName;
            
        }
       
    }
}