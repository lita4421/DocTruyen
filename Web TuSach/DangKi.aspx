<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="TuSach.DangKi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="box_login">
    
        <div  class="form-login">
            <header>
              Đăng ký
            </header>
            <div>
                <label>Tên Đăng Ký</label>
                <input type="text" name="taikhoan" />
    
            </div>
    
            <div>
                <label>Mật Khẩu</label>
                <input type="password" name="matkhau" />
            </div>
    
            <div>
                <asp:Button runat="server" Text="Đăng ký"  OnClick="Submit_DangKi" class="btn" />
              
            </div>

           <p><%=message %></p>
    
        </div>
    </div>

</asp:Content>
