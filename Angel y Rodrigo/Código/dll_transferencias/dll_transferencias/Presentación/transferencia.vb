'*****************************************************************************************
'NOMBRE: DLL_TRANSFERENCIAS
'FECHA: 10/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: TRANSFERENCIAS PRESUPUESTARIAS
'DETALLE: REALIZA TRANSFERENCIAS ENTRE PRESUPUESTOS
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports dllConexion
Imports System.Windows.Forms


Public Class transferencia
    Private Sub transferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conexión a base de datos y carga de registros en grid
        Conexion.Conectado()
        MostrarDatosPV()
        MostrarDatosMD()
        MostrarDatosMod()
        MostrarDatosGI()
        MostrarDatosCV()
        MostrarDatosGVA()
        MostrarDatosUsuario()
    End Sub
    Public Sub MostrarDatosPV()
        Conexion.Consulta("select * from tbl_frm_presupuesto_ventas2", "tbl_frm_presupuesto_ventas2")
        dgVentas.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ventas2")

        'Cambia nombre de columnas en grid
        dgVentas.Columns(0).HeaderText = "ID"
        dgVentas.Columns(1).HeaderText = "Nombre presupuesto"
        dgVentas.Columns(2).HeaderText = "Fecha"
        dgVentas.Columns(3).HeaderText = "Volumen"
        dgVentas.Columns(4).HeaderText = "Total"
        dgVentas.Columns(5).HeaderText = "Empresa"
        dgVentas.Columns(6).HeaderText = "Usuario"
        dgVentas.Columns(7).HeaderText = "Moneda"

    End Sub

    Public Sub MostrarDatosMD()
        Conexion.Consulta("select * from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        dgMateriales.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")

        'Cambia nombre de columnas en grid
        dgMateriales.Columns(0).HeaderText = "ID"
        dgMateriales.Columns(1).HeaderText = "Nombre presupuesto"
        dgMateriales.Columns(2).HeaderText = "Fecha"
        dgMateriales.Columns(3).HeaderText = "Total"
        dgMateriales.Columns(4).HeaderText = "Empresa"
        dgMateriales.Columns(5).HeaderText = "Usuario"
        dgMateriales.Columns(6).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosMod()
        Conexion.Consulta("select * from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        dgMod.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")

        'Cambia nombre de columnas en grid
        dgMod.Columns(0).HeaderText = "ID"
        dgMod.Columns(1).HeaderText = "Nombre presupuesto"
        dgMod.Columns(2).HeaderText = "Fecha"
        dgMod.Columns(3).HeaderText = "Total"
        dgMod.Columns(4).HeaderText = "Empresa"
        dgMod.Columns(5).HeaderText = "Usuario"
        dgMod.Columns(6).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosGI()
        Conexion.Consulta("select * from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        dgGastos.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ici")

        'Cambia nombre de columnas en grid
        dgGastos.Columns(0).HeaderText = "ID"
        dgGastos.Columns(1).HeaderText = "Nombre presupuesto"
        dgGastos.Columns(2).HeaderText = "Fecha"
        dgGastos.Columns(3).HeaderText = "Empresa"
        dgGastos.Columns(4).HeaderText = "Total"
        dgGastos.Columns(5).HeaderText = "Usuario"
        dgGastos.Columns(6).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosCV()
        Conexion.Consulta("select * from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        dgCostoVentas.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")

        'Cambia nombre de columnas en grid
        dgCostoVentas.Columns(0).HeaderText = "ID"
        dgCostoVentas.Columns(1).HeaderText = "Nombre presupuesto"
        dgCostoVentas.Columns(2).HeaderText = "Fecha"
        dgCostoVentas.Columns(3).HeaderText = "Total"
        dgCostoVentas.Columns(4).HeaderText = "Empresa"
        dgCostoVentas.Columns(5).HeaderText = "Usuario"
        dgCostoVentas.Columns(6).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosGVA()
        Conexion.Consulta("select * from tbl_frm_presupuesto_gva", "tbl_frm_presupuesto_gva")
        dgGva.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")

        'Cambia nombre de columnas en grid
        dgGva.Columns(0).HeaderText = "ID"
        dgGva.Columns(1).HeaderText = "Nombre presupuesto"
        dgGva.Columns(2).HeaderText = "Fecha"
        dgGva.Columns(3).HeaderText = "Subtotal venta"
        dgGva.Columns(4).HeaderText = "Subtotal admin"
        dgGva.Columns(5).HeaderText = "Total"
        dgGva.Columns(6).HeaderText = "Empresa"
        dgGva.Columns(7).HeaderText = "Usuario"
        dgGva.Columns(8).HeaderText = "Moneda"

    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("Select id_usuario, usr_usuario from tbl_frm_usuario", "tbl_frm_usuario")
        cboUsrMod.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cboUsrMod.DisplayMember = "usr_usuario"
        cboUsrMod.ValueMember = "id_usuario"
    End Sub

    Private Sub dgCostoVentas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCostoVentas.CellContentDoubleClick
        'Muestra registros seleccionados de grid en un textbox
        Dim dgv6 As DataGridViewRow = dgCostoVentas.Rows(e.RowIndex)
        'condición para escoger en que textbox ingresar los datos seleccionados
        If txtId.Text = "" Then
                txtId.Text = dgv6.Cells(0).Value.ToString()
                txtNombre.Text = dgv6.Cells(1).Value.ToString()
                txtPeriodo.Text = dgv6.Cells(2).Value.ToString()
                txtTotal.Text = dgv6.Cells(3).Value.ToString()
                txtEmpresa.Text = dgv6.Cells(4).Value.ToString()
                txtUsuario.Text = dgv6.Cells(5).Value.ToString()
                txtMoneda.Text = dgv6.Cells(6).Value.ToString()
                txtTabla.Text = "tbl_frm_presupuesto_cv"
            End If
        If txtId2.Text = "" Then
            txtId2.Text = dgv6.Cells(0).Value.ToString()
            txtNombre2.Text = dgv6.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv6.Cells(2).Value.ToString()
            txtTotal2.Text = dgv6.Cells(3).Value.ToString()
            txtEmpresa2.Text = dgv6.Cells(4).Value.ToString()
            txtUsuario2.Text = dgv6.Cells(5).Value.ToString()
            txtMoneda2.Text = dgv6.Cells(6).Value.ToString()
            txtTabla2.Text = "tbl_frm_presupuesto_cv"
        End If
        'Condición para solo selecionar 2 presupuestos
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dgVentas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellContentDoubleClick
        Dim dgv As DataGridViewRow = dgVentas.Rows(e.RowIndex)
        If txtId.Text = "" Then
            txtId.Text = dgv.Cells(0).Value.ToString()
            txtNombre.Text = dgv.Cells(1).Value.ToString()
            txtPeriodo.Text = dgv.Cells(2).Value.ToString()
            txtTotal.Text = dgv.Cells(4).Value.ToString()
            txtEmpresa.Text = dgv.Cells(5).Value.ToString()
            txtUsuario.Text = dgv.Cells(6).Value.ToString()
            txtMoneda.Text = dgv.Cells(7).Value.ToString()
            txtTabla.Text = "tbl_frm_presupuesto_ventas2"

        End If
        If txtId2.Text = "" And dgv.Cells(1).Value.ToString() <> txtNombre.Text Then
            txtId2.Text = dgv.Cells(0).Value.ToString()
            txtNombre2.Text = dgv.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv.Cells(2).Value.ToString()
            txtTotal2.Text = dgv.Cells(4).Value.ToString()
            txtEmpresa2.Text = dgv.Cells(5).Value.ToString()
            txtUsuario2.Text = dgv.Cells(6).Value.ToString()
            txtMoneda2.Text = dgv.Cells(7).Value.ToString()
            txtTabla2.Text = "tbl_frm_presupuesto_ventas2"
        End If
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub dgGva_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGva.CellContentDoubleClick
        Dim dgv7 As DataGridViewRow = dgGva.Rows(e.RowIndex)
        If txtId.Text = "" Then
            txtId.Text = dgv7.Cells(0).Value.ToString()
            txtNombre.Text = dgv7.Cells(1).Value.ToString()
            txtPeriodo.Text = dgv7.Cells(2).Value.ToString()
            txtTotal.Text = dgv7.Cells(5).Value.ToString()
            txtEmpresa.Text = dgv7.Cells(6).Value.ToString()
            txtUsuario.Text = dgv7.Cells(7).Value.ToString()
            txtMoneda.Text = dgv7.Cells(8).Value.ToString()
            txtTabla.Text = "tbl_frm_presupuesto_gva"

        End If
        If txtId2.Text = "" And dgv7.Cells(1).Value.ToString() <> txtNombre.Text Then
            txtId2.Text = dgv7.Cells(0).Value.ToString()
            txtNombre2.Text = dgv7.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv7.Cells(2).Value.ToString()
            txtTotal2.Text = dgv7.Cells(5).Value.ToString()
            txtEmpresa2.Text = dgv7.Cells(6).Value.ToString()
            txtUsuario2.Text = dgv7.Cells(7).Value.ToString()
            txtMoneda2.Text = dgv7.Cells(8).Value.ToString()
            txtTabla2.Text = "tbl_frm_presupuesto_gva"

        End If
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub Calcular()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub dgGastos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGastos.CellContentDoubleClick
        Dim dgv5 As DataGridViewRow = dgGastos.Rows(e.RowIndex)
        If txtId.Text = "" Then
            txtId.Text = dgv5.Cells(0).Value.ToString()
            txtNombre.Text = dgv5.Cells(1).Value.ToString()
            txtPeriodo.Text = dgv5.Cells(2).Value.ToString()
            txtTotal.Text = dgv5.Cells(4).Value.ToString()
            txtEmpresa.Text = dgv5.Cells(3).Value.ToString()
            txtUsuario.Text = dgv5.Cells(5).Value.ToString()
            txtMoneda.Text = dgv5.Cells(6).Value.ToString()
            txtTabla.Text = "tbl_frm_presupuesto_ici"

        End If
        If txtId2.Text = "" And dgv5.Cells(1).Value.ToString() <> txtNombre.Text Then
            txtId2.Text = dgv5.Cells(0).Value.ToString()
            txtNombre2.Text = dgv5.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv5.Cells(2).Value.ToString()
            txtTotal2.Text = dgv5.Cells(4).Value.ToString()
            txtEmpresa2.Text = dgv5.Cells(3).Value.ToString()
            txtUsuario2.Text = dgv5.Cells(5).Value.ToString()
            txtMoneda2.Text = dgv5.Cells(6).Value.ToString()
            txtTabla2.Text = "tbl_frm_presupuesto_ici"

        End If
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dgMod_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMod.CellContentDoubleClick
        Dim dgv4 As DataGridViewRow = dgMod.Rows(e.RowIndex)
        If txtId.Text = "" Then
            txtId.Text = dgv4.Cells(0).Value.ToString()
            txtNombre.Text = dgv4.Cells(1).Value.ToString()
            txtPeriodo.Text = dgv4.Cells(2).Value.ToString()
            txtTotal.Text = dgv4.Cells(3).Value.ToString()
            txtEmpresa.Text = dgv4.Cells(4).Value.ToString()
            txtUsuario.Text = dgv4.Cells(5).Value.ToString()
            txtMoneda.Text = dgv4.Cells(6).Value.ToString()
            txtTabla.Text = "tbl_frm_presupuesto_mod"

        End If
        If txtId2.Text = "" And dgv4.Cells(1).Value.ToString() <> txtNombre.Text Then
            txtId2.Text = dgv4.Cells(0).Value.ToString()
            txtNombre2.Text = dgv4.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv4.Cells(2).Value.ToString()
            txtTotal2.Text = dgv4.Cells(3).Value.ToString()
            txtEmpresa2.Text = dgv4.Cells(4).Value.ToString()
            txtUsuario2.Text = dgv4.Cells(5).Value.ToString()
            txtMoneda2.Text = dgv4.Cells(6).Value.ToString()
            txtTabla2.Text = "tbl_frm_presupuesto_mod"

        End If
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dgMateriales_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMateriales.CellContentDoubleClick
        Dim dgv3 As DataGridViewRow = dgMateriales.Rows(e.RowIndex)
        If txtId.Text = "" Then
            txtId.Text = dgv3.Cells(0).Value.ToString()
            txtNombre.Text = dgv3.Cells(1).Value.ToString()
            txtPeriodo.Text = dgv3.Cells(2).Value.ToString()
            txtTotal.Text = dgv3.Cells(3).Value.ToString()
            txtEmpresa.Text = dgv3.Cells(4).Value.ToString()
            txtUsuario.Text = dgv3.Cells(5).Value.ToString()
            txtMoneda.Text = dgv3.Cells(6).Value.ToString()
            txtTabla.Text = "tbl_frm_compras_matdirectos"

        End If
        If txtId2.Text = "" And dgv3.Cells(1).Value.ToString() <> txtNombre.Text Then
            txtId2.Text = dgv3.Cells(0).Value.ToString()
            txtNombre2.Text = dgv3.Cells(1).Value.ToString()
            txtPeriodo2.Text = dgv3.Cells(2).Value.ToString()
            txtTotal2.Text = dgv3.Cells(3).Value.ToString()
            txtEmpresa2.Text = dgv3.Cells(4).Value.ToString()
            txtUsuario2.Text = dgv3.Cells(5).Value.ToString()
            txtMoneda2.Text = dgv3.Cells(6).Value.ToString()
            txtTabla2.Text = "tbl_frm_compras_matdirectos"

        End If
        If txtId.Text And txtId2.Text <> "" Then
            MsgBox("Ya ha seleccionado dos presupuestos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Public Sub limpiar()
        txtId.Clear()
        txtId2.Clear()
        txtNombre.Clear()
        txtNombre2.Clear()
        txtPeriodo.Clear()
        txtPeriodo2.Clear()
        txtTotal.Clear()
        txtTotal2.Clear()
        txtUsuario.Clear()
        txtUsuario2.Clear()
        txtEmpresa.Clear()
        txtEmpresa2.Clear()
        txtMoneda.Clear()
        txtMoneda2.Clear()
        txtTotalNuevo.Clear()
        txtTotalNuevo2.Clear()
        txtTransferencia.Clear()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransferencia.Click
        'Condición para realizar la transacción cuando ya se han seleccionado dos presupuestos
        If Val(txtId.Text) And Val(txtId2.Text) <> 0 Then
            Dim opc As DialogResult = MsgBox("¿Desea realizar la transacción?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Alerta")
            If opc = DialogResult.Yes Then

                'presupuesto de ventas
                If txtTabla.Text = "tbl_frm_presupuesto_ventas2" Then
                    Dim modificar As String = "prv_total_producto2= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_presupuesto_ventas2=" + txtId.Text)) Then
                        MostrarDatosPV()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_presupuesto_ventas2" Then
                    Dim modificar As String = "prv_total_producto2= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_presupuesto_ventas2=" + txtId2.Text)) Then
                        MostrarDatosPV()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If

                'presupuesto materiales directos
                If txtTabla.Text = "tbl_frm_compras_matdirectos" Then
                    Dim modificar As String = "cmd_grantotal_matdirectos_compra= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_compras_matdirectos=" + txtId.Text)) Then
                        MostrarDatosMD()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_compras_matdirectos" Then
                    Dim modificar As String = "cmd_grantotal_matdirectos_compra= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_compras_matdirectos=" + txtId2.Text)) Then
                        MostrarDatosMD()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If

                'presupuesto MOD
                If txtTabla.Text = "tbl_frm_presupuesto_mod" Then
                    Dim modificar As String = "mod_grantotal_manoobradirecta= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_presupuesto_mod=" + txtId.Text)) Then
                        MostrarDatosMod()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_presupuesto_mod" Then
                    Dim modificar As String = "mod_grantotal_manoobradirecta= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_presupuesto_mod=" + txtId2.Text)) Then
                        MostrarDatosMod()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If

                'presupuesto gastos indirectos
                If txtTabla.Text = "tbl_frm_presupuesto_ici" Then
                    Dim modificar As String = "ici_grantotal= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_presupuesto_ici=" + txtId.Text)) Then
                        MostrarDatosGI()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_presupuesto_ici" Then
                    Dim modificar As String = "ici_grantotal= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_presupuesto_ici=" + txtId2.Text)) Then
                        MostrarDatosGI()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If

                'presupuesto costo de ventas
                If txtTabla.Text = "tbl_frm_presupuesto_cv" Then
                    Dim modificar As String = "pcv_grantotal= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_presupuesto_cv=" + txtId.Text)) Then
                        MostrarDatosCV()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_presupuesto_cv" Then
                    Dim modificar As String = "pcv_grantotal= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_presupuesto_cv=" + txtId2.Text)) Then
                        MostrarDatosCV()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If

                'presupuesto gva
                If txtTabla.Text = "tbl_frm_presupuesto_gva" Then
                    Dim modificar As String = "gva_grantotal= '" + txtTotalNuevo.Text + " '"
                    If (Conexion.Modificar(txtTabla.Text, modificar, "id_presupuesto_gva=" + txtId.Text)) Then
                        MostrarDatosGVA()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
                If txtTabla2.Text = "tbl_frm_presupuesto_gva" Then
                    Dim modificar As String = "gva_grantotal= '" + txtTotalNuevo2.Text + " '"
                    If (Conexion.Modificar(txtTabla2.Text, modificar, "id_presupuesto_gva=" + txtId2.Text)) Then
                        MostrarDatosGVA()
                    Else
                        MessageBox.Show("Falló modificación")
                    End If
                End If
            Else
            End If

            '---------------------------------------------------------------------------------------------------------
            'Condición para guardar solo si los presupuestos ya se seleccionaron
            If txtId.Text And txtId2.Text <> "" Then
                Dim guardar As String = "insert into tbl_frm_transacciones values ('" + txtId.Text + "', '" + txtNombre.Text + "', '" + txtId2.Text + "', '" + txtNombre2.Text + "', '" + txtTransferencia.Text + "', '" + dtpNuevoPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', '" + cboUsrMod.SelectedValue.ToString + "', '" + txtEmpresa.Text + "' )"
                If (Conexion.Insertar(guardar)) Then
                    limpiar()
                Else
                    MsgBox("Error al guardar")
                End If
            End If
        Else
            MessageBox.Show("No seleccionó presupuestos")
        End If
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Condición para no repetir presupuesto
        If Val(txtEmpresa.Text) = Val(txtEmpresa2.Text) Then

            Dim total, total2, transferencia As Single

            'inicia transacción
            total = Val(txtTotal.Text)
            total2 = Val(txtTotal2.Text)
            transferencia = Val(txtTransferencia.Text)

            'Condición para no transferir una cantidad mayor a la disponible
            If total <= transferencia Then
                MsgBox("Por favor, ingrese una cantidad menor", MsgBoxStyle.Critical, "Error")
                txtTransferencia.Clear()
            Else
                txtTotalNuevo.Text = total - transferencia
                txtTotalNuevo2.Text = total2 + transferencia
            End If
        Else
            MsgBox("Empresas diferentes", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim popup As New popUp
        popup.Show()
    End Sub
End Class