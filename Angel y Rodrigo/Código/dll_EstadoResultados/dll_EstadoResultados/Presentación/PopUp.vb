'*****************************************************************************************
'NOMBRE: DLL_ESTADORESULTADOS
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: ESTADO DE RESULTADOS PRESUPUESTADOS
'DETALLE: SOLICITA PARAMETROS PARA REPORTE
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports System.Windows.Forms
Public Class PopUp
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If txtNombre.Text <> "" Then

            'cerrar form estado de resultados
            Dim resultados As New Resultados

            'Carga string a una variable
            Dim nom As String = txtNombre.Text
            Dim reportes As New ReporteResultados
            reportes.nombre = nom

            reportes.ShowDialog()
            resultados.Close()
            Me.Close()
        Else
            MessageBox.Show("Debe ingresar un nombre", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class