using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TuSach.Models;
using System.Data.Entity;

namespace TuSach
{
    public partial class SiteMaster : MasterPage
    {
        public IQueryable<Models.Category> theloai;
        public string DangNhap = "Đăng Nhập";
        public string DangKy = "Đăng Ký";
        public string LinkDN = "./Login.aspx";
        public string LinkDK = "./DangKi.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies.Get("taikhoan");
            HttpCookie matkhau = Request.Cookies.Get("matkhau");

            if (name != null || matkhau != null)
            {
                if (CheckDangNhap(name.Value, matkhau.Value))
                {
                    DangNhap = name.Value;
                    LinkDN = "#";
                    DangKy = "Đăng Xuất";
                    LinkDK = "./Login.aspx";
                }
            }
            theloai = GetCategories();
            
        }

        

        public bool CheckDangNhap(string name, string matkhau)
        {
            var dt = new Models.BookContext();
            IQueryable<Models.User> query = dt.Users;
            int tontai = query.Where(u => u.UserName == name && u.Password == matkhau).Count();
            return tontai == 0 ? false : true;
        }

        public IQueryable<Models.Category> GetCategories()
        {
            var _db = new TuSach.Models.BookContext();
            IQueryable<Models.Category> query = _db.Categories;
            return query;
        }

        public string DangXuat()
        {
            DangKy = "Đăng Ký";
            DangNhap = "Đăng Nhập";
            LinkDK = "./DangKi.aspx";
            return "1";
        }

       

    }
}