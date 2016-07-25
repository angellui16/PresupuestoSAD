Public Class frPopupCMD
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim materiales As New frCMaterialesDirectos

        Dim nom As String = txtNombre.Text
        Dim reportes As New frReporteMateriales
        reportes.nombre = nom

        reportes.ShowDialog()
        materiales.Close()
        Me.Close()
    End Sub

    Private Sub frPopupCMD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class