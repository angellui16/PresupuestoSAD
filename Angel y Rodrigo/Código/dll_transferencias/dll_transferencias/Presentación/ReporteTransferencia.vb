Public Class ReporteTransferencia
    Public fechainicial As Date
    Public fechafinal As Date

    Private Sub ReporteTransferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptTransferencias
        objreporte.SetParameterValue("@fecha", fechainicial)
        objreporte.SetParameterValue("@fecha2", fechafinal)

        crTransferencia.ReportSource = objreporte
    End Sub
End Class