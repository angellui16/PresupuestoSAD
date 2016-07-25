Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms
'***************************************************************
'NOMBRE:Presupuesto de costo de mano de obra.
'FECHA: 6/07/2016
'CREADOR:RODRIGO MIRANDA	
'DESCRIPCIÓN	Costo de mano de obra
'DETALLE  Controla las horas requeridas para la producción creciente de productos a producir
'MODIFICACIÓN: 18/07/2016
'***************************************************************
Public Class frCostoManoObraDirecta
    Dim conexion As New dllConexion.Conexion
    Private Sub frCostoManoObraDirecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEmpresa()
        MostrarDatosMoneda()
        MostrarDatosUsuario()
        MostrarMaestro()
        MostrarDetalle()
        MostrarcbControl()
        MostrarDatosIdProd()
        MostrarDatosPProd()
    End Sub

    Public Sub MostrarMaestro()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        dgCManoObra.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")

        dgCManoObra.AutoResizeColumns()
        dgCManoObra.Columns(0).HeaderText = "ID"
        dgCManoObra.Columns(1).HeaderText = "NOMBRE PRESP."
        dgCManoObra.Columns(2).HeaderText = "FECHA"
        dgCManoObra.Columns(3).HeaderText = "TOTAL M. OBRA"
        dgCManoObra.Columns(4).HeaderText = "ID EMPRESA"
        dgCManoObra.Columns(5).HeaderText = "ID USUARIO"
        dgCManoObra.Columns(6).HeaderText = "ID MONEDA"
        Conexion.Desconectado()
    End Sub
    Public Sub MostrarDetalle()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_manoobra", "tbl_frm_manoobra")
        dgCDMO.DataSource = Conexion.ds.Tables("tbl_frm_manoobra")
        Conexion.Desconectado()
    End Sub
    Public Sub MostrarDatosEmpresa()
        'conexion.Conectar()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_empresa2,emp_nombre_empresa2 FROM tbl_frm_empresa2", "tbl_frm_empresa2")
        cbEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cbEmpresa.DisplayMember = "emp_nombre_empresa2"
        cbEmpresa.ValueMember = "id_empresa2"
        Conexion.Desconectado()
    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_usuario,usr_usuario FROM tbl_frm_usuario", "tbl_frm_usuario")
        cbUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cbUsuario.DisplayMember = "usr_usuario"
        cbUsuario.ValueMember = "id_usuario"
        Conexion.Desconectado()
    End Sub
    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_moneda2,mnd_moneda2 FROM tbl_frm_moneda2", "tbl_frm_moneda2")
        cbMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cbMoneda.DisplayMember = "mnd_moneda2"
        cbMoneda.ValueMember = "id_moneda2"
        Conexion.Desconectado()
    End Sub
    'Llenar id aplicación
    Public Sub MostrarcbControl()
        Conexion.Conectado()
        Conexion.Consulta("select id_presupuesto_mod from tbl_frm_presupuesto_mod order by id_presupuesto_mod desc ", "tbl_frm_presupuesto_mod")
        cbControl.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")
        cbControl.DisplayMember = "id_presupuesto_mod"
        tbControl.Text = cbControl.Text
        Conexion.Desconectado()
    End Sub

    Public Sub MostrarDatosIdProd()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_produccion2 FROM tbl_frm_produccion2", "tbl_frm_produccion2")
        cbId_produccion.DataSource = Conexion.ds.Tables("tbl_frm_produccion2")
        cbId_produccion.DisplayMember = "id_produccion2"
        cbId_produccion.ValueMember = "id_produccion2"
        Conexion.Desconectado()
    End Sub

    Public Sub MostrarDatosPProd()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_presupuesto_produccion2,prp_nombre2 FROM tbl_frm_presupuesto_produccion2", "tbl_frm_presupuesto_produccion2")
        cbId_PProduccion.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_produccion2")
        cbId_PProduccion.DisplayMember = "prp_nombre2"
        cbId_PProduccion.ValueMember = "id_presupuesto_produccion2"
        Conexion.Desconectado()
    End Sub

    Public Sub SColumnaDescrip()
        dgUltimo2.Rows.Add("SubTotal Horas")
        dgUltimo2.Rows.Add("Tarifa por Hora")
        dgUltimo2.Rows.Add("Total de costo de mano de obra directa")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        limpiar.LimpiarCampos(Me)
        dgUltimo.Rows.Clear()
        dgUltimo2.Rows.Clear()
        dgUltimo.Visible = False
        dgUltimo2.Visible = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
                MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else
                Dim limpiar As vcLimpiar = New vcLimpiar()
                If (Conexion.Eliminar("tbl_frm_presupuesto_mod", "id_presupuesto_mod= " + tbIdpresupuesto.Text)) Then
                    MessageBox.Show("Datos eliminados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    MostrarDatosIdProd()
                    MostrarDatosPProd()
                Else
                    MessageBox.Show("Error al eliminar")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea mano de obra")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "mod_nombre= '" + tbNombre.Text + "', mod_periodo= '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', mod_grantotal_manoobradirecta= '" + tbGTotal.Text + "',id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "',id_usuario= '" + cbUsuario.SelectedValue.ToString + "',id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_presupuesto_mod", modificar, "id_presupuesto_mod=" + tbIdpresupuesto.Text)) Then
                MessageBox.Show("Datos modificados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MostrarDatosIdProd()
                MostrarDatosPProd()
            Else
                MessageBox.Show("Error al modificar")
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim col1c1 As Double = dgUltimo2.Item(1, 1).Value
        Dim col1c2 As Double = dgUltimo2.Item(1, 2).Value

        Try
            'Inicia
            Conexion.Conectado()
            Dim guardar As String = "INSERT INTO tbl_frm_materiales VALUES ('" + tbControl.Text + "', '" + tbNombre.Text + "',1,'" + col1c1.ToString + "', '" + col1c2.ToString + "', '" + tbGTotal.Text + "', '" + cbId_produccion.SelectedValue.ToString + "', '" + cbId_PProduccion.SelectedValue.ToString + "' )"
            If (Conexion.Insertar(guardar)) Then
                MessageBox.Show("Datos ingresados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MessageBox.Show("Error al guardar, verifique sus datos", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Conexion.Desconectado()

            Conexion.Conectado()
            Dim modificar As String = "mod_nombre= '" + tbNombre.Text + "', mod_periodo= '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', mod_grantotal_manoobradirecta= '" + tbGTotal.Text + "', id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "', id_usuario= '" + cbUsuario.SelectedValue.ToString + "', id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_presupuesto_mod", modificar, "id_presupuesto_mod=" + cbControl.Text)) Then
                'MessageBox.Show("Datos guardados correctamente")
            Else

            End If
            Conexion.con.Close()


        Catch ex As Exception
            MsgBox("Error al guardar")

        End Try
        MostrarMaestro()
        MostrarDetalle()
        tbIdpresupuesto.Clear()
        tbNombre.Clear()
        tbGTotal.Clear()
        dgUltimo.Rows.Clear()
        dgUltimo2.Rows.Clear()
        dgUltimo.Visible = False
        dgUltimo2.Visible = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnGuardarMaestro_Click(sender As Object, e As EventArgs) Handles btnGuardarMaestro.Click

        Try
            If String.IsNullOrEmpty(tbNombre.Text) Then
                MessageBox.Show("Debe llenar todos los datos")
            Else
                'Master
                Dim guardar As String = "INSERT INTO tbl_frm_presupuesto_mod VALUES ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', '" + tbGTotal.Text + "', '" + cbEmpresa.SelectedValue.ToString + "', '" + cbUsuario.SelectedValue.ToString + "', '" + cbMoneda.SelectedValue.ToString + "' )"
                ''aqui empieza grid
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
                    btnCrear.Enabled = True
                    dgUltimo.Visible = True
                    dgUltimo2.Visible = True
                    btnGuardar.Enabled = True
                Else
                    'MsgBox("Error al guardar")
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    'CREA DINAMICAMENTE LOS PRODUCTOS
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim fila, i As Byte
        fila = Val(txtFilas.Text)
        'columna = Val(txtColumna.Text)
        dgUltimo.RowCount = fila
    End Sub
    'SUMA DATAGRID NUMERO 1, SUMA SUS TRES COLUMNAS Y LAS TOTALIZA
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
        SumarTotal()
    End Sub

    Public Sub SumarTotal()
        'Columna 1 celdas

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
        total1 = col1c0 * col1c1
        total2 = col2c0 * col2c1
        total3 = col3c0 * col3c1
        'Total COSTO DE MANO DE OBRA-----------------------------------------------------------
        dgUltimo2.Item(1, 2).Value = total1
        dgUltimo2.Item(2, 2).Value = total2
        dgUltimo2.Item(3, 2).Value = total3

        Dim col1c2 As Double = dgUltimo2.Item(1, 2).Value
        Dim col2c2 As Double = dgUltimo2.Item(2, 2).Value
        Dim col3c2 As Double = dgUltimo2.Item(3, 2).Value

        Dim Gtotal As Double
        Gtotal = col1c2 + col2c2 + col3c2

        tbGTotal.Text = Gtotal
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New frPopupMO
        reporte.Show()
    End Sub
End Class