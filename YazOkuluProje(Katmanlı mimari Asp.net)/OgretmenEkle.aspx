<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgretmenEkle.aspx.cs" Inherits="YazOkuluProje_Katmanlı_mimari_Asp.net_.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified" style="width: 27%; height: 159px">
            <tr>
                <td class="modal-sm" style="width: 591px; text-align: right; height: 39px;">
                    <strong>
                        <asp:Label ID="LblAd" runat="server" Text="ÖĞRETMEN AD:"></asp:Label>
                    </strong>
                </td>
                <td style="height: 39px">
                    <asp:TextBox ID="TxtAd" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 591px; text-align: right; height: 70px;">
                    <strong>
                        <asp:Label ID="LblSoyad" runat="server" Text="ÖĞRENCİ BRANŞ:"></asp:Label>
                    </strong>
                </td>
                <td style="height: 70px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="197px"></asp:DropDownList>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 591px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning" Height="30px" Text="EKLE" Width="96px" OnClick="Button1_Click"  />
                </td>
            </tr>


        </table>
    </form>
</asp:Content>
