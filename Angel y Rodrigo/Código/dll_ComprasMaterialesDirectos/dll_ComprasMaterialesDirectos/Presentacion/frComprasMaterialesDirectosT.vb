Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms

Public Class frComprasMaterialesDirectosT
    'Dim conexion As New dllConexion.Conexion
    Dim conexion As New dllConexion.Conexion
    '***************************************************************
    'Dim conexion2 As vcCN = New vcCN()
    'NOMBRE:Presupuesto de compra de materiales directos.
    'FECHA: 6/07/2016
    'CREADOR:RODRIGO MIRANDA	
    'DESCRIPCIÓN	
    'DETALLE
    'MODIFICACIÓN: 10/07/2016
    '***************************************************************


    Private Sub frComprasMaterialesDirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim llenar As vcDatos = New vcDatos()
        'llenar.sqlcombo(cbUnidad, "SELECT id_producto2, pro_nombre_producto2 FROM tbl_frm_producto2")
        MostrarDatos()
        MostrarDatos2()
        MostrarDatosEmpresa()
        MostrarDatosMoneda()
        MostrarDatosUsuario()

    End Sub

    Public Sub Calcular1()
        Dim val1, val2, val3, val4 As Integer
        Int32.TryParse(tbMD1_c1.Text, val1)
        Int32.TryParse(tbMD1_c2.Text, val2)
        Int32.TryParse(tbMD1_c3.Text, val3)
        Int32.TryParse(tbInvD1.Text, val4)
        tbTotal1.Text = Convert.ToString(val1 + val2 + val3 + val4)
    End Sub

    Public Sub Calcular2()
        Dim val1, val2, val3, val4 As Integer
        Int32.TryParse(tbMD2_c1.Text, val1)
        Int32.TryParse(tbMD2_c2.Text, val2)
        Int32.TryParse(tbMD2_c3.Text, val3)
        Int32.TryParse(tbInvD2.Text, val4)
        tbTotal2.Text = Convert.ToString(val1 + val2 + val3 + val4)
    End Sub
    Public Sub Calcular3()
        Dim val1, val2, val3, val4 As Integer
        Int32.TryParse(tbMD3_c1.Text, val1)
        Int32.TryParse(tbMD3_c2.Text, val2)
        Int32.TryParse(tbMD3_c3.Text, val3)
        Int32.TryParse(tbInvD3.Text, val4)
        tbTotal3.Text = Convert.ToString(val1 + val2 + val3 + val4)
    End Sub
    Public Sub Calcular4() 'Calcular el Total a comprar 
        Dim val1, val2, val3, val4, val5, val6 As Integer
        Int32.TryParse(tbTotal1.Text, val1)
        Int32.TryParse(tbInvE1.Text, val2)
        tbTotalC1.Text = Convert.ToString(val1 - val2)
        'Segunda Columna
        Int32.TryParse(tbTotal2.Text, val3)
        Int32.TryParse(tbInvE2.Text, val4)
        tbTotalC2.Text = Convert.ToString(val3 - val4)
        'Tercera Columna
        Int32.TryParse(tbTotal3.Text, val5)
        Int32.TryParse(tbInvE3.Text, val6)
        tbTotalC3.Text = Convert.ToString(val5 - val6) 'Total para comprarse
    End Sub
    Public Sub Calcular5() 'Calcular el Total material directo para comprarse
        Dim val1, val3, val5 As Integer
        Dim val2, val4, val6 As Decimal
        Int32.TryParse(tbTotalC1.Text, val1)
        Decimal.TryParse(tbPrecio1.Text, val2)
        tbTotalMC1.Text = Convert.ToString(val1 * val2)
        'Segunda Columna
        Int32.TryParse(tbTotalC2.Text, val3)
        Decimal.TryParse(tbPrecio2.Text, val4)
        tbTotalMC2.Text = Convert.ToString(val3 * val4)
        'Tercera Columna
        Int32.TryParse(tbTotalC3.Text, val5)
        Decimal.TryParse(tbPrecio3.Text, val6)
        tbTotalMC3.Text = Convert.ToString(val5 * val6)
    End Sub

    Public Sub Calcular6() 'Calcular el Gran Total 
        Dim val1, val2, val3 As Decimal
        Decimal.TryParse(tbTotalMC1.Text, val1)
        Decimal.TryParse(tbTotalMC2.Text, val2)
        Decimal.TryParse(tbTotalMC3.Text, val3)
        tbGranTotal.Text = Convert.ToString(val1 + val2 + val3)
        tbGTotal.Text = Convert.ToString(val1 + val2 + val3)

    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim val1, val2, val3 As Decimal
        Decimal.TryParse(tbTotalMC1.Text, val1)
        Decimal.TryParse(tbTotalMC2.Text, val2)
        Decimal.TryParse(tbTotalMC3.Text, val3)
        'Master
        Dim guardar As String = "INSERT INTO tbl_frm_compras_matdirectos VALUES ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + cbEmpresa.SelectedValue.ToString + "', '" + cbUsuario.SelectedValue.ToString + "', '" + cbMoneda.SelectedValue.ToString + "' )"
        'Dim guardar As String = "INSERT INTO tbl_frm_compras_matdirectos (cmd_nombre,cmd_periodo,cmd_grantotal_matdirectos_compra,id_empresa2,id_usuario,id_moneda2) values ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + tbEmpresa.Text + "', '" + tbUsuario.Text + "', '" + tbMoneda.Text + "' )"
        '1 Registro
        Dim guardardetalle As String = "INSERT INTO tbl_frm_materiales (id_compras_matdirectos,mat_nombre_matdirecto,mat_unidad_medida,mat_inventario_deseado,mat_total_deseado,mat_inventario_estimado,mat_total_estimado,mat_precio_unitario,mat_subtotal_matdirecto,mat_total_matdirectos_compra,id_produccion,id_presupuesto_produccion,id_producto,id_presupuesto_ventas) values ('" + tbIdpresupuesto.Text + "', '" + tbMD1.Text + "', '" + tbUMedida.Text + "', '" + tbInvD1.Text + "', '" + tbTotal1.Text + "', '" + tbInvE1.Text + "', '" + tbTotalC1.Text + "', '" + tbPrecio1.Text + "', '" + tbTotalMC1.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )"
        'Los 2 registros
        Dim guardardetalle2 As String = "INSERT INTO tbl_frm_materiales (id_compras_matdirectos,mat_nombre_matdirecto,mat_unidad_medida,mat_inventario_deseado,mat_total_deseado,mat_inventario_estimado,mat_total_estimado,mat_precio_unitario,mat_subtotal_matdirecto,mat_total_matdirectos_compra,id_produccion,id_presupuesto_produccion,id_producto,id_presupuesto_ventas) values" + "('" + tbIdpresupuesto.Text + "', '" + tbMD1.Text + "', '" + tbUMedida.Text + "', '" + tbInvD1.Text + "', '" + tbTotal1.Text + "', '" + tbInvE1.Text + "', '" + tbTotalC1.Text + "', '" + tbPrecio1.Text + "', '" + tbTotalMC1.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )" + ",('" + tbIdpresupuesto.Text + "', '" + tbMD2.Text + "', '" + tbUMedida.Text + "', '" + tbInvD2.Text + "', '" + tbTotal2.Text + "', '" + tbInvE2.Text + "', '" + tbTotalC2.Text + "', '" + tbPrecio2.Text + "', '" + tbTotalMC2.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )"
        'Los 3 registros
        Dim guardardetalle3 As String = "INSERT INTO tbl_frm_materiales (id_compras_matdirectos,mat_nombre_matdirecto,mat_unidad_medida,mat_inventario_deseado,mat_total_deseado,mat_inventario_estimado,mat_total_estimado,mat_precio_unitario,mat_subtotal_matdirecto,mat_total_matdirectos_compra,id_produccion,id_presupuesto_produccion,id_producto,id_presupuesto_ventas) values" + "('" + tbIdpresupuesto.Text + "', '" + tbMD1.Text + "', '" + tbUMedida.Text + "', '" + tbInvD1.Text + "', '" + tbTotal1.Text + "', '" + tbInvE1.Text + "', '" + tbTotalC1.Text + "', '" + tbPrecio1.Text + "', '" + tbTotalMC1.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )" + ",('" + tbIdpresupuesto.Text + "', '" + tbMD2.Text + "', '" + tbUMedida.Text + "', '" + tbInvD2.Text + "', '" + tbTotal2.Text + "', '" + tbInvE2.Text + "', '" + tbTotalC2.Text + "', '" + tbPrecio2.Text + "', '" + tbTotalMC2.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )" + ",('" + tbIdpresupuesto.Text + "', '" + tbMD3.Text + "', '" + tbUMedida.Text + "', '" + tbInvD3.Text + "', '" + tbTotal3.Text + "', '" + tbInvE3.Text + "', '" + tbTotalC3.Text + "', '" + tbPrecio3.Text + "', '" + tbTotalMC3.Text + "', '" + tbGranTotal.Text + "', '" + tbId_produccion.Text + "', '" + tbId_PProduccion.Text + "', '" + tbId_producto.Text + "', '" + tbId_PVentas.Text + "' )"

        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")

            ''Verificación de Subtotales --------------------------------------------------------------------------------------------------------
            'If (val1 > 0) And (val2 > 0) And (val3 > 0) Then 'Verfica que los 3 subtotales sean mayores que 0 y guardar 3 detalles
            '    If (conexion2.Insertar(guardardetalle3)) Then
            '        MessageBox.Show("Datos de los detalles fueron guardados correctamente")
            '    Else
            '        MsgBox("Error al guardar el detalle.")
            '    End If
            'ElseIf (val1 > 0) And (val2 > 0) Then 'Verfica que los 3 subtotales sean mayores que 0 y guardar 3 detalles
            '    If (conexion2.Insertar(guardardetalle2)) Then
            '        MessageBox.Show("Datos detalle guardados correctamente")
            '    Else
            '        MsgBox("Error al guardar el detalle.")
            '    End If
            'ElseIf (val1 > 0) Then 'Verifica que el primer subtotal sea mayor que 0 para guardar solo un detalle
            '    If (conexion2.Insertar(guardardetalle)) Then
            '        MessageBox.Show("Datos detalle guardados correctamente")
            '    Else
            '        MsgBox("Error al guardar el detalle.")
            '    End If
            'End If
            'Verificación de Subtotales --------------------------------------------------------------------------------------------------------
        Else
            MsgBox("Error al guardar el registro")
        End If
        MostrarDatos()
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
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
                MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else
                Dim limpiar As vcLimpiar = New vcLimpiar()
                If (Conexion.Eliminar("tbl_frm_compras_matdirectos", "id_compras_matdirectos= " + tbIdpresupuesto.Text)) Then
                    MessageBox.Show("Datos eliminados correctamente")
                    limpiar.LimpiarCampos(Me)
                Else
                    MessageBox.Show("Error al eliminar")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea cuentas indirectas")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "cmd_nombre= '" + tbNombre.Text + "', cmd_periodo= '" + dtpPeriodo.Value.Date + "', cmd_grantotal_matdirectos_compra= '" + tbGTotal.Text + "',id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "',id_usuario= '" + cbUsuario.SelectedValue.ToString + "',id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_compras_matdirectos", modificar, "id_compras_matdirectos=" + tbIdpresupuesto.Text)) Then
                MessageBox.Show("Datos modificados correctamente")
                limpiar.LimpiarCampos(Me)
            Else
                MessageBox.Show("Error al modificar")
            End If
        End If
    End Sub

    Private Sub tbMD1_c1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMD1_c1.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If

        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> ("."c)) Then
            e.Handled = True
        End If


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular1()
        Calcular2()
        Calcular3()
        Calcular4()
        Calcular5()
        Calcular6()
        btnGuardar.Enabled = True

    End Sub

    Private Sub tbMD2_c1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMD2_c1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub MostrarDatos()
        Conexion.Consulta("Select *from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        dgDatos.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")
    End Sub

    Public Sub MostrarDatos2()
        Conexion.Consulta("Select *from tbl_frm_materiales", "tbl_frm_materiales")
        dgDatos2.DataSource = Conexion.ds.Tables("tbl_frm_materiales")
    End Sub
    Public Sub MostrarDatosconteo()
        Conexion.Consulta("select Max(id_empresa2) from tbl_frm_empresa2", "id_empresa2")
        tbGranTotal.Text = Conexion.ds.Tables("id_empresa2").ToString
        'dgDatos2.DataSource = Conexion.ds.Tables("id_empresa2")
    End Sub
    Public Sub MostrarDatosEmpresa()
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

End Class