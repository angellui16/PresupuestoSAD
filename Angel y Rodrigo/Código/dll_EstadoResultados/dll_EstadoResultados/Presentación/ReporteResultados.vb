'*****************************************************************************************
'NOMBRE: DLL_ESTADORESULTADOS
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: REPORTE ESTADO DE RESULTADOS PRESUPUESTADOS
'DETALLE: MUESTRA LOS REPORTES CREADOS EN EL MODULO
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Public Class ReporteResultados
    Public nombre As String

    Private Sub ReporteResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setea valores a variable
        Dim objreporte As New rptResultados
        objreporte.SetParameterValue("@nombre", nombre)

        crResultados.ReportSource = objreporte
    End Sub
End Class