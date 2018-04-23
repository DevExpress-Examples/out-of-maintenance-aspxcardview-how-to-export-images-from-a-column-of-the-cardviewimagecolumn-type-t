Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxCardViewExporter1_RenderBrick(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxCardViewExportRenderingEventArgs)
        Dim dataColumn = TryCast(e.Column, CardViewColumn)
        If dataColumn IsNot Nothing AndAlso dataColumn.FieldName = "ImagePath" Then
            e.ImageValue = GetImageBinaryData(e.Value.ToString())
        End If
    End Sub
    Protected Sub btnPdfExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        CardViewExporter.WritePdfToResponse()
    End Sub
    Protected Sub btnXlsExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        CardViewExporter.WriteXlsToResponse()
    End Sub
    Protected Sub btnXlsxExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        CardViewExporter.WriteXlsxToResponse()
    End Sub
    Protected Sub btnRtfExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        CardViewExporter.WriteRtfToResponse()
    End Sub
    Protected Sub btnCsvExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        CardViewExporter.WriteCsvToResponse()
    End Sub
    Private Function GetImageBinaryData(ByVal relativePath As String) As Byte()
        Dim path As String = Server.MapPath(relativePath)
        Return If(File.Exists(path), File.ReadAllBytes(path), Nothing)
    End Function
End Class