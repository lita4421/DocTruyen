
<%@ Page Title="Category" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="TuSach.Category" %>
<asp:Content ID="CategoryContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="content container">
     <h1>  <%=tentheloai %></h1>
        <div class="row">
         <% foreach (var y in books) { %>
              <div class="col truyen">
                <img  src="<%= y.ImagePath %>"/>
                    <a href="Book.aspx?id=<%= y.BookID %>">    
                <p ><strong><%= y.BookName %></strong></p>
                  </a>
            </div>

           
          <% } %>
        
         </div>

    </section>


</asp:Content>
