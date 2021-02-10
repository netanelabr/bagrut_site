<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="regForm.aspx.cs" Inherits="New_Project_Hope_You_Work.Pages.regForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageTitle" runat="server">
    טופס הרשמה
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menuAddition" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainArea" runat="server">
  <body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>שם פרטי: </td>
                    <td><input type ="text" id="firstName" name="firstName" /></td>
                </tr>
                 <tr>
                    <td>שם משפחה: </td>
                    <td><input type ="text" id="lastName" name="lastName" /></td>
                </tr>
                 <tr>
                    <td>סיסמה: </td>
                    <td><input type ="password" id="password" name="password" /></td> <td><%Response.Write(PassError); %> </td> 
                </tr>
                <tr>
                    <td>אימות סיסמה: </td>
                    <td><input type ="password" id="verPassword" name="verPassword" /></td> 
                </tr>
                 <tr>
                    <td>מייל: </td>
                    <td><input type ="text" id="email" name="email" /></td> <%Response.Write(EmailError); %>
                </tr>
                <tr>
                    <td>מין: </td>
                    <td><input type ="radio" id ="male" name ="gender" value ="male"<label> זכר </label>
                    <input type ="radio" id ="female" name ="gender" value ="female" <label> נקבה </label> 
                    <input type ="radio" id ="other" name ="gender" value ="other" <label> אחר </label>  </td>
                </tr>
                <tr>
                    <td>סוג המכוניות האהובות עליך: </td>
                    <td><input type ="checkbox" id ="private" name ="favCar" value ="private" <label> פרטי </label>
                        <input type ="checkbox" id ="offRoad" name ="favCar" value ="offRoad" <label> שטח </label>
                        <input type ="checkbox" id ="sport" name ="favCar" value ="sport" <label> ספורט </label> 
                        <input type ="checkbox" id ="superCar" name ="favCar" value ="superCar" <label> מכונית על </label> </td>
                </tr>
                 <tr>
                    <td>תכתוב פה על המכונית הראשונה שלך: </td>
                    <td><textarea name ="multiLine" cols ="40" rows ="5"></textarea> </td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type ="submit" value ="שלח" /><input type ="reset"value ="ניקוי" /></td>
                </tr>
            </table>
            <br />
            <br />
            <br />

            
            <p style ="font-style:oblique; color:black">  <%Response.Write(FirstName); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(LastName); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(Password); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(VerPass); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(Email); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(Gender); %></p>
            <p style ="font-style:oblique; color:black">  <%Response.Write(FavCar); %></p>
             <p style ="font-style:oblique; color:black">  <%Response.Write(MultiLine); %></p>

        </div>
    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
   
</asp:Content>
