<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="UpdateForm.aspx.cs" Inherits="New_Project_Hope_You_Work.Pages.UpdateForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageTitle" runat="server">
    עדכון נתונים קיימים
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menuAddition" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainArea" runat="server">
    <form id="updateP" runat="server">
        <div>
            <table>
                 <tr>
                    <td>שם פרטי: </td>
                    <td><input type ="text" id="firstName" name="firstName" value="<%Response.Write(FirstName); %>" /></td> <td style="color:red"><%Response.Write(FirstNError); %> </td>
                </tr>
                 <tr>
                    <td>שם משפחה: </td>
                    <td><input type ="text" id="lastName" name="lastName" value="<%Response.Write(LastName); %>" /></td> <td style="color:red"><%Response.Write(LastNError); %> </td>
                </tr>
                 <tr>
                    <td>סיסמה: </td>
                    <td><input type ="text" id="password" name="password" /></td> <td style="color:red"><%Response.Write(PassError); %> </td> 
                </tr>              
                 <tr>
                    <td>מייל: </td>
                    <td> <%Response.Write(Email); %> </td> 
                </tr>
                <tr>
                    <td>מין: </td>
                    <td><input type ="radio" id ="male" name ="gender" value ="male" <%Response.Write(MaleCh); %> /><label> זכר </label>
                    <input type ="radio" id ="female" name ="gender" value ="female" <%Response.Write(FemaleCh); %> /><label> נקבה </label> 
                    <input type ="radio" id ="other" name ="gender" value ="other" <%Response.Write(otherCh); %> /><label> אחר </label>  </td> <td style="color:red"><%Response.Write(GenError); %> </td>
                </tr>
                <tr>
                    <td>סוג המכוניות האהובות עליך: </td>
                    <td><input type ="checkbox" id ="private" name ="favCar" value ="private" /><label> פרטי </label>
                        <input type ="checkbox" id ="offRoad" name ="favCar" value ="offRoad" /><label> שטח </label>
                        <input type ="checkbox" id ="sport" name ="favCar" value ="sport" /><label> ספורט </label> 
                        <input type ="checkbox" id ="superCar" name ="favCar" value ="superCar" /><label> מכונית על </label> </td> <td style="color:red"><%Response.Write(FavCarError); %> </td>
                </tr>
                 <tr>
                    <td>תכתוב פה על המכונית הראשונה שלך: </td>
                    <td><textarea name ="multiLine" cols ="40" rows ="5" <%--איך לעשות שגם פה ירשום לי את מה שהלקוח כבר רשם--%> ></textarea> </td> <td style="color:red"><%Response.Write(MultiLineError); %> </td>
                </tr>
                <tr>
                    <td>שנת לידה: </td>
                    <td><select name="dateOfBirth">        
                        <option value= "a" >בחר שנת לידה</option>
                        <option value="2007">2007</option>
                        <option value="2006">2006</option>
                        <option value="2005">2005</option>
                        <option value="2004">2004</option>
                        <option value="2003">2003</option>
                        <option value="2002">2002</option>
                        <option value="2001">2001</option>
                        <option value="2000">2000</option>
                        <option value="1999">1999</option>
                        <option value="1998">1998</option>
                        <option value="1997">1997</option>
                        <option value="1996">1996</option>
                        <option value="1995">1995</option>
                        <option value="1994">1994</option>
                        <option value="1993">1993</option>
                        <option value="1992">1992</option>
                        <option value="1991">1991</option>
                        <option value="1990">1990</option>
                        <option value="1989">1989</option>
                        <option value="1988">1988</option>
                        <option value="1987">1987</option>
                        <option value="1986">1986</option>
                        <option value="1985">1985</option>
                        <option value="1984">1984</option>
                        <option value="1983">1983</option>
                        <option value="1982">1982</option>
                        <option value="1981">1981</option>
                        <option value="1980">1980</option>
                        <option value="1979">1979</option>
                        <option value="1978">1978</option>
                        <option value="1977">1977</option>
                        <option value="1976">1976</option>
                        <option value="1975">1975</option>
                        <option value="1974">1974</option>
                        <option value="1973">1973</option>
                        <option value="1972">1972</option>
                        <option value="1971">1971</option>
                        <option value="1970">1970</option>
                        <option value="1969">1969</option>
                        <option value="1968">1968</option>
                        <option value="1967">1967</option>
                        <option value="1966">1966</option>
                        <option value="1965">1965</option>
                        <option value="1964">1964</option>
                        <option value="1963">1963</option>
                        <option value="1962">1962</option>
                        <option value="1961">1961</option>
                        <option value="1960">1960</option>
                        <option value="1959">1959</option>
                        <option value="1958">1958</option>
                        <option value="1957">1957</option>
                        <option value="1956">1956</option>
                        <option value="1955">1955</option>
                        <option value="1954">1954</option>
                        <option value="1953">1953</option>
                        <option value="1952">1952</option>
                        <option value="1951">1951</option>
                        <option value="1950">1950</option>
                        <option value="1949">1949</option>
                        <option value="1948">1948</option>
                        <option value="1947">1947</option>
                        <option value="1946">1946</option>
                        <option value="1945">1945</option>
                        <option value="1944">1944</option>
                        <option value="1943">1943</option>
                        <option value="1942">1942</option>
                        <option value="1941">1941</option>
                        <option value="1940">1940</option>
                        <option value="1939">1939</option>
                        <option value="1938">1938</option>
                        <option value="1937">1937</option>
                        <option value="1936">1936</option>
                        <option value="1935">1935</option>
                        <option value="1934">1934</option>
                        <option value="1933">1933</option>
                        <option value="1932">1932</option>
                        <option value="1931">1931</option>
                        <option value="1930">1930</option>
                        <option value="1929">1929</option>
                        <option value="1928">1928</option>
                        <option value="1927">1927</option>
                        <option value="1926">1926</option>
                        <option value="1925">1925</option>
                        <option value="1924">1924</option>
                        <option value="1923">1923</option>
                        <option value="1922">1922</option>
                        <option value="1921">1921</option>
                        <option value="1920">1920</option>
                        <option value="1919">1919</option>
                        <option value="1918">1918</option>
                        <option value="1917">1917</option>
                        <option value="1916">1916</option>
                        <option value="1915">1915</option>
                        <option value="1914">1914</option>
                        <option value="1913">1913</option>
                        <option value="1912">1912</option>
                        <option value="1911">1911</option>
                        <option value="1910">1910</option>
                        <option value="1909">1909</option>
                        <option value="1908">1908</option>
                        <option value="1907">1907</option>
                        <option value="1906">1906</option>
                        <option value="1905">1905</option>
                        <option value="1909">1904</option>
                        <option value="1908">1903</option>
                        <option value="1907">1902</option>
                        <option value="1906">1901</option>
                        <option value="1905">1900</option>
                    </select> <td style="color:red"><%Response.Write(DOBError); %> </td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type ="submit" value ="שלח" /><input type ="reset"value ="ניקוי" /></td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
