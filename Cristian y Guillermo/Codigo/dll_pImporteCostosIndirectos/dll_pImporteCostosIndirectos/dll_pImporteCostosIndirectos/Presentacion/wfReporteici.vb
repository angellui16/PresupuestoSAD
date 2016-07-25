Public Class wfReporteici
    Public nombre As String
    Private Sub wfReporteici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptPici2
        objreporte.SetParameterValue("@nombre", nombre)
        crIci.ReportSource = objreporte
    End Sub
End Class