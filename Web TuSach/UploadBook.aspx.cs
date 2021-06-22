using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class UploadBook : System.Web.UI.Page
    {
        public string message;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie taikhoan = Request.Cookies.Get("taikhoan");
            HttpCookie matkhau = Request.Cookies.Get("matkhau");



            if (taikhoan == null || matkhau == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!CheckUser(taikhoan.Value, matkhau.Value))
            {
                Response.Redirect("Default.aspx");
            }
            theloai = GetCategories();
        }

        public IQueryable<Models.Category> GetCategories()
        {
            var _db = new Models.BookContext();
            IQueryable<Models.Category> query = _db.Categories;
            return query;
        }
        public IQueryable<Models.Category> theloai;
        public void Submit_Book(object sender, EventArgs e)
        {
            string name = Request.Form.Get("tensach");
            if (name.Length > 100 || name.Length == 0)
            {
                message = "Nhap sai yeu cau";
                return;
            }


            int cateId = Int32.Parse(Request.Form.Get("theloai"));


            string description = Request.Form.Get("mota");
            if (description.Length < 20)
            {
                message = " Mo ta phai it nhat 20 ki tu";
                return;
            }

            string imagePath = Request.Form.Get("linkanh");
            string content = Request.Form.Get("noidung");

            //Response.Write(name + description + imagePath + content);

            var _db = new Models.BookContext();

            var newBook = new Models.Book
            {
                BookName = name,
                Description = description,
                ImagePath = imagePath,
                Content = content,
                CategoryID = cateId
            };

            message = "Tai len thanh cong";
            _db.Books.Add(newBook);
            _db.SaveChanges();
        }
        public bool CheckUser(string name, string password)
        {
            var _db = new Models.BookContext();


            IQueryable<Models.User> query = _db.Users;

            int tontai = query.Where(u => u.UserName == name && u.Password == password).Count();
            if (tontai == 1)
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