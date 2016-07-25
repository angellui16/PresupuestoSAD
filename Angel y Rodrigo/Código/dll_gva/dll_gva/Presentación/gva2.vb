'***************************************************************************************************************
'NOMBRE: DLL_GVA
'FECHA: 03/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: PRESUPUESTO GASTOS DE VENTA Y ADMINISTRACIÓN
'DETALLE: MÓDULO DE FINANZAS PARA REALIZAR PRESUPUESTO DE GASTOS DE VENTA Y ADMINISTRACIÓN CONSUMIENDO WEBSERVICE
'MODIFICACIÓN: 20/07/16
'****************************************************************************************************************
Imports dllConexion
Imports System.Windows.Forms
Public Class gva2
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub gva2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class