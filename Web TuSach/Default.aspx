<%@ Page Title="Tu Sach" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TuSach._Default" %>



<asp:Content ID="IndexContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <section class="content container">
        <div class=" row bettwen-x right-y">
         <h1>Light Novel</h1>
         </div>

        <div class="row">


          <% foreach (var sach in lightNovel) { %>
                <div class="col truyen">
                <img  src="<%= sach.ImagePath %>"/>

                      <a href="Book.aspx?id=<%= sach.BookID %>">    
                <p ><strong><%= sach.BookName %></strong></p>
                 </a>
            </div>
          <% } %>
          </div>

         <div class=" row bettwen-x right-y">
             <h1>Kinh doanh</h1>
           
             </div>
        <div class="row">
              
      
          <% foreach (var sach in kinhDoanh) { %>
                <div class="col truyen">
                <img  src="<%= sach.ImagePath %>"/>
                     <a href="Book.aspx?id=<%= sach.BookID %>">    
                <p ><strong><%= sach.BookName %></strong></p>
                    </a>
                  
            </div>
          <% } %>
          </div>

         <div class=" row bettwen-x right-y">
         <h1>Tiểu thuyết</h1>
   
             </div>
        <div class="row">

      
          <% foreach (var sach in tieuThuyet) { %>
                <div class="col truyen">
                <img  src="<%= sach.ImagePath %>"/>
                 <a href="Book.aspx?id=<%= sach.BookID %>">    

                <p ><strong><%= sach.BookName %></strong></p>
                    </a>
            </div>
          <% } %>
          </div>

         <div class=" row bettwen-x right-y">
         <h1>Thiếu nhi</h1>
  
             </div>
        <div class="row">

      
          <% foreach (var sach in thieuNhi) { %>
                <div class="col truyen">
                   
                <img  src="<%= sach.ImagePath %>"/>
          <a href="Book.aspx?id=<%= sach.BookID %>">     
              <p ><strong><%= sach.BookName %></strong></p>

                    </a>
            </div>
          <% } %>
          </div>
       
        
    </section>



</asp:Content>