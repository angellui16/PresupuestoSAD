'*****************************************************************************************
'NOMBRE: DLL_GVA
'FECHA: 03/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: REPORTE PRESUPUESTO GASTOS DE VENTA Y ADMINISTRACIÓN
'DETALLE: MUESTRA REPORTE LUEGO DE GENERAR UN PRESUPUESTO DE GASTOS DE VENTA Y ADMINISTRACIÓN
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Public Class ReporteGva
    'se declara variable para setear el parámetro 
    Public nombre As String
    Private Sub ReporteGva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptPresupuestoGva
        objreporte.SetParameterValue("@nombre", nombre)

        crGva.ReportSource = objreporte
    End Sub
End Class