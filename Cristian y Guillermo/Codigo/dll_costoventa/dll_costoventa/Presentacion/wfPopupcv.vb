
Imports System.Windows.Forms
Imports dll_costoventa

Public Class wfPopupcv
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim costoventa As New wfCostoVenta

        Dim nom As String = txtNombre.Text
        Dim reportes As New wfReportecv
        reportes.nombre = nom

        reportes.ShowDialog()

        costoventa.Close()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub wfPopupcv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class