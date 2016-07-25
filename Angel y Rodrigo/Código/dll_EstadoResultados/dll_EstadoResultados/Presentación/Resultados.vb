'*****************************************************************************************
'NOMBRE: DLL_ESTADORESULTADOS
'FECHA: 04/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: ESTADO DE RESULTADOS PRESUPUESTADOS
'DETALLE: REALIZA PROYECCIONES EN BASE A LOS PRESUPUESTOS CREADOS
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports dllConexion
Imports System.Windows.Forms
Public Class Resultados
    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatosPV()
        MostrarDatosCV()
        MostrarDatosGVA()
        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()

    End Sub
    Public Sub MostrarDatosPV()
        'Carga presupuestos de venta 
        Conexion.Consulta("select id_presupuesto_ventas2, prv_nombre_presupuesto2, prv_total_producto2 from tbl_frm_presupuesto_ventas2", "tbl_frm_presupuesto_ventas2")
        dgVentas.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ventas2")

        'Cambia nombre de columna en grid
        dgVentas.Columns(0).HeaderText = "ID"
        dgVentas.Columns(1).HeaderText = "Nombre presupuesto"
        dgVentas.Columns(2).HeaderText = "Total"

    End Sub

    Public Sub MostrarDatosCV()
        'Carga presupuestos de costo de ventas
        Conexion.Consulta("select id_presupuesto_cv, pcv_nombre, pcv_grantotal from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        dgCosto.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")

        'Cambia nombre de columna en grid
        dgCosto.Columns(0).HeaderText = "ID"
        dgCosto.Columns(1).HeaderText = "Nombre presupuesto"
        dgCosto.Columns(2).HeaderText = "Total"

    End Sub
    Public Sub MostrarDatosGVA()
        'Carga presupuestos de ventas y admón
        Conexion.Consulta("select id_presupuesto_gva, gva_nombre, gva_grantotal from tbl_frm_presupuesto_gva", "tbl_frm_presupuesto_gva")
        dgAdmon.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_gva")

        'Cambia nombre de columna en grid
        dgAdmon.Columns(0).HeaderText = "ID"
        dgAdmon.Columns(1).HeaderText = "Nombre presupuesto"
        dgAdmon.Columns(2).HeaderText = "Total"

    End Sub
    Public Sub MostrarDatosEmpresa()
        'Muestra combo con datos de empresa y guarda id
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

    Private Sub dgVentas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellContentDoubleClick
        'Muestra celda seleccionada en textbox
        Dim dgv As DataGridViewRow = dgVentas.Rows(e.RowIndex)

        txtIdV.Text = dgv.Cells(0).Value.ToString()
        txtVentas.Text = dgv.Cells(2).Value.ToString()
    End Sub

    Private Sub dgCosto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCosto.CellContentDoubleClick
        Dim dgv6 As DataGridViewRow = dgCosto.Rows(e.RowIndex)

        txtIdCV.Text = dgv6.Cells(0).Value.ToString()
        txtCV.Text = dgv6.Cells(2).Value.ToString()
    End Sub

    Private Sub dgAdmon_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdmon.CellContentDoubleClick
        Dim dgv7 As DataGridViewRow = dgAdmon.Rows(e.RowIndex)

        txtIdAdmon.Text = dgv7.Cells(0).Value.ToString()
        txtAdmon.Text = dgv7.Cells(2).Value.ToString()
    End Sub
    Public Sub Calcular()
        'metodo para calcular utilidad neta
        Dim ventas, costoventas, admon, ingresosi, gastos, isr As Single

        ventas = Val(txtVentas.Text)
        costoventas = Val(txtCV.Text)
        admon = Val(txtAdmon.Text)
        ingresosi = Val(txtIngresosI.Text)
        gastos = Val(txtGastos.Text)
        isr = Val(txtISR.Text)

        txtBruta.Text = ventas - costoventas
        txtOperacion.Text = Val(txtBruta.Text) - admon
        txtIngresos.Text = ingresosi - gastos
        txtAisr.Text = Val(txtOperacion.Text) + Val(txtIngresos.Text)
        txtNeta.Text = Val(txtAisr.Text) - isr
    End Sub
    Private Sub txtVentas_TextChanged(sender As Object, e As EventArgs) Handles txtVentas.TextChanged
        Calcular()
    End Sub

    Private Sub txtCV_TextChanged(sender As Object, e As EventArgs) Handles txtCV.TextChanged
        Calcular()
    End Sub

    Private Sub txtAdmon_TextChanged(sender As Object, e As EventArgs) Handles txtAdmon.TextChanged
        Calcular()
    End Sub

    Private Sub txtIngresosI_TextChanged(sender As Object, e As EventArgs) Handles txtIngresosI.TextChanged
        Calcular()
    End Sub

    Private Sub txtGastos_TextChanged(sender As Object, e As EventArgs) Handles txtGastos.TextChanged
        Calcular()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminar As New Eliminar
        Me.Hide()
        eliminar.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'valida que se ingrese un nombre para el presupuesto
        If txtNombre.Text <> "" Then

            'guarda los datos
            Dim guardar As String = "insert into tbl_frm_estadoresultados values ('" + txtIdV.Text + "', '" + txtIdCV.Text + "', '" + txtIdAdmon.Text + "',  '" + txtNombre.Text + "',  '" + dtpPeriodo.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtBruta.Text + "', '" + txtOperacion.Text + "', '" + txtIngresos.Text + "', '" + txtAisr.Text + "', '" + txtISR.Text + "', '" + txtNeta.Text + "', '" + cboEmpresa.SelectedValue.ToString + "', '" + cboUsuario.SelectedValue.ToString + "', '" + cboMoneda.SelectedValue.ToString + "' )"
            If (Conexion.Insertar(guardar)) Then
                MessageBox.Show("Datos guardados correctamente")
                limpiar()
            Else
                MsgBox("Error al guardar")
            End If
        Else
            MsgBox("Datos incompletos", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificar As New Modificar
        modificar.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub
    Public Sub limpiar()
        txtNombre.Clear()
        txtIdV.Clear()
        txtVentas.Clear()
        txtIdCV.Clear()
        txtCV.Clear()
        txtBruta.Clear()
        txtIdAdmon.Clear()
        txtAdmon.Clear()
        txtOperacion.Clear()
        txtIngresosI.Clear()
        txtGastos.Clear()
        txtIngresos.Clear()
        txtAisr.Clear()
        txtIdISR.Clear()
        txtISR.Clear()
        txtNeta.Clear()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New PopUp
        reporte.Show()
    End Sub

    Private Sub txtISR_TextChanged(sender As Object, e As EventArgs) Handles txtISR.TextChanged
        Calcular()
    End Sub
End Class