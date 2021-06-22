using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lightNovel = GetBooks(1);
            kinhDoanh = GetBooks(2);    
            tieuThuyet = GetBooks(3);
            thieuNhi = GetBooks(4);
        }
        public bool CheckUser(string name, string password)
        {
            var _db = new Models.BookContext();

            IQueryable<Models.User> query = _db.Users;

            int tontai = query.Where(u => u.UserName == name && u.Password == password).Count();

            return tontai == 0 ? false : true;


        }
       
        public IQueryable<Models.Book> GetBooks(int theloaiId)
        {
            var _db = new TuSach.Models.BookContext();
           
            IQueryable<Models.Book> query = _db.Books;

            query = query.Where(x=> x.CategoryID == theloaiId).Take(4);

            return query;
        }

        public IQueryable<Models.Book> lightNovel;
        public IQueryable<Models.Book> kinhDoanh;
        public IQueryable<Models.Book> tieuThuyet;
        public IQueryable<Models.Book> thieuNhi;

    }
}