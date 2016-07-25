Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms
'***************************************************************
'NOMBRE:Presupuesto de compra de materiales directos.
'FECHA: 6/07/2016
'CREADOR:RODRIGO MIRANDA	
'DESCRIPCIÓN	Compras de materiales directos
'DETALLE  Controla el numero creciente de productos a producir
'MODIFICACIÓN: 18/07/2016
'***************************************************************

Public Class frCMaterialesDirectos
    Dim conexion As New dllConexion.Conexion

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Dim fila, i As Byte
        fila = Val(txtFilas.Text)
        'columna = Val(txtColumna.Text)
        dgUltimo.RowCount = fila

    End Sub

    Public Sub SColumnaDescrip()
        dgUltimo2.Rows.Add("SubTotal.")
        dgUltimo2.Rows.Add("Más Inventario deseado 31 Dic.")
        dgUltimo2.Rows.Add("Total")
        dgUltimo2.Rows.Add("Menos Inventario estimado 1 Enero")
        dgUltimo2.Rows.Add("Total para comprarse")
        dgUltimo2.Rows.Add("Precio Unitario")
        dgUltimo2.Rows.Add("Total de materiales directos para comprarse")
        'Bloquear celdas
        dgUltimo2.Item(1, 0).ReadOnly = True
        dgUltimo2.Item(2, 0).ReadOnly = True
        dgUltimo2.Item(3, 0).ReadOnly = True

        dgUltimo2.Item(1, 2).ReadOnly = True
        dgUltimo2.Item(2, 2).ReadOnly = True
        dgUltimo2.Item(3, 2).ReadOnly = True

        dgUltimo2.Item(1, 4).ReadOnly = True
        dgUltimo2.Item(2, 4).ReadOnly = True
        dgUltimo2.Item(3, 4).ReadOnly = True

        dgUltimo2.Item(1, 6).ReadOnly = True
        dgUltimo2.Item(2, 6).ReadOnly = True
        dgUltimo2.Item(3, 6).ReadOnly = True
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim col1c1 As Double = dgUltimo2.Item(1, 1).Value
        Dim col1c2 As Double = dgUltimo2.Item(1, 2).Value
        Dim col1c3 As Double = dgUltimo2.Item(1, 3).Value
        Dim col1c4 As Double = dgUltimo2.Item(1, 4).Value
        Dim col1c5 As Double = dgUltimo2.Item(1, 5).Value
        Dim col1c6 As Double = dgUltimo2.Item(1, 6).Value

        'Inicia
        Conexion.Conectado()
        Dim guardar As String = "INSERT INTO tbl_frm_materiales VALUES ('" + cbControl.Text + "', '" + tbNombre.Text + "', '" + col1c1.ToString + "', '" + col1c2.ToString + "', '" + col1c3.ToString + "', '" + col1c4.ToString + "', '" + col1c5.ToString + "', '" + col1c6.ToString + "', '" + tbGTotal.Text + "', '" + cbId_produccion.SelectedValue.ToString + "', '" + cbId_PProduccion.SelectedValue.ToString + "' )"

        Try
            If (Conexion.Insertar(guardar)) Then
                MessageBox.Show("Datos ingresados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'tbIdpresupuesto.Clear()
                'tbNombre.Clear()
                'tbGTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosMoneda()
                MostrarDatosUsuario()
                MostrarMaestro()
                MostrarDetalle()
                MostrarcbControl()
                MostrarDatosIdProd()
                MostrarDatosPProd()
                dgUltimo.Visible = True
                dgUltimo2.Visible = True
                btnGuardar.Enabled = True
            Else
                MsgBox("Error al guardar")
            End If
        Catch ex As Exception
        Finally
            Conexion.Desconectado()
        End Try


        'Inicia modificacion del gran total
        Conexion.Conectado()
            Dim modificar As String = "cmd_nombre= '" + tbNombre.Text + "', cmd_periodo= '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', cmd_grantotal_matdirectos_compra= '" + tbGTotal.Text + "', id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "', id_usuario= '" + cbUsuario.SelectedValue.ToString + "', id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_compras_matdirectos", modificar, "id_compras_matdirectos=" + cbControl.Text)) Then
                MessageBox.Show("Datos guardados correctamente")
            Else

            End If
            Conexion.con.Close()

            'Catch ex As Exception
            'MsgBox("Error al guardar")
            MostrarMaestro()
            MostrarDetalle()
            tbIdpresupuesto.Clear()
            tbNombre.Clear()
            tbGTotal.Clear()
            dgUltimo.Rows.Clear()
            dgUltimo2.Rows.Clear()
            dgUltimo.Visible = False
            dgUltimo2.Visible = False
            btnGuardar.Enabled = False   'End Try

    End Sub

    Private Sub frCMaterialesDirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEmpresa()
        MostrarDatosMoneda()
        MostrarDatosUsuario()
        MostrarMaestro()
        MostrarDetalle()
        MostrarcbControl()
        MostrarDatosIdProd()
        MostrarDatosPProd()
        'SColumnaDescrip()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Public Sub MostrarMaestro() 'Busqueda de maestro
        Conexion.Consulta("Select * from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        dgMD.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")

        dgMD.AutoResizeColumns()
        dgMD.Columns(0).HeaderText = "ID"
        dgMD.Columns(1).HeaderText = "NOMBRE PRESP."
        dgMD.Columns(2).HeaderText = "FECHA"
        dgMD.Columns(3).HeaderText = "TOTAL M.DIRECTOS"
        dgMD.Columns(4).HeaderText = "ID EMPRESA"
        dgMD.Columns(5).HeaderText = "ID USUARIO"
        dgMD.Columns(6).HeaderText = "ID MONEDA"

    End Sub
    Public Sub MostrarDetalle() 'Consulta para tabla detalle
        Conexion.Consulta("Select * from tbl_frm_materiales", "tbl_frm_materiales")
        dgDMD.DataSource = Conexion.ds.Tables("tbl_frm_materiales")

        dgDMD.AutoResizeColumns()
        dgDMD.Columns(0).HeaderText = "ID DETALLE"
        dgDMD.Columns(1).HeaderText = "ID PRESP."
        dgDMD.Columns(2).HeaderText = "NOMBRE P."
        dgDMD.Columns(3).HeaderText = "INV. DESEADO"
        dgDMD.Columns(4).HeaderText = "TOTAL1"
        dgDMD.Columns(5).HeaderText = "INV. ESTIMADO"
        dgDMD.Columns(6).HeaderText = "TOTAL2"
        dgDMD.Columns(7).HeaderText = "P. UNITARIO"
        dgDMD.Columns(8).HeaderText = "SUBTOTAL"
        dgDMD.Columns(9).HeaderText = "TOTAL MAT. DIRECTOS"
        dgDMD.Columns(10).HeaderText = "ID PROD."
        dgDMD.Columns(11).HeaderText = "ID P. PROD"

    End Sub
    Public Sub MostrarDatosEmpresa() 'Llenado cboEmpresa
        'conexion.Conectar()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_empresa2,emp_nombre_empresa2 FROM tbl_frm_empresa2", "tbl_frm_empresa2")
        cbEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cbEmpresa.DisplayMember = "emp_nombre_empresa2"
        cbEmpresa.ValueMember = "id_empresa2"
    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_usuario,usr_usuario FROM tbl_frm_usuario", "tbl_frm_usuario")
        cbUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cbUsuario.DisplayMember = "usr_usuario"
        cbUsuario.ValueMember = "id_usuario"
    End Sub
    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_moneda2,mnd_moneda2 FROM tbl_frm_moneda2", "tbl_frm_moneda2")
        cbMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cbMoneda.DisplayMember = "mnd_moneda2"
        cbMoneda.ValueMember = "id_moneda2"
    End Sub

    'Llenar id
    Public Sub MostrarcbControl()
        Conexion.Conectado()
        Conexion.Consulta("select id_compras_matdirectos from tbl_frm_compras_matdirectos order by id_compras_matdirectos desc ", "tbl_frm_compras_matdirectos")
        cbControl.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")
        cbControl.DisplayMember = "id_compras_matdirectos"
        tbControl.Text = cbControl.Text
    End Sub

    Public Sub MostrarDatosIdProd()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_produccion2 FROM tbl_frm_produccion2", "tbl_frm_produccion2")
        cbId_produccion.DataSource = Conexion.ds.Tables("tbl_frm_produccion2")
        cbId_produccion.DisplayMember = "id_produccion2"
        cbId_produccion.ValueMember = "id_produccion2"
    End Sub

    Public Sub MostrarDatosPProd()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_presupuesto_produccion2,prp_nombre2 FROM tbl_frm_presupuesto_produccion2", "tbl_frm_presupuesto_produccion2")
        cbId_PProduccion.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_produccion2")
        cbId_PProduccion.DisplayMember = "prp_nombre2"
        cbId_PProduccion.ValueMember = "id_presupuesto_produccion2"
    End Sub

    'Suma automatica entre el datagrid 1
    Private Sub dgUltimo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgUltimo.CellEndEdit
        If (dgUltimo.Columns(e.ColumnIndex).Name.Equals("MD1")) Then
            Dim subtotal As Double = 0

            For i As Integer = 0 To dgUltimo.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgUltimo.Rows(i).Cells(1).Value)
                subtotal = subtotal + convertirSubtotal
            Next
            'probar 
            dgUltimo2.Item(1, 0).Value = subtotal

        End If
        If (dgUltimo.Columns(e.ColumnIndex).Name.Equals("MD2")) Then
            Dim subtotal2 As Double = 0

            For ii As Integer = 0 To dgUltimo.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgUltimo.Rows(ii).Cells(2).Value)
                subtotal2 = subtotal2 + convertirSubtotal
            Next
            dgUltimo2.Item(2, 0).Value = subtotal2

        End If
        Dim total3 As Double = 0
        If (dgUltimo.Columns(e.ColumnIndex).Name.Equals("MD3")) Then
            Dim subtotal3 As Double = 0

            For ia As Integer = 0 To dgUltimo.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgUltimo.Rows(ia).Cells(3).Value)
                subtotal3 = subtotal3 + convertirSubtotal
                total3 = subtotal3

            Next
            dgUltimo2.Item(3, 0).Value = subtotal3
        End If

    End Sub


    Private Sub dgUltimo2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgUltimo2.CellEndEdit
        'Sumas detalle No.2
        SumarInvDeseado()
    End Sub

    'Modifica registro
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "cmd_nombre= '" + tbNombre.Text + "', cmd_periodo= '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', cmd_grantotal_matdirectos_compra= '" + tbGTotal.Text + "',id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "',id_usuario= '" + cbUsuario.SelectedValue.ToString + "',id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_compras_matdirectos", modificar, "id_compras_matdirectos=" + tbIdpresupuesto.Text)) Then
                MessageBox.Show("Datos modificados correctamente")
                'limpiar.LimpiarCampos(Me)
                tbIdpresupuesto.Clear()
                tbNombre.Clear()
                tbGTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosMoneda()
                MostrarDatosUsuario()
                MostrarMaestro()
                MostrarDetalle()
                MostrarDatosIdProd()
                MostrarDatosPProd()
                MostrarcbControl()
            Else
                MessageBox.Show("Error al modificar")
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
                MsgBox("Debe ingresar un ID de presupuesto valido", MsgBoxStyle.Critical, "Error - Sistema FRM")
                'MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else
                Dim limpiar As vcLimpiar = New vcLimpiar()
                If (Conexion.Eliminar("tbl_frm_compras_matdirectos", "id_compras_matdirectos= " + tbIdpresupuesto.Text)) Then
                    MessageBox.Show("Datos eliminados correctamente")
                    limpiar.LimpiarCampos(Me)
                    tbIdpresupuesto.Clear()
                    tbNombre.Clear()
                    tbGTotal.Clear()
                    MostrarDatosEmpresa()
                    MostrarDatosMoneda()
                    MostrarDatosUsuario()
                    MostrarMaestro()
                    MostrarDetalle()
                    MostrarcbControl()
                Else
                    MsgBox("Error al eliminar", MsgBoxStyle.Critical, "Error - Sistema FRM")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea cuentas indirectas")
        End Try
    End Sub

    Private Sub btnGuardarMaestro_Click(sender As Object, e As EventArgs) Handles btnGuardarMaestro.Click

        If String.IsNullOrEmpty(tbNombre.Text) Then
            MessageBox.Show("Debe llenar todos los datos")
            'MsgBox("Debe llenar todos los datos", MsgBoxStyle.Critical, "Error - Sistema FRM")

        Else
            'Master
            Dim guardar As String = "INSERT INTO tbl_frm_compras_matdirectos VALUES ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', '" + tbGTotal.Text + "', '" + cbEmpresa.SelectedValue.ToString + "', '" + cbUsuario.SelectedValue.ToString + "', '" + cbMoneda.SelectedValue.ToString + "' )"
            'Dim guardar As String = "INSERT INTO tbl_frm_compras_matdirectos VALUES ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date.ToString("dd-MM-yyyy") + "', '" + tbGTotal.Text + "', '" + cbEmpresa.SelectedValue.ToString + "', '" + cbUsuario.SelectedValue.ToString + "', '" + cbMoneda.SelectedValue.ToString + "' )"

            'aqui empieza grid
            Dim con As SqlConnection = Conexion.con

            ''aqui termina grid
            If (Conexion.Insertar(guardar)) Then
                'MessageBox.Show("Datos guardados correctamente")
                MostrarDatosEmpresa()
                MostrarDatosMoneda()
                MostrarDatosUsuario()
                MostrarMaestro()
                MostrarDetalle()
                MostrarcbControl()
                MostrarDatosIdProd()
                MostrarDatosPProd()
                SColumnaDescrip()
                dgUltimo.Visible = True
                dgUltimo2.Visible = True
                btnGuardar.Enabled = True
                btnCrear.Enabled = True

            Else
                'MsgBox("Error al guardar")
            End If


        End If
    End Sub

    Private Sub dgMD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMD.CellContentClick
        Dim dgv As DataGridViewRow = dgMD.Rows(e.RowIndex)
        tbIdpresupuesto.Text = dgv.Cells(0).Value.ToString()
        tbNombre.Text = dgv.Cells(1).Value.ToString()
        dtpPeriodo.Value = dgv.Cells(2).Value.ToString()
        tbGTotal.Text = dgv.Cells(3).Value.ToString()
        cbEmpresa.Text = dgv.Cells(4).Value.ToString()
        cbUsuario.Text = dgv.Cells(5).Value.ToString()
        cbMoneda.Text = dgv.Cells(6).Value.ToString()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        limpiar.LimpiarCampos(Me)
        tbIdpresupuesto.Clear()
        tbNombre.Clear()
        tbGTotal.Clear()
        dgUltimo.Rows.Clear()
        dgUltimo2.Rows.Clear()
        dgUltimo.Visible = False
        dgUltimo2.Visible = False
        btnGuardar.Enabled = False
    End Sub

    Public Sub SumarInvDeseado()
        Dim total1, total2, total3 As Double

        '(columna,fila)
        'Utilizar valores de cada celda 
        Dim col1c0 As Double = dgUltimo2.Item(1, 0).Value
        Dim col2c0 As Double = dgUltimo2.Item(2, 0).Value
        Dim col3c0 As Double = dgUltimo2.Item(3, 0).Value
        Dim col1c1 As Double = dgUltimo2.Item(1, 1).Value
        Dim col2c1 As Double = dgUltimo2.Item(2, 1).Value
        Dim col3c1 As Double = dgUltimo2.Item(3, 1).Value

        'total1 = col1c0 + txtTotal1.Text.ToString
        'txtRes.Text = total1

        'total2 = col2c0 + txtTotal2.Text.ToString
        'txtRes.Text = total1

        'total3 = col3c0 + txtTotal3.Text.ToString
        'txtRes.Text = total1
        'Totalizar subtotal fila 0-------------------------------------------------
        total1 = col1c0 + col1c1
        total2 = col2c0 + col2c1
        total3 = col3c0 + col3c1
        'Total 1 deseado-----------------------------------------------------------
        dgUltimo2.Item(1, 2).Value = total1
        dgUltimo2.Item(2, 2).Value = total2
        dgUltimo2.Item(3, 2).Value = total3

        'Totalizar 1 fila 2-------------------------------------------------
        'Fila total a comprarse
        Dim col1c2 As Double = dgUltimo2.Item(1, 2).Value
        Dim col2c2 As Double = dgUltimo2.Item(2, 2).Value
        Dim col3c2 As Double = dgUltimo2.Item(3, 2).Value
        Dim col1c3 As Double = dgUltimo2.Item(1, 3).Value
        Dim col2c3 As Double = dgUltimo2.Item(2, 3).Value
        Dim col3c3 As Double = dgUltimo2.Item(3, 3).Value

        Dim total4, total5, total6 As Double

        total4 = col1c2 - col1c3
        total5 = col2c2 - col2c3
        total6 = col3c2 - col3c3
        'Total a comprarse--------------------
        dgUltimo2.Item(1, 4).Value = total4
        dgUltimo2.Item(2, 4).Value = total5
        dgUltimo2.Item(3, 4).Value = total6

        'Total de materiales directos----------------------------------------------------------------
        Dim col1c4 As Double = dgUltimo2.Item(1, 4).Value
        Dim col2c4 As Double = dgUltimo2.Item(2, 4).Value
        Dim col3c4 As Double = dgUltimo2.Item(3, 4).Value
        Dim col1c5 As Double = dgUltimo2.Item(1, 5).Value
        Dim col2c5 As Double = dgUltimo2.Item(2, 5).Value
        Dim col3c5 As Double = dgUltimo2.Item(3, 5).Value

        Dim total7, total8, total9 As Double

        total7 = col1c4 * col1c5
        total8 = col2c4 * col2c5
        total9 = col3c4 * col3c5
        'Total a comprarse--------------------
        dgUltimo2.Item(1, 6).Value = total7
        dgUltimo2.Item(2, 6).Value = total8
        dgUltimo2.Item(3, 6).Value = total9

        Dim col1c6 As Double = dgUltimo2.Item(1, 6).Value
        Dim col2c6 As Double = dgUltimo2.Item(2, 6).Value
        Dim col3c6 As Double = dgUltimo2.Item(3, 6).Value

        Dim Gtotal As Double
        Gtotal = col1c6 + col2c6 + col3c6

        tbGTotal.Text = Gtotal
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New frPopupCMD
        reporte.Show()


    End Sub
End Class