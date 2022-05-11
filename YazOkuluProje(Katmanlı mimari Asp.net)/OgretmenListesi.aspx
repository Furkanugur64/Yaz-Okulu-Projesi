<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgretmenListesi.aspx.cs" Inherits="YazOkuluProje_Katmanlı_mimari_Asp.net_.OgretmenListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered table-hover">

          <tr>
            <th>Öğretmen ID</th>
            <th>Öğretmen Ad-Soyad</th>
            <th>Öğrenci Branş</th>
            <th>İşlemler</th>
         </tr>
         <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrtid") %></td>
                        <td><%#Eval("Ogrtad") %></td>
                        <td><%#Eval("Ogrtbrans") %></td>                       
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgretmenSil.aspx?OGRTID="+Eval("Ogrtid") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgretmenGuncelle.aspx?OGRTID="+Eval("Ogrtid") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
     </table>
</asp:Content>
