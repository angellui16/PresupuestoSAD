Public Class frReporteMateriales
    Public nombre As String
    Private Sub frReporteMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptMaterialesDirectos
        objreporte.SetParameterValue("@nombre", nombre)

        crMateriales.ReportSource = objreporte
    End Sub
End Class