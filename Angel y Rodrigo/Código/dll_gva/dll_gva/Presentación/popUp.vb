'*****************************************************************************************
'NOMBRE: DLL_GVA
'FECHA: 03/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: POPUP PRESUPUESTO GASTOS DE VENTA Y ADMINISTRACIÓN
'DETALLE: FORMULARIO DE INGRESO DE PARÁMETROS PARA GENERAR REPORTE
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports System.Windows.Forms
Public Class popUp
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If txtNombre.Text <> "" Then

            'cerrar form presupuesto gva
            Dim gva As New gva

            'parametro del procedimiento almacenado
            Dim nom As String = txtNombre.Text
            Dim reportes As New ReporteGva
            reportes.nombre = nom

            'llemando dt con datos del grid
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            dt = gva.dgVenta.DataSource
            dt2 = gva.dgAdmon.DataSource

            Dim Cr As New rptPresupuestoGva
            Cr.SetDataSource(dt)
            Cr.SetDataSource(dt2)

            reportes.crGva.ReportSource = Cr
            reportes.ShowDialog()
            gva.Close()
            Me.Close()
        Else
            MessageBox.Show("Debe ingresar un nombre", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class