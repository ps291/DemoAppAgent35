<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HttpCall.aspx.cs" Inherits="PrakharTesting35.HttpCall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script>

    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        document.getElementById("demo").value =
            this.responseText;
    }
    xhttp.open("GET", "https://gorest.co.in/public/v2/users");
    xhttp.send();

</script>
<div>
    <h1>Http Call</h1>
    <input id="demo" type="text" style="max-width: 1000px !important; width: 1000px !important; height: 50px !important" />
    <br />
    <br />
    <a href="https://google.com">Redirect to Google.com</a>
</div>
</asp:Content>
