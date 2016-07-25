Public Class frPopupMO
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim manoobra As New frCostoManoObraDirecta

        Dim nom As String = txtNombre.Text
        Dim reportes As New frReporteMO
        reportes.nombre = nom
        reportes.ShowDialog()
        manoobra.Close()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class