Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms

Public Class frCostoManoObraDirectaT
    'NOMBRE:Presupuesto de compra de materiales directos.
    'FECHA: 6/07/2016
    'CREADOR:RODRIGO MIRANDA	
    'DESCRIPCIÓN	
    'DETALLE
    'MODIFICACIÓN: 10/07/2016
    Private Sub frCostoManoObraDirecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Calcular1()
        Dim val1, val2, val3 As Integer
        Int32.TryParse(tbMD1_c1.Text, val1)
        Int32.TryParse(tbMD1_c2.Text, val2)
        Int32.TryParse(tbMD1_c3.Text, val3)
        tbTotal1.Text = Convert.ToString(val1 + val2 + val3)
    End Sub

    Public Sub Calcular2() 'Columna 2
        Dim val1, val2, val3 As Integer
        Int32.TryParse(tbMD2_c1.Text, val1)
        Int32.TryParse(tbMD2_c2.Text, val2)
        Int32.TryParse(tbMD2_c3.Text, val3)
        tbTotal2.Text = Convert.ToString(val1 + val2 + val3)
    End Sub
    Public Sub Calcular3() 'Columna 3
        Dim val1, val2, val3 As Integer
        Int32.TryParse(tbMD3_c1.Text, val1)
        Int32.TryParse(tbMD3_c2.Text, val2)
        Int32.TryParse(tbMD3_c3.Text, val3)
        tbTotal3.Text = Convert.ToString(val1 + val2 + val3)
    End Sub

    Public Sub Calcular4() 'multiplicacion por la tarifa por hora
        Dim val1, val3, val5 As Integer
        Dim val2, val4, val6 As Decimal
        Int32.TryParse(tbTotal1.Text, val1)
        Decimal.TryParse(tbTH1.Text, val2)
        tbTotalC1.Text = Convert.ToString(val1 * val2)
        'Segunda Columna
        Int32.TryParse(tbTotal2.Text, val3)
        Decimal.TryParse(tbTH2.Text, val4)
        tbTotalC2.Text = Convert.ToString(val3 * val4)
        'Tercera Columna
        Int32.TryParse(tbTotal3.Text, val5)
        Decimal.TryParse(tbTH3.Text, val6)
        tbTotalC3.Text = Convert.ToString(val5 * val6)
    End Sub
    Public Sub Calcular5() 'Calcular el Gran Total 
        Dim val1, val2, val3 As Decimal
        Decimal.TryParse(tbTotalC1.Text, val1)
        Decimal.TryParse(tbTotalC2.Text, val2)
        Decimal.TryParse(tbTotalC3.Text, val3)
        tbGranTotal.Text = Convert.ToString(val1 + val2 + val3)
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        Dim guardar As String = "INSERT INTO tbl_frm_presupuesto_mod values ( '" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + tbEmpresa.Text + "', '" + tbUsuario.Text + "', '" + tbMoneda.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MsgBox("Error al guardar")
        End If
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
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If (Conexion.Eliminar("tbl_frm_presupuesto_mod", "id_presupuesto_mod= " + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        Dim modificar As String = "mod_nombre= '" + tbNombre.Text + "', mod_periodo= '" + dtpPeriodo.Value.Date + "', mod_grantotal_manoobradirecta= '" + tbGTotal.Text + "',id_empresa2= '" + tbEmpresa.Text + "',id_usuario= '" + tbUsuario.Text + "',id_moneda2= '" + tbMoneda.Text + "'"
        If (Conexion.Modificar("tbl_frm_presupuesto_mod", modificar, "id_presupuesto_mod=" + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular1()
        Calcular2()
        Calcular3()
        Calcular4()
        Calcular5()
    End Sub
End Class