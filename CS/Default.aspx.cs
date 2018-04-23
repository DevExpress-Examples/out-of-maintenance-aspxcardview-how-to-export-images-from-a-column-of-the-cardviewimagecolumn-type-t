using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxCardViewExporter1_RenderBrick(object sender, DevExpress.Web.ASPxCardViewExportRenderingEventArgs e)
    {
        var dataColumn = e.Column as CardViewColumn;
        if (dataColumn != null && dataColumn.FieldName == "ImagePath")
            e.ImageValue = GetImageBinaryData(e.Value.ToString());
    }
    protected void btnPdfExport_Click(object sender, EventArgs e)
    {
        CardViewExporter.WritePdfToResponse();
    }
    protected void btnXlsExport_Click(object sender, EventArgs e)
    {
        CardViewExporter.WriteXlsToResponse();
    }
    protected void btnXlsxExport_Click(object sender, EventArgs e)
    {
        CardViewExporter.WriteXlsxToResponse();
    }
    protected void btnRtfExport_Click(object sender, EventArgs e)
    {
        CardViewExporter.WriteRtfToResponse();
    }
    protected void btnCsvExport_Click(object sender, EventArgs e)
    {
        CardViewExporter.WriteCsvToResponse();
    }
    byte[] GetImageBinaryData(string relativePath)
    {
        string path = Server.MapPath(relativePath);
        return File.Exists(path) ? File.ReadAllBytes(path) : null;
    }
}