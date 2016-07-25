Public Class frReporteMO
    Public nombre As String
    Private Sub frReporteMO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objreporte As New rptManoObra
        objreporte.SetParameterValue("@nombre", nombre)

        crManoObra.ReportSource = objreporte

    End Sub
End Class