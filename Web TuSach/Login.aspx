<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TuSach.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="box_login">
    
        <div  class="form-login">
            <header>
                Đăng Nhập
            </header>
            <div>
                <label>Tên Đăng Nhập</label>
                <input type="text" name="taikhoan" />
    
            </div>
    
            <div>
                <label>Mật Khẩu</label>
                <input type="password" name="matkhau" />
            </div>
    
            <div>
                <asp:Button runat="server" Text="Đăng nhập" OnClick="Submit_Login" class="btn" /> 
               
            </div>
            <%=message %>
    
        </div>
    </div>
</asp:Content>
