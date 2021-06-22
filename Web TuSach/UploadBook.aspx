<%@ Page Title="Dang tai sach" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadBook.aspx.cs" Inherits="TuSach.UploadBook" %>
<asp:Content ID="UploadBook" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container ">
        <div class=" row bettwen-x right-y">
        <h1>Tải sách lên</h1>
        
        <div class="row right-x">
            <asp:Button runat="server" OnClick="Submit_Book" Text="Tải lên" class="btn" />
           </div>
     </div>
      <%=message %>
        <div class="row ">
            <div class="left-side">
                <div>Tên sách</div>
                <div>Thể loại</div>
                <div>Link ảnh</div>
                <div>Mô tả</div>
                <div>Nội dung</div>
            
            </div>

            <div class="right-side">
                <div> <input type="text" name="tensach"></div>
                <div >
                    <select class="row" name="theloai">
                     <% foreach (var x in theloai) { %>
                        <option value="<%=x.CategoryID %>"> <%= x.CategoryName %> </option>
                      <% } %>
                   
                </select>
                </div>
                <div> <input type="text" name="linkanh"></div>
                <div> <input type="text" name="mota">
                </div>
                <div class="div_nd"> <textarea class="row" name="noidung"></textarea></div>
            </div>
        </div>
      
        
    </div> 

</asp:Content>
