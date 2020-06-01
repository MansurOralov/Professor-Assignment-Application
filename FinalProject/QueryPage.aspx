<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QueryPage.aspx.cs" Inherits="FinalProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Mode:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Query" AutoPostBack="true" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Assignment" AutoPostBack="true" OnCheckedChanged="RadioButton2_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Check" AutoPostBack="true" OnCheckedChanged="RadioButton3_CheckedChanged" />
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Education:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" Text="Both" OnCheckedChanged="RadioButton4_CheckedChanged" AutoPostBack="true" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton5" runat="server" Text="Masters'" OnCheckedChanged="RadioButton5_CheckedChanged" AutoPostBack="true" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton6" runat="server" Text="PhD" OnCheckedChanged="RadioButton6_CheckedChanged" AutoPostBack="true" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Course Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="code" runat="server" Width="126px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Height="43px" OnClick="Button2_Click" Text="Find" Width="113px" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Professor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="450px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Next" Width="98px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Assign to Teach" Width="106px" OnClick="Button4_Click" />
            <br />
            <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Show Data" AutoPostBack="true" OnClick="Button1_Click" Width="164px"/>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Check" Width="102px" />
            <br />
            <asp:Label ID="info" runat="server"></asp:Label>
            <br />
            <asp:Label ID="info1" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</asp:Content>
