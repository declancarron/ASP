<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MyWebSite.Pages.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/StudentHousing2.png" />
    </p>
    <p>
        <h2>Letterkenny Student Accommodation Services</h2>
    </p>
    <br />
    <p>
        <h3>This site contains the reports generated from the data contained in the Letterkenny Student Services database</h3>
    </p>
</asp:Content>
