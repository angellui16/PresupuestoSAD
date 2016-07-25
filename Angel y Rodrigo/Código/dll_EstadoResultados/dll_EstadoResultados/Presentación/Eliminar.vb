'*****************************************************************************************
'NOMBRE: DLL_ESTADORESULTADOS
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: ESTADO DE RESULTADOS PRESUPUESTADOS
'DETALLE: ELIMINA ESTADOS DE RESULTADOS CREADOS
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports dllConexion
Imports System.Windows.Forms

Public Class Eliminar
    Private Sub Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatosR()
    End Sub
    Public Sub MostrarDatosR()
        'Carga registros en grid
        Conexion.Consulta("select * from tbl_frm_estadoresultados", "tbl_frm_estadoresultados")
        dgResultados.DataSource = Conexion.ds.Tables("tbl_frm_estadoresultados")

        'Cambia nombre de columna en grid
        dgResultados.Columns(0).HeaderText = "ID"
        dgResultados.Columns(1).HeaderText = "ID Ventas"
        dgResultados.Columns(2).HeaderText = "ID Costo de ventas"
        dgResultados.Columns(3).HeaderText = "ID Gasto de ventas"
        dgResultados.Columns(4).HeaderText = "Nombre presupuesto"
        dgResultados.Columns(5).HeaderText = "Fecha"
        dgResultados.Columns(6).HeaderText = "Utilidad bruta"
        dgResultados.Columns(7).HeaderText = "Utilidad de operación"
        dgResultados.Columns(7).HeaderText = "Ingresos"
        dgResultados.Columns(8).HeaderText = "Utilidad antes de ISR"
        dgResultados.Columns(10).HeaderText = "ISR"
        dgResultados.Columns(11).HeaderText = "Utilidad neta"
        dgResultados.Columns(12).HeaderText = "Empresa"
        dgResultados.Columns(13).HeaderText = "Usuario"
        dgResultados.Columns(14).HeaderText = "Moneda"


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_estadoresultados", "id_estadoresultados= " + txtId.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            MostrarDatosR()
            txtId.Clear()
            txtNombre.Clear()
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub dgResultados_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgResultados.CellContentDoubleClick
        'Muestra datos seleccionados de un grid en textbox
        Dim dgv As DataGridViewRow = dgResultados.Rows(e.RowIndex)

        txtId.Text = dgv.Cells(0).Value.ToString()
        txtNombre.Text = dgv.Cells(4).Value.ToString()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultados As New Resultados
        resultados.Show()
        Me.Close()

    End Sub

End Class