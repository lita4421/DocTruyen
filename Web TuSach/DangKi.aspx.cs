using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuSach
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public string message;
        public bool CheckUser(string name)
        {
            var _db = new Models.BookContext();


            IQueryable<Models.User> query = _db.Users;

            int tontai = query.Where(u => u.UserName == name ).Count();
            if (tontai == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Submit_DangKi(object sender, EventArgs e)
        {
            string name = Request.Form.Get("taikhoan");

            string matkhau = Request.Form.Get("matkhau");

                if (CheckUser(name)) 
                {

                    var _db = new Models.BookContext();

                    var newUser = new Models.User
                    {
                        UserName = name,
                        Password = matkhau
                    };


                    _db.Users.Add(newUser);
                    _db.SaveChanges();

                    Response.Cookies.Add(new HttpCookie("taikhoan", name));
                    Response.Cookies.Add(new HttpCookie("matkhau", matkhau));
                    Response.Redirect("Default.aspx");
                }
                else {
                     message = "tai khoan da ton tai";
                }

            }
           
        

    }
}