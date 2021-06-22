<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="TuSach.Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 
   
         <h1 class="container" ><%= BookItem.BookName%></h1>

       <section class="container book-content" style="min-height:30rem">
        <div class="book" style="display:flex">
          <div class="col-doc">
              <pre>
                <pre>  <%= BookItem.Content%></pre>
              </pre>
          </div>
          <div class="col-book ">
              <h1>  Truyen lien quan</h1>
            
                <div class="">
                    <img  src="https://truyen88.net/upload/stories/posters/462/linh-vu-thien-ha.jpg"/>
                    <p ><strong>100 điều em không biết về senpai</strong></p>
                </div>
                <div class="">
                    <img  src="https://truyen88.net/upload/stories/posters/462/linh-vu-thien-ha.jpg"/>
                    <p ><strong>100 điều em không biết về senpai</strong></p>
                </div>
                <div class="">
                    <img  src="https://truyen88.net/upload/stories/posters/462/linh-vu-thien-ha.jpg"/>
                    <p ><strong>100 điều em không biết về senpai</strong></p>
                </div>
              </div>
                
                                           
          </div>
         

      
    </section>

            




</asp:Content>
