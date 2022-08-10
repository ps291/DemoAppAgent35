<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebAPICall.aspx.cs" Inherits="PrakharTesting35.WebAPICall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
    <h1>WebApi Call done Successfully</h1>
<br />

<h6>BackEnd External APIs Call Successfully [GET, POST, DELETE]</h6>
<code><ul>
    <li>Post https://services.odata.org/TripPinRESTierService/ResetDataSource </li>
    <br />
    <li>Delete Lambda Data https://services.odata.org/TripPinRESTierService/People('russellwhyte') </li>
    <br />
    <li>Get Data https://gorest.co.in/public/v2/ </li>
    <br />
    <li>Get Querying Data https://services.odata.org/TripPinRESTierService/GetNearestAirport(lat = 33, lon = -118) </li>
    <br />
    <li>Get Querying Data https://services.odata.org/TripPinRESTierService/Airports?$filter=contains(Location/Address, 'San Francisco') </li>
    <br />
    <li>Get Etag https://services.odata.org/TripPinRESTierService/Airlines </li>
</ul>
</code>
<br /><br />
</div>
</asp:Content>
