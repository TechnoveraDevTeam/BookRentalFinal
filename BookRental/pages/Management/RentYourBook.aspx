<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RentYourBook.aspx.cs" Inherits="pages_Management_RentYourBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style2 {
        margin-left: 20px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <p>
    &nbsp;</p>
<p>
    <br />
    Book Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddCategory" runat="server" Height="32px" Width="201px">
    </asp:DropDownList>
</p>
<p>
    <br />
    Book Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBookTitle" runat="server" Width="190px"></asp:TextBox>
</p>
<p>
    <br />
    Author Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtAuthorName" runat="server" Width="191px"></asp:TextBox>
</p>
<p>
    Publisher Name&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="txtPname" runat="server" Width="189px"></asp:TextBox>
</p>
<p>
    Publisher Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPdate" runat="server" Width="194px"></asp:TextBox>
</p>
<p>
    picture&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style2" Text="Button" />
</p>
<p>
    <asp:Label ID="lblResults" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
 
</asp:Content>

