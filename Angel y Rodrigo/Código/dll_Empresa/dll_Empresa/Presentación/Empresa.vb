'*****************************************************************************************
'NOMBRE: DLL_EMPRESA
'FECHA: 27/06/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: MANTENIMIENTO EMPRESA
'DETALLE: MÓDULO PARA AGREGAR EMPRESAS
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports dllConexion
Imports System.Windows.Forms
Public Class Empresa

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Realiza conexión y carga datos a grid maestro
        Conexion.Conectado()
        MostrarDatos()

    End Sub

    Public Sub MostrarDatos()
        'Llenar grid
        Conexion.Consulta("select * from tbl_frm_empresa2", "tbl_frm_empresa2")
        dgvDatos.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")

        'Renombrando columnas del grid
        dgvDatos.Columns(0).HeaderText = "ID"
        dgvDatos.Columns(1).HeaderText = "Nombre empresa"
        dgvDatos.Columns(2).HeaderText = "Dirección"
        dgvDatos.Columns(3).HeaderText = "Teléfono"
        dgvDatos.Columns(4).HeaderText = "NIT"

    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        'Muestra registros de grid en textbox
        Dim dgv As DataGridViewRow = dgvDatos.Rows(e.RowIndex)
        txtCodigo.Text = dgv.Cells(0).Value.ToString()
        txtNombre.Text = dgv.Cells(1).Value.ToString()
        txtDireccion.Text = dgv.Cells(2).Value.ToString()
        txtTelefono.Text = dgv.Cells(3).Value.ToString()
        txtNit.Text = dgv.Cells(4).Value.ToString()
    End Sub


    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim guardar As String = "insert into tbl_frm_empresa2 values ('" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtNit.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificar As String = "emp_nombre_empresa2= '" + txtNombre.Text + "', emp_direccion= '" + txtDireccion.Text + "', emp_telefono= '" + txtTelefono.Text + "', emp_nit= '" + txtNit.Text + "'"
        If (Conexion.Modificar("tbl_frm_empresa2", modificar, "id_empresa2=" + txtCodigo.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_empresa2", "id_empresa2= " + txtCodigo.Text)) Then
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
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtNit.Clear()
    End Sub
End Class