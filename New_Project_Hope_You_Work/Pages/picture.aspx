<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="picture.aspx.cs" Inherits="New_Project_Hope_You_Work.Pages.picture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageTitle" runat="server">
    תמונות
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menuAddition" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainArea" runat="server">
    <u>סוגי המכוניות</u>
        <li>
            סילברדו
            <img class="images" id="images" src="../Images/silverado.jfif" alt="silverado pic" />
        </li>
        <li>
            קאמרו
            <img class="images" id="images" src="../Images/camero.jfif" alt="camero pic" />
        </li>
        <li>
            מאליבו
            <img class="images" id="images" src="../Images/malibo.jfif" alt="malibo pic" />
        </li>
        </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">      
    זהו אתר שבנה נתנאל אברהם
</asp:Content>
