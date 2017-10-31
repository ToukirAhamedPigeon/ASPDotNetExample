<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ASPDotNetProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ViewState</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <h1>ViewState Example</h1>
    <hr />
    <br />
    <form id="form1" runat="server">
        <div>
           <p>ViewState is a variable which can store any types of data and it stay between server and client side both. In client side, if you inspect the html page source, you will find view states variable is saved as a hidden field and it&#39;s value is encrypted. On other hand, when client sent a postback request to the server, before the page_load function runs, all viewstates variable value is retrieved by server. In .aspx files when we use the ASPX standards fields or tools, by default server declare viewstate variable for those fields which can be retrieved and preserved in a postback request. That&#39;s why a ASPX stanadard field can preserve it&#39;s value after a postback request to the server. But, normal html fields can&#39;t. Point to be noticed, viewstate variable is only can be accessed from that specific webform in which it has been declared. Tips: A normal html control field can be converted in a ASPX stanadrd field by adding only an attribute to the specific field.That is: runat=&quot;server&quot;</p>
            <br />
        </div>
        <asp:TextBox ID="TextBoxNumber" runat="server">0</asp:TextBox>
&nbsp;<br />
        <p>It&#39;s ASPX standards textbox which value shoud be incremented by clicking the button bellow.</p><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Num++" class="button" />
    </form>
</body>
</html>
