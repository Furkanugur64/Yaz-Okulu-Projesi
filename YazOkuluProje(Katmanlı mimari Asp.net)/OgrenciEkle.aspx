<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciEkle.aspx.cs" Inherits="YazOkuluProje_Katmanlı_mimari_Asp.net_.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="form1" runat="server">
        <div>

            <table class="nav-justified" style="width: 27%; height: 300px">
                <tr>
                    <td class="modal-sm" style="width: 141px; text-align: right;">
                        <strong>
                        <asp:Label ID="LblAd" runat="server" Text="ÖĞRENCİ AD:"></asp:Label>
                        </strong>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtAd" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 141px; text-align: right;">
                        <strong>
                        <asp:Label ID="LblSoyad" runat="server" Text="ÖĞRENCİ SOYAD:"></asp:Label>
                        </strong>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtSoyad" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 141px; text-align: right;">
                        <strong>
                        <asp:Label ID="LblNo" runat="server" Text="ÖĞRENCİ NUMARA:"></asp:Label></strong></td>
                    <td>
                        <asp:TextBox ID="TxtNo" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 141px; text-align: right;">
                        <strong>
                        <asp:Label ID="LblMail" runat="server" Text="ÖĞRENCİ MAİL:"></asp:Label></strong></td>
                    <td>
                        <asp:TextBox ID="TxtMail" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 141px; text-align: right;">
                        <strong>
                        <asp:Label ID="LblSifre" runat="server" Text="ÖĞRENCİ ŞİFRE:"></asp:Label></strong></td>
                    <td>
                        <asp:TextBox ID="TxtSifre" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                

                <tr>
                    <td class="modal-sm" style="width: 141px">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning" Height="30px" Text="EKLE" Width="96px" OnClick="Button1_Click" />
                    </td>
                </tr>

            </table>

        </div>
    </form>


</asp:Content>
