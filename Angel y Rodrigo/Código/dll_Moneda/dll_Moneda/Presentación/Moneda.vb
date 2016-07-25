'*****************************************************************************************
'NOMBRE: DLL_MONEDA
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: MANTENIMIENTO MONEDA
'DETALLE: AGREGA DIVERSIDAD DE MONEDAS PARA TRABAJAR PRESUPUESTOS
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports dllConexion
Imports System.Windows.Forms
Public Class Moneda

    Private Sub Moneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se conecta y carga datos al grid
        Conexion.Conectado()
        MostrarDatos()
    End Sub
    Public Sub MostrarDatos()

        'Llena grid con datos de monedas
        Conexion.Consulta("select * from tbl_frm_moneda2", "tbl_frm_moneda2")
        dgvDatos.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")

        'Cambia nombre a columnas del grid
        dgvDatos.Columns(0).HeaderText = "ID"
        dgvDatos.Columns(1).HeaderText = "Moneda"
        dgvDatos.Columns(2).HeaderText = "Abreviatura"
        dgvDatos.Columns(3).HeaderText = "Tipo de cambio"

    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        'Muestra datos seleccionados de grid en textbox
        Dim dgv As DataGridViewRow = dgvDatos.Rows(e.RowIndex)
        txtCodigo.Text = dgv.Cells(0).Value.ToString()
        txtMoneda.Text = dgv.Cells(1).Value.ToString()
        txtSimbolo.Text = dgv.Cells(2).Value.ToString()
        txtTipo.Text = dgv.Cells(3).Value.ToString()
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Guarda datos
        Dim guardar As String = "insert into tbl_frm_moneda2 values ('" + txtMoneda.Text + "', '" + txtSimbolo.Text + "', '" + txtTipo.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificar As String = "mnd_moneda2= '" + txtMoneda.Text + "', mnd_abreviatura2= '" + txtSimbolo.Text + "', mnd_tipo_cambio= '" + txtTipo.Text + " '"
        If (Conexion.Modificar("tbl_frm_moneda2", modificar, "id_moneda2=" + txtCodigo.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_moneda2", "id_moneda2= " + txtCodigo.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub


    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        txtCodigo.Clear()
        txtMoneda.Clear()
        txtSimbolo.Clear()
        txtTipo.Clear()
    End Sub
End Class