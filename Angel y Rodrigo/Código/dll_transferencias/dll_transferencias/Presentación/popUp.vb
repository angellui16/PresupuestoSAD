Imports System.Windows.Forms
Public Class popUp
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        'cerrar form presupuesto gva
        Dim transferencia As New transferencia

        'parametro del procedimiento almacenado
        Dim fechainic As Date = CDate(dtFecha.Text)
        Dim fechafin As Date = CDate(dtFecha2.Text)

        Dim reportes As New ReporteTransferencia

        reportes.fechainicial = fechainic
        reportes.fechafinal = fechafin

        reportes.ShowDialog()
        transferencia.Close()
        Me.Close()

    End Sub
End Class