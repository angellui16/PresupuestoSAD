'*****************************************************************************************
'NOMBRE: DLL_USUARIO
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: MANTENIMIENTO USUARIOS
'DETALLE: INGRESA USUARIOS AL SISTEMA
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************

Imports dllConexion
Imports System.Windows.Forms
Public Class Usuarios


    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatos()
    End Sub
    Public Sub MostrarDatos()
        'Llena registros de grid

        Conexion.Consulta("select id_usuario, usr_usuario from tbl_frm_usuario", "tbl_frm_usuario")
        dgvDatos.DataSource = Conexion.ds.Tables("tbl_frm_usuario")

        'cambia nombre a columnas del grid
        dgvDatos.Columns(0).HeaderText = "ID"
        dgvDatos.Columns(1).HeaderText = "Usuario"

    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        'Muestra datos seleccionados del grid en textbox
        Dim dgv As DataGridViewRow = dgvDatos.Rows(e.RowIndex)
        txtCodigo.Text = dgv.Cells(0).Value.ToString()
        txtUsuario.Text = dgv.Cells(1).Value.ToString()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim guardar As String = "insert into tbl_frm_usuario values ('" + txtUsuario.Text + "', '" + txtContraseña.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificar As String = "usr_usuario= '" + txtUsuario.Text + "', usr_password= '" + txtContraseña.Text + "'"
        If (Conexion.Modificar("tbl_frm_usuario", modificar, "id_usuario=" + txtCodigo.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar()
            MostrarDatos()
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_usuario", "id_usuario= " + txtCodigo.Text)) Then
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
        txtUsuario.Clear()
        txtContraseña.Clear()
    End Sub
End Class