<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersKayıt.aspx.cs" Inherits="YazOkuluProje_Katmanlı_mimari_Asp.net_.DersKayıt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <table style="height: 160px">
            <tr>
                <td style="width: 175px" class="text-right">
                    <asp:Label ID="LblDersAd" runat="server" Text="Ders Adı:"></asp:Label>
                &nbsp;</td>
                <td>
                    <asp:TextBox ID="TxtDersAd" runat="server" style="margin-left: 4px" Width="132px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 175px" class="text-right">
                    <asp:Label ID="LblMin" runat="server" Text="Ders Minumum Kontenjan:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtMin" runat="server" style="margin-left: 4px" Width="40px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 175px" class="text-right">
                    <asp:Label ID="LblMax" runat="server" Text="Ders Maksimum Kontenjan:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TxtMax" runat="server" style="margin-left: 4px" Width="40px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 175px">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnEkle" CssClass="btn btn-danger" runat="server" Height="32px" Text="Ders Ekle" Width="109px" OnClick="BtnEkle_Click" />
                </td>
            </tr>
        </table>

        <div><img src="Resimler/Yazokulu.jpg" width="750">



        </div>
    </form>
</asp:Content>
