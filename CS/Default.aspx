<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table>
            <tr>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnPdfExport" runat="server" Text="Export to PDF" OnClick="btnPdfExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnXlsExport" runat="server" Text="Export to XLS" OnClick="btnXlsExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnXlsxExport" runat="server" Text="Export to XLSX" OnClick="btnXlsxExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnRtfExport" runat="server" Text="Export to RTF" OnClick="btnRtfExport_Click" />
                </td>
                <td>
                    <dx:ASPxButton ID="btnCsvExport" runat="server" Text="Export to CSV" OnClick="btnCsvExport_Click" />
                </td>
            </tr>
        </table>  
        <dx:ASPxCardView ID="CardView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
            <Columns>
                <dx:CardViewTextColumn Caption="Common Name" FieldName="Common_Name" VisibleIndex="0">
                </dx:CardViewTextColumn>
                <dx:CardViewTextColumn Caption="Species Name" FieldName="Species_Name" VisibleIndex="1">
                </dx:CardViewTextColumn>
                <dx:CardViewImageColumn Caption="Image" FieldName="ImagePath" VisibleIndex="2">
                    <PropertiesImage ImageHeight="120px" ImageWidth="180px">
                    </PropertiesImage>
                </dx:CardViewImageColumn>
            </Columns>
        </dx:ASPxCardView>
        <dx:ASPxCardViewExporter CardWidth="310" ID="CardViewExporter" CardViewID="CardView1" OnRenderBrick="ASPxCardViewExporter1_RenderBrick" runat="server"></dx:ASPxCardViewExporter>  
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Fishes.xml" />
    </div>
    </form>
</body>
</html>
