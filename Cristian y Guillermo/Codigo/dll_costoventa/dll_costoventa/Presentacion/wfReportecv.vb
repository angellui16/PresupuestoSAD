Public Class wfReportecv
    Public nombre As String
    Private Sub wfReportecv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptPcv2
        objreporte.SetParameterValue("@nombre", nombre)
        crCv.ReportSource = objreporte
    End Sub
End Class