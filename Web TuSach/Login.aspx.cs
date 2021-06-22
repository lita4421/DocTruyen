using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        
        public string message="xin moi dang nhap";
        
        public bool CheckUser(string name, string password)
        {
            var _db = new Models.BookContext();

            IQueryable<Models.User> query = _db.Users;

            int tontai = query.Where(u => u.UserName == name && u.Password == password).Count();

            return tontai == 0 ? false : true;
            
            
        }

        public void Submit_Login(object sender, EventArgs e)
        {
            string name = Request.Form.Get("taikhoan");
            string matkhau = Request.Form.Get("matkhau");

            if (CheckUser(name, matkhau))
            {
                Response.Cookies.Add(new HttpCookie("taikhoan", name));
                Response.Cookies.Add(new HttpCookie("matkhau", matkhau));
                Response.Redirect("Default.aspx");

            }
            else
            {
                message = "Nhap sai thong tin ";
            }

            
        }
    }
}
