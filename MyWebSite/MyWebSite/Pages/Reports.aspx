<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="MyWebSite.Pages.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Letterkenny Student Accommodation Housing Reports
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Apartment%20Applications">Current Applications for Apartments</a>
        <asp:Button ID="btnApartmentApplicantReport" runat="server" Text="Current Applications for Apartments" OnClick="btnApartmentApplicantReport_Click" Width="260px" />
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Apartment%20Available">Current Apartment Vacancies</a>
        <asp:Button ID="btnApartmentVacancies" runat="server" Text="Current Apartment Vacancies" OnClick="btnApartmentVacancies_Click" Width="260px" />
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Maintenance%20Requests">Maintenance Requests</a>
        <asp:Button ID="btnMaintenanceRequests" runat="server" Text="Maintenance Requests" OnClick="btnMaintenanceRequests_Click" Width="260px" />
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Rental%20Payments">Rental Payments</a>
        <asp:Button ID="btnRentalPayments" runat="server" Text="Rental Payments" OnClick="btnRentalPayments_Click" Width="260px" />
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Resident%20Fees">Resident Fees</a>
        <asp:Button ID="btnResidentFees" runat="server" Text="Resident Fees" OnClick="btnResidentFees_Click" Width="260px" />
    </p>
    <p>
        <a class="btn btn-default" href="http://ws12sql4/Reports/report/Resident%20Fees">Log Reports</a>
        <asp:Button ID="btnLogReport" runat="server" Text="Log Report" OnClick="btnLogReport_Click" Width="260px" />
    </p>
</asp:Content>
