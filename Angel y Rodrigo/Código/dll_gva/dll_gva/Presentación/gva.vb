'*****************************************************************************************
'NOMBRE: DLL_GVA
'FECHA: 03/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: PRESUPUESTO GASTOS DE VENTA Y ADMINISTRACIÓN
'DETALLE: MÓDULO DE FINANZAS PARA REALIZAR PRESUPUESTO DE GASTOS DE VENTA Y ADMINISTRACIÓN
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************

Imports dllConexion
Imports dll_transferencias.transferencia
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class gva
    Private Sub gva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatos()
        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()
        MostrarcboOculto()

    End Sub
    Public Sub MostrarDatos()
        'Metodo para llenar grid master
        Conexion.Consulta("select * from tbl_frm_presupuesto_gva", "tbl_frm_presupuesto_gva")
        dgvDatos.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")

        'Cambia nombre a columnas de grid
        dgvDatos.Columns(0).HeaderText = "ID"
        dgvDatos.Columns(1).HeaderText = "Nombre presupuesto"
        dgvDatos.Columns(2).HeaderText = "Fecha creación"
        dgvDatos.Columns(3).HeaderText = "Subtotal venta"
        dgvDatos.Columns(4).HeaderText = "Subtotal admin"
        dgvDatos.Columns(5).HeaderText = "Total"
        dgvDatos.Columns(6).HeaderText = "Empresa"
        dgvDatos.Columns(6).HeaderText = "Usuario"
        dgvDatos.Columns(7).HeaderText = "Empresa"
        dgvDatos.Columns(8).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosEmpresa()
        'llena combo con nombre de empresa e inserta id
        Conexion.Conectado()
        Conexion.Consulta("Select  id_empresa2, emp_nombre_empresa2 from tbl_frm_empresa2", "tbl_frm_empresa2")
        cboEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cboEmpresa.DisplayMember = "emp_nombre_empresa2"
        cboEmpresa.ValueMember = "id_empresa2"
    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("Select id_usuario, usr_usuario from tbl_frm_usuario", "tbl_frm_usuario")
        cboUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cboUsuario.DisplayMember = "usr_usuario"
        cboUsuario.ValueMember = "id_usuario"
    End Sub
    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("Select id_moneda2, mnd_moneda2 from tbl_frm_moneda2", "tbl_frm_moneda2")
        cboMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cboMoneda.DisplayMember = "mnd_moneda2"
        cboMoneda.ValueMember = "id_moneda2"
    End Sub
    Public Sub MostrarcboOculto()
        Conexion.Conectado()
        Conexion.Consulta("select id_presupuesto_gva from tbl_frm_presupuesto_gva order by id_presupuesto_gva desc ", "tbl_frm_presupuesto_gva")
        cboOculto.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")
        cboOculto.DisplayMember = "id_presupuesto_gva"
        txtOculto.Text = cboOculto.Text
    End Sub
    Public Sub MostrarDatosCbogrid()
        'llena combo dentro de grid con id de presupuesto
        Conexion.Conectado()
        Conexion.Consulta("Select  id_presupuesto_gva, gva_nombre from tbl_frm_presupuesto_gva", "tbl_frm_presupuesto_gva")
        cboDgv.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")
        cboDgv.DisplayMember = "gva_nombre"
        cboDgv.ValueMember = "id_presupuesto_gva"
    End Sub
    Public Sub MostrarDatosCbogrid2()
        Conexion.Conectado()
        Conexion.Consulta("Select  id_presupuesto_gva, gva_nombre from tbl_frm_presupuesto_gva", "tbl_frm_presupuesto_gva")
        cboDgv2.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")
        cboDgv2.DisplayMember = "gva_nombre"
        cboDgv2.ValueMember = "id_presupuesto_gva"
    End Sub

    Public Sub sumarVentas()
        'suma datos ingresados en grid
        Dim totalV As Double = 0
        Dim filaV As DataGridViewRow = New DataGridViewRow()

        For Each filaV In dgVenta.Rows
            totalV += Convert.ToDouble(filaV.Cells("Column4").Value)
        Next
        txtTotalVentas.Text = Convert.ToString(totalV)

    End Sub
    Public Sub sumarAdmon()
        Dim totalA As Double = 0
        Dim filaA As DataGridViewRow = New DataGridViewRow()

        For Each filaA In dgAdmon.Rows
            totalA += Convert.ToDouble(filaA.Cells("Column4Admon").Value)
        Next
        txtTotalAdmon.Text = Convert.ToString(totalA)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Inicia grid ventas
        Dim con As SqlConnection = Conexion.con
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO tbl_frm_gastosventa VALUES(@id_presupuesto_gva, @gav_nombre,@gav_valor)", con)
        Conexion.Conectado()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In dgVenta.Rows
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@id_presupuesto_gva", Convert.ToString(fila.Cells("cboDgv").Value))
                agregar.Parameters.AddWithValue("@gav_nombre", Convert.ToString(fila.Cells("Column3").Value))
                agregar.Parameters.AddWithValue("@gav_valor", Convert.ToString(fila.Cells("Column4").Value))
                agregar.ExecuteNonQuery()
            Next

        Catch ex As Exception

            MostrarDatos()
            dgVenta.Rows.Clear()
        Finally
            con.Close()
        End Try

        'Inicia grid admon
        Dim con2 As SqlConnection = Conexion.con
        Dim agregar2 As SqlCommand = New SqlCommand("INSERT INTO tbl_frm_gastosadmin VALUES(@id_presupuesto_gva, @gaa_nombre,@gaa_valor)", con2)
        Conexion.Conectado()
        Dim fila2 As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila2 In dgAdmon.Rows
                agregar2.Parameters.Clear()
                agregar2.Parameters.AddWithValue("@id_presupuesto_gva", Convert.ToString(fila2.Cells("cboDgv2").Value))
                agregar2.Parameters.AddWithValue("@gaa_nombre", Convert.ToString(fila2.Cells("Column3Admon").Value))
                agregar2.Parameters.AddWithValue("@gaa_valor", Convert.ToString(fila2.Cells("Column4Admon").Value))
                agregar2.ExecuteNonQuery()
            Next

        Catch ex As Exception

            MostrarDatos()
            dgAdmon.Rows.Clear()
        Finally
            con2.Close()
        End Try

        'inicia modificar maestro

        Dim modificar As String = "gva_subventa= '" + txtTotalVentas.Text + "', gva_subadmin= '" + txtTotalAdmon.Text + "', gva_grantotal= '" + txtGranTotal.Text + "'"
        If txtId.Text <> "" Then
            If (Conexion.Modificar("tbl_frm_presupuesto_gva", modificar, "id_presupuesto_gva=" + txtId.Text)) Then
                MessageBox.Show("Datos guardados correctamente")
                limpiar()
                MostrarDatos()
            Else
                MessageBox.Show("Error al guardar")
            End If
        Else
            MsgBox("Seleccione presupuesto", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_presupuesto_gva", "id_presupuesto_gva= " + txtId.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            MostrarDatos()
            limpiar()
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        'muestra valores del grid en textbox
        Dim dgv As DataGridViewRow = dgvDatos.Rows(e.RowIndex)
        txtId.Text = dgv.Cells(0).Value.ToString()
        txtNombre.Text = dgv.Cells(1).Value.ToString()
        dtpPeriodo.Text = dgv.Cells(2).Value.ToString()
        cboEmpresa.Text = dgv.Cells(6).Value.ToString()
        cboUsuario.Text = dgv.Cells(7).Value.ToString()
        cboMoneda.Text = dgv.Cells(8).Value.ToString()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnTransferencia_Click(sender As Object, e As EventArgs) Handles btnTransferencia.Click
        'llama dll_transferencia
        Me.Close()
        Dim transferencia As New dll_transferencias.transferencia
        transferencia.Show()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtNombre.Clear()
        txtTotalVentas.Clear()
        txtTotalAdmon.Clear()
        txtGranTotal.Clear()
        dgVenta.Rows.Clear()
        dgAdmon.Rows.Clear()
    End Sub

    Private Sub dgVenta_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgVenta.CellEndEdit
        sumarVentas()
        txtGranTotal.Text = Val(txtTotalVentas.Text) + Val(txtTotalAdmon.Text)
    End Sub

    Private Sub dgAdmon_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdmon.CellEndEdit
        sumarAdmon()
        txtGranTotal.Text = Val(txtTotalVentas.Text) + Val(txtTotalAdmon.Text)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New popUp
        reporte.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim guardar As String = "insert into tbl_frm_presupuesto_gva values ('" + txtNombre.Text + "', '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtTotalVentas.Text + "', '" + txtTotalAdmon.Text + "',  '" + txtGranTotal.Text + "',  '" + cboEmpresa.SelectedValue.ToString + "',  '" + cboUsuario.SelectedValue.ToString + "', '" + cboMoneda.SelectedValue.ToString + "' )"
        Try
            If txtNombre.Text <> "" Then

                If (Conexion.Insertar(guardar)) Then
                    MessageBox.Show("Correcto", "FRM", MessageBoxButtons.OK)
                    tcPresupuesto.Visible = True
                    lblVenta.Visible = True
                    lblAdmon.Visible = True
                    lblGva.Visible = True
                    txtTotalVentas.Visible = True
                    txtTotalAdmon.Visible = True
                    txtGranTotal.Visible = True

                    limpiar()
                    MostrarDatos()
                Else
                    MsgBox("Error al generar detalle")
                End If

            Else
                MsgBox("Datos incompletos", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
        Finally
            Conexion.Desconectado()
        End Try

        MostrarcboOculto()
        MostrarDatosCbogrid()
        MostrarDatosCbogrid2()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

End Class