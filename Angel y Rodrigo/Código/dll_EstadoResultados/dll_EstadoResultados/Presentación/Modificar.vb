Imports dllConexion
Imports System.Windows.Forms
Public Class Modificar
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Dim modificar As String = "erp_nombre= '" + txtNombre.Text + "', erp_periodo= '" + dtpPeriodo.Value.Date + "'"
        'If (Conexion.Modificar("tbl_frm_estadoresultados", modificar, "id_estadoresultados=" + txtId.Text)) Then
        '    MessageBox.Show("Datos modificados correctamente")
        '    MostarDatosR()
        '    txtId.Clear()
        '    txtNombre.Clear()
        'Else
        '    MessageBox.Show("Error al modificar")
        'End If
    End Sub

    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatosR()
    End Sub
    Public Sub MostrarDatosR()
        Conexion.Consulta("select * from tbl_frm_estadoresultados", "tbl_frm_estadoresultados")
        dgResultados.DataSource = Conexion.ds.Tables("tbl_frm_estadoresultados")
    End Sub
    Private Sub dgResultados_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgResultados.CellContentDoubleClick
        Dim dgv As DataGridViewRow = dgResultados.Rows(e.RowIndex)

        txtId.Text = dgv.Cells(0).Value.ToString()
        txtNombre.Text = dgv.Cells(2).Value.ToString()
    End Sub
End Class
