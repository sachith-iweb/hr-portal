<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="notifications.aspx.cs" Inherits="HRM_UserProfile.notifications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
           &nbsp;Notifications (Email Queue)
        </div>

        <div class="divGroupBlockBody">
            
            <telerik:RadListView ID="radLstNotifications" runat="server" OnNeedDataSource="radLstNotifications_NeedDataSource">
                <ItemTemplate>

            <div style="display:block; border:1px #dedede solid; border-radius:3px; padding:5px; margin-bottom:20px;">
                    <a id='<%#Eval("Id") %>' >

                    <table width="100%" cellpadding="3" style="margin-bottom:20px;">
                        
                        <tr><td style="width:200px;" >
             

                            <asp:Label ID="lblProcess0" runat="server" Text="Process" ></asp:Label>
  
                            </td><td rowspan="6" style="width:1px !important; background-color:#dedede; padding:0px;">
           

                              </td>
                            <td rowspan="6" style="vertical-align:top;" >
                          
                 <table cellpadding="0" cellspacing="0" width="100%" >
                                    <tr>
                                        <td width="80px">
               
                                            Subject&nbsp;
     
                   
                 
          
            
                  
                                        </td>
                                        <td>:</td>
                                        <td>
                  

                                            <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("Subject")%>' style="font-size: 16px; font-weight: 700;"></asp:Label>
     
                   
                 
          
             
                  
                                        </td>
                                        <td width="100px">
               

                                        (    <asp:Label ID="Label1" runat="server" Text='<%#Eval("IsReadStatus")%>' style="font-size: 15px"></asp:Label>
     
                   
                 
          
             
                  
                                            )</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>            Message
     
                   
                 
          
           
                  
                                        </td>
                                        <td>:</td>
                                        <td colspan="2">
              

                                            <asp:Label ID="lblMessage" runat="server" Text='<%#Eval("Message")%>' style="font-size: 15px;" ></asp:Label>
     
                
                 
          
                  
                                        </td>
                                    </tr>
                                </table>
     

     
                 
                            </td></tr>
                        <tr><td class="auto-style5" style="vertical-align:top; font-weight: 700;">
                  

                            <asp:Label ID="lblProcess" runat="server" Text='<%#Eval("EventName")%>' style="font-size: 15px; font-weight: 700;"></asp:Label>
   
                            </td></tr>

                        <tr><td class="auto-style5" style="vertical-align:top;">
                 

                            <asp:Label ID="lblFrom2" runat="server" Text="From"></asp:Label>
 
                        </td></tr>

                        <tr><td class="auto-style5" style="vertical-align:top;">
             

                            <asp:Label ID="lblFrom" runat="server" Text='<%#Eval("FromEmployee")%>'  style="font-size: 15px; font-weight: 700;"></asp:Label>
  
                        </td></tr>

                        <tr><td class="auto-style5" style="vertical-align:top;">
                 

                            <asp:Label ID="lblFrom3" runat="server" Text="Date Time"></asp:Label>
    
                        </td></tr>

                        <tr><td class="auto-style5" style="vertical-align:top;">
            

                            <asp:Label ID="lblFrom1" runat="server" Text='<%#Eval("DateTime")%>' style="font-size: 15px; font-weight: 700;"></asp:Label>
     
                            </td></tr>

                        </table>                                           

                    </a>
                </div>
                  
                </ItemTemplate>
            </telerik:RadListView>
             <asp:Label ID="lblNoNotifications" runat="server" Text="There is no more notification(s) to view." style="font-size: 15px"></asp:Label>
        </div>
    </div> 
 
</asp:Content>
