<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="New_Project_Hope_You_Work.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageTitle" runat="server">
    התחברות
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menuAddition" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainArea" runat="server">
    <div>
        <form id="login" runat="server">
            <table>
                <tr>
                    <td>מייל: </td>
                    <td><input type="text" id="logEmail" name="logEmail" value="<%Response.Write(Email); %>" /></td>                    
                </tr>
                <tr>
                    <td>סיסמה: </td>
                    <td><input type="password" id="logPassword" name="logPassword" value="<%Response.Write(Password); %>"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td style="color:red"><%Response.Write(Error); %></td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" value="שלח" /></td>
                </tr>
            </table>
        </form>        
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
