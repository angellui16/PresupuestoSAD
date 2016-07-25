Imports System.Windows.Forms
Imports dll_pImporteCostosIndirectos
Public Class wfPopupIci
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim costoindirecto As New wfImporteCostosIndirectos

        Dim nom As String = txtNombre.Text
        Dim reportes As New wfReporteici
        reportes.nombre = nom

        reportes.ShowDialog()

        costoindirecto.Close()
        Me.Close()



    End Sub
End Class