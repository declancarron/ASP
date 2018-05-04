<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="MyWebSite.Pages.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Letterkenny Student Accommodation Housing Reports</h2>
    <p>
        <!--<a class="btn btn-default" href="http://172.28.134.4/Reports/report/Apartment%20Applications">Current Applications for Apartments</a>-->
        Click to review the Current List of Applications for Student Accommodation
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnApartmentApplicantReport" runat="server" Text="Current Applications for Apartments" OnClick="btnApartmentApplicantReport_Click" Width="260px" Height="34px" />
    </p>
    <p>
        <!--<a class="btn btn-default" href="http://172.28.134.4/Reports/report/Apartment%20Available">Current Apartment Vacancies</a>-->
        Click to generate a report for the list of available Apartments
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnApartmentVacancies" runat="server" Text="Current Apartment Vacancies" OnClick="btnApartmentVacancies_Click" Width="260px" Height="34px" />
    </p>
    <p>
        <!--<a class="btn btn-default" href="http://172.28.134.4/Reports/report/Maintenance%20Requests">Maintenance Requests</a>-->
        Click to generate a report on Maintenance Requests
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnMaintenanceRequests" runat="server" Text="Maintenance Requests" OnClick="btnMaintenanceRequests_Click" Width="260px" Height="34px" />
    </p>
    <p>
        <!--<a class="btn btn-default" href="http://172.28.134.4/Reports/report/Rental%20Payments">Rental Payments</a>-->
        Click to generate a report for Rental Payments
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnRentalPayments" runat="server" Text="Rental Payments" OnClick="btnRentalPayments_Click" Width="260px" Height="34px" />
    </p>
    <p>
        <!--<a class="btn btn-default" href="http://172.28.134.4/Reports/report/Resident%20Fees">Resident Fees</a>-->
        Click to generate a report for Resident Fees
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnResidentFees" runat="server" Text="Resident Fees" OnClick="btnResidentFees_Click" Width="260px" Height="34px" />
    </p>
    <!--<p>
        <a class="btn btn-default" href="http://172.28.134.4/Reports/report/Resident%20Fees">Log Reports</a>
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnLogReport" runat="server" Text="Log Report" OnClick="btnLogReport_Click" Width="260px" Height="34px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>-->
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblSuccess" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
