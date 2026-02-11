<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HRM_UserProfile._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Human Resource Management System - Scienter Technologies</title>
    <link rel="icon" 
      type="image/png" 
      href="images/favicon.png">





    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .divLoginContainer
        {


background: rgb(245,246,246); /* Old browsers */
/* IE9 SVG, needs conditional override of 'filter' to 'none' */
background: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pgo8c3ZnIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDEgMSIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+CiAgPGxpbmVhckdyYWRpZW50IGlkPSJncmFkLXVjZ2ctZ2VuZXJhdGVkIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjAlIiB5MT0iMCUiIHgyPSIxMDAlIiB5Mj0iMCUiPgogICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iI2Y1ZjZmNiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjIxJSIgc3RvcC1jb2xvcj0iI2RiZGNlMiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjQ5JSIgc3RvcC1jb2xvcj0iI2I4YmFjNiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjgwJSIgc3RvcC1jb2xvcj0iI2RkZGZlMyIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjEwMCUiIHN0b3AtY29sb3I9IiNmNWY2ZjYiIHN0b3Atb3BhY2l0eT0iMSIvPgogIDwvbGluZWFyR3JhZGllbnQ+CiAgPHJlY3QgeD0iMCIgeT0iMCIgd2lkdGg9IjEiIGhlaWdodD0iMSIgZmlsbD0idXJsKCNncmFkLXVjZ2ctZ2VuZXJhdGVkKSIgLz4KPC9zdmc+);
background: -moz-linear-gradient(left,  rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, right top, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */
background: linear-gradient(to right,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=1 ); /* IE6-8 */


border-radius:10px;
padding:15px;
border:2px solid #CCC;

margin-top:3%; margin-right:3%; width:300px; float:right;



 width: 250px;

        }


        html { 
 
         
  background: url(images/bg.jpg) no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;


}

        .auto-style2 {
            width: 106px;
        }

        hr.gradient {
    border: 0;
    height: 1px;
    background-image: -webkit-linear-gradient(left, rgba(0,0,0,0), rgba(0,0,0,0.75), rgba(0,0,0,0)); 
    background-image:    -moz-linear-gradient(left, rgba(0,0,0,0), rgba(0,0,0,0.75), rgba(0,0,0,0)); 
    background-image:     -ms-linear-gradient(left, rgba(0,0,0,0), rgba(0,0,0,0.75), rgba(0,0,0,0)); 
    background-image:      -o-linear-gradient(left, rgba(0,0,0,0), rgba(0,0,0,0.75), rgba(0,0,0,0)); 
}

        .loginButton
{
	
color:Black;
height:35px;

border-radius:5px;
font-family:Trebuchet MS;
font-weight:bold;

cursor:pointer;

background: rgb(238,238,238); /* Old browsers */
background: -moz-linear-gradient(top,  rgba(238,238,238,1) 0%, rgba(204,204,204,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(238,238,238,1)), color-stop(100%,rgba(204,204,204,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  rgba(238,238,238,1) 0%,rgba(204,204,204,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  rgba(238,238,238,1) 0%,rgba(204,204,204,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  rgba(238,238,238,1) 0%,rgba(204,204,204,1) 100%); /* IE10+ */
background: linear-gradient(to bottom,  rgba(238,238,238,1) 0%,rgba(204,204,204,1) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#eeeeee', endColorstr='#cccccc',GradientType=0 ); /* IE6-9 */

border:1px solid gray;

}


    </style>


    <link href="css/common.css" rel="stylesheet" />



</head>
<body style="font-size:14px;">
    <form id="form1" runat="server">
<div style="width:100%;">

    <div class="divLoginContainer" >
        <center>
            <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
            </telerik:RadScriptManager>
        <img src="images/login_screen_logo_black.png" width="250px" />
        <br />
            <hr class="gradient" />
       <span style=" text-transform:uppercase; font-size: 14px; font-weight: 700;">Employee Profile Login</span> 
            <hr class="gradient" />
        
            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td><center>Username</center> </td>
                </tr>
                <tr>
                    <td>
                        <telerik:RadTextBox ID="txtUsername" Runat="server" Skin="Silk" Width="100%">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                </tr>
                <tr>
                    <td><center>Password</center></td>
                </tr>
                <tr>
                    <td>

                        <telerik:RadTextBox ID="txtPassword" Runat="server" Skin="Silk" Width="100%" TextMode="Password">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                </tr>

                 <tr>
                    <td style="text-align:center;">
                       
                       <asp:Label ID="lblMessage" runat="server" Font-Bold="False" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <hr class="line" />
                        <asp:Button ID="btnLogin" CssClass="loginButton" runat="server" Font-Bold="False" Font-Size="Medium" Height="40px" Text="Login" Width="100%" OnClick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnClear" CssClass="loginButton" runat="server" Font-Bold="False" Font-Size="Medium" Height="35px" Text="Clear" Width="100%" />
                    </td>
                </tr>

                 <tr>
                    <td style="color:#808080; font-size:12px;">
                        <center>
                     <hr class="gradient" />
                          <span class="style16">&nbsp;- </span> <b style="font-size: small">
                            <span class="style16">© Scienter Technologies -</span><br class="style16" />
                            <span class="style16">All Rights Reserved - www.scienter.lk</span></b>
                     <hr class="gradient" />

                        </center>
                    </td>
                </tr>

            </table>

        </center>
    </div>

</div>
        <telerik:RadWindow ID="RadWindow1" runat="server" EnableViewState="False" Skin="Silk" VisibleStatusbar="False" VisibleTitlebar="False">
            <ContentTemplate>
                <table cellpadding="5" cellspacing="5" width="100%">
                    <tr>
                        <td bgcolor="#cccccc" colspan="5">
                            <asp:Label ID="Label6" runat="server" CssClass="continue" Text="Continue ..."></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="Label5" runat="server" CssClass="continue" Text="You have multiple company access. Select a company to continue.."></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <telerik:RadComboBox ID="cmbCompany" Runat="server" OnDataBound="cmbCompany_DataBound" OnSelectedIndexChanged="cmbCompany_SelectedIndexChanged" Skin="Silk" ViewStateMode="Enabled" Width="350px">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cmbCompany" ErrorMessage="*" Font-Bold="True" Font-Size="Large" ForeColor="#ff0000" InitialValue="------------ Select Company ----------" SetFocusOnError="true" Text="*" ValidationGroup="c"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="btnContinue" runat="server" Height="30px"  Text="Continue ..." ValidationGroup="c" Width="125px" />
                        </td>
                        <td class="auto-style2">
                            <asp:Button ID="btnExit" runat="server" Height="30px" onclick="btnExit_Click" Text="Exit" Width="70px" />
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td align="right">&nbsp;</td>
                    </tr>
                </table>
            </ContentTemplate>
        </telerik:RadWindow>
        <br />
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
        </telerik:RadWindowManager>
    </form>
</body>
</html>
