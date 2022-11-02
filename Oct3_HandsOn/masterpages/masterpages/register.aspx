<%@ Page Title="" Language="C#" MasterPageFile="~/library1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="masterpages.login" %>

   
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        
&nbsp;
     <div>   <asp:Label ID="Label4" runat="server" Text="enter name"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox3" runat="server"  style="margin-bottom: 23px" Height="16px"></asp:TextBox>
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    <asp:Label ID="Label1" runat="server" Text="enter the userid"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="enter the password"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="register" />
</p> </div>
    <asp:Label ID="lbl0" runat="server" Text=" please register or"></asp:Label>
    <asp:LinkButton runat="server" PostBackUrl="~/login.aspx">login</asp:LinkButton>
</asp:Content>
       
  
