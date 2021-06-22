using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString.Get("id") == null)
                Response.Redirect("Category.aspx");

            int BookID = Int32.Parse(Request.QueryString.Get("id"));

            if (isExisBook(BookID)) {
              
                var _db = new TuSach.Models.BookContext();
                    
                IQueryable<Models.Book> query = _db.Books;
               
                query = query.Where(p => p.BookID == BookID);
               
                BookItem = query.First();
            }
            else
            {
                Response.Redirect("Category.aspx");
            }

        }
        public Models.Book BookItem { get; set; }

        public bool isExisBook(int id)
        {
            var _db = new Models.BookContext();

            IQueryable<Models.Book> query = _db.Books;

            int tontai = query.Where(u => u.BookID == id).Count();
          
            if (tontai != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}