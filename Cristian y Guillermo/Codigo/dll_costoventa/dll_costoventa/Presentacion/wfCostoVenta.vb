'*****Modulo costo de venta*****
'*****Realizado por Cristian Portillo*****
'*****19 de julio del 2016*************
'*****Este modulo realiza la insercion maestra y transaccional del presupuesto costo de venta*****


Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms
Imports System.Drawing

Public Class wfCostoVenta



    Private Sub dgv1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Public Sub MostrarDatosCMD()
        Conexion.Conectado()
        Conexion.Consulta("Select id_compras_matdirectos from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        cboIdcmad.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")
        cboIdcmad.DisplayMember = "id_compras_matdirectos"
    End Sub

    Public Sub MostrarDatospmod()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_mod from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        cboIdpmod.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")
        cboIdpmod.DisplayMember = "id_presupuesto_mod"
    End Sub

    Public Sub MostrarDatospici()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_ici from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        cboIdici.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ici")
        cboIdici.DisplayMember = "id_presupuesto_ici"
    End Sub

    Public Sub MostrarDatospcv()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_cv from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        cboIdcv.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
        cboIdcv.DisplayMember = "id_presupuesto_cv"
    End Sub

    Public Sub MostrarDatosEmpresa()
        Conexion.Conectado()
        Conexion.Consulta("Select  id_empresa2, emp_nombre_empresa2 from tbl_frm_empresa2", "tbl_frm_empresa2")
        cboEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cboEmpresa.DisplayMember = "emp_nombre_empresa2"
        cboEmpresa.ValueMember = "id_empresa2"
        Conexion.Desconectado()


    End Sub

    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("Select id_usuario, usr_usuario from tbl_frm_usuario", "tbl_frm_usuario")
        cboUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cboUsuario.DisplayMember = "usr_usuario"
        cboUsuario.ValueMember = "id_usuario"
        Conexion.Desconectado()

    End Sub

    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("Select id_moneda2, mnd_moneda2 from tbl_frm_moneda2", "tbl_frm_moneda2")
        cboMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cboMoneda.DisplayMember = "mnd_moneda2"
        cboMoneda.ValueMember = "id_moneda2"
        Conexion.Desconectado()

    End Sub

    Public Sub MostrarCostosMatdirectos()
        Conexion.Conectado()
        Conexion.Consulta("Select id_compras_matdirectos, cmd_nombre from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        cboIdcmad.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")
        cboIdcmad.DisplayMember = "cmd_nombre"
        cboIdcmad.ValueMember = "id_compras_matdirectos"
        Conexion.Desconectado()

    End Sub
    Public Sub MostrarManoObraDirecta()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_mod, mod_nombre from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        cboIdpmod.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")
        cboIdpmod.DisplayMember = "mod_nombre"
        cboIdpmod.ValueMember = "id_presupuesto_mod"
        Conexion.Desconectado()

    End Sub

    Public Sub MostrarImporteCostoIndirecto()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_ici, ici_nombre from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        cboIdici.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ici")
        cboIdici.DisplayMember = "ici_nombre"
        cboIdici.ValueMember = "id_presupuesto_ici"
        Conexion.Desconectado()
    End Sub

    Public Sub MostrarCostoVenta()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_cv, pcv_nombre from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        cboIdcv.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
        cboIdcv.DisplayMember = "pcv_nombre"
        cboIdcv.ValueMember = "id_presupuesto_cv"
        Conexion.Desconectado()
    End Sub
    Public Sub MostrarcboOculto()
        Conexion.Conectado()

        Conexion.Consulta("select id_presupuesto_cv from tbl_frm_presupuesto_cv order by id_presupuesto_cv desc ", "tbl_frm_presupuesto_cv")
        cboOculto.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
        cboOculto.DisplayMember = "id_presupuesto_cv"
        txtOculto.Text = cboOculto.Text
        Conexion.Desconectado()

    End Sub







    Private Sub wfCostoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()


        MostrarCostosMatdirectos()
        MostrarManoObraDirecta()
        MostrarImporteCostoIndirecto()
        MostrarCostoVenta()

        MostrarcboOculto()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim wfConsultaventa As New wfConsultacv
        wfConsultaventa.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnGuardarMaestro_Click(sender As Object, e As EventArgs) Handles btnGuardarMaestro.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("Debe llenar todos los datos")
        Else

            Dim guardar As String = "insert into tbl_frm_presupuesto_cv values ('" + txtNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + txtTotal.Text + "', '" + cboEmpresa.SelectedValue.ToString + "', '" + cboUsuario.SelectedValue.ToString + "', '" + cboMoneda.SelectedValue.ToString + "' )"
            Conexion.Conectado()
            If (Conexion.Insertar(guardar)) Then
                ' MessageBox.Show("Datos ingresados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIdcostoventa.Clear()
                txtNombre.Clear()
                txtTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosUsuario()
                MostrarDatosMoneda()


                GroupBox2.Visible = True

                MostrarcboOculto()

                MostrarCostoVenta()
                Conexion.Desconectado()

            Else
                MessageBox.Show("Error al guardar, verifique sus datos", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Conexion.Desconectado()
            End If

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As New wfConsultacv
        consulta.Show()

    End Sub


    Private Sub txtcmdt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcmdt.KeyDown

        If e.KeyCode = Keys.Tab Then
            Dim aat As Double = Convert.ToDouble(txtaat.Text)
            Dim pp As Double = Convert.ToDouble(txtpp.Text)
            Dim imd As Double = Convert.ToDouble(txtimd.Text)
            Dim cmdt As Double = Convert.ToDouble(txtcmdt.Text)
            Dim tcp As Double
            tcp = (aat - pp) + (imd - cmdt)
            txttcp.Text = tcp.ToString
        End If
    End Sub

    Private Sub txtcmdt_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtcmdt.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            Dim aat As Double = Convert.ToDouble(txtaat.Text)
            Dim pp As Double = Convert.ToDouble(txtpp.Text)
            Dim imd As Double = Convert.ToDouble(txtimd.Text)
            Dim cmdt As Double = Convert.ToDouble(txtcmdt.Text)
            Dim tcp As Double
            tcp = (aat - pp) + (imd - cmdt)
            txttcp.Text = tcp.ToString
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub txtaatd_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtaatd.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then

            Dim ppid As Double = Convert.ToDouble(txtppid.Text)
            Dim cpat As Double = Convert.ToDouble(txtcpat.Text)
            Dim catd As Double = Convert.ToDouble(txtcatd.Text)
            Dim aatd As Double = Convert.ToDouble(txtaatd.Text)
            Dim tcp As Double = Convert.ToDouble(txttcp.Text)
            Dim tpp As Double
            Dim total As Double
            tpp = (ppid - cpat) + (catd - aatd)
            txttpp.Text = tpp.ToString
            total = tpp + tcp

            txtTotal.Text = total.ToString
        End If
    End Sub
    Private Sub txtaatd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaatd.KeyDown
        If e.KeyCode = Keys.Tab Then

            Dim ppid As Double = Convert.ToDouble(txtppid.Text)
            Dim cpat As Double = Convert.ToDouble(txtcpat.Text)
            Dim catd As Double = Convert.ToDouble(txtcatd.Text)
            Dim aatd As Double = Convert.ToDouble(txtaatd.Text)
            Dim tcp As Double = Convert.ToDouble(txttcp.Text)
            Dim tpp As Double
            Dim total As Double
            tpp = (ppid - cpat) + (catd - aatd)
            txttpp.Text = tpp.ToString
            total = tpp + tcp

            txtTotal.Text = total.ToString
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim guardar As String = "insert into tbl_frm_costos_equivalentes values ('" + cboIdcmad.SelectedValue.ToString + "', '" + cboIdpmod.SelectedValue.ToString + "', '" + cboIdici.SelectedValue.ToString + "', '" + cboIdcv.SelectedValue.ToString + "', '" + txtaat.Text + "', '" + txtpp.Text + "', '" + txtimd.Text + "', '" + txtcmdt.Text + "', '" + txttcp.Text + "', '" + txttpp.Text + "', '" + txtppid.Text + "', '" + txtcpat.Text + "', '" + txtcatd.Text + "', '" + txtaatd.Text + "' )"
            Conexion.Conectado()
            If (Conexion.Insertar(guardar)) Then
                Dim modificar As String = "pcv_grantotal= '" + txtTotal.Text + "'"
                If (Conexion.Modificar("tbl_frm_presupuesto_cv", modificar, "id_presupuesto_cv=" + txtOculto.Text)) Then
                    txtTotal.Clear()
                Else
                    MessageBox.Show("Error al guardar, verifique sus datos", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                MessageBox.Show("Datos ingresados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtaat.Text = 0
                txtpp.Text = 0
                txtimd.Text = 0
                txtcmdt.Text = 0
                txttcp.Text = 0
                txttpp.Text = 0
                txtppid.Text = 0
                txtcpat.Text = 0
                txtcatd.Text = 0
                txtaat.Text = 0
                txtaatd.Text = 0
                txtTotal.Text = 0
                txtNombre.Clear()



                MostrarDatosEmpresa()
                MostrarDatosUsuario()
                MostrarDatosMoneda()




                GroupBox2.Visible = False
                GroupBox1.Visible = True


                Conexion.Desconectado()

            Else
                MessageBox.Show("Error al guardar, verifique sus datos", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Conexion.Desconectado()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try






    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtaat.Clear()
        txtpp.Clear()
        txtimd.Clear()
        txtcmdt.Clear()
        txttcp.Clear()
        txttpp.Clear()
        txtppid.Clear()
        txtcpat.Clear()
        txtcatd.Clear()
        txtaat.Clear()
        txtTotal.Clear()
        txtNombre.Clear()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrEmpty(txtIdcostoventa.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "pcv_nombre= '" + txtNombre.Text + "', pcv_periodo= '" + dtpPeriodo.Value.Date + "',id_empresa2= '" + cboEmpresa.SelectedValue.ToString + "',id_usuario= '" + cboUsuario.SelectedValue.ToString + "',id_moneda2= '" + cboMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_presupuesto_cv", modificar, "id_presupuesto_cv=" + txtIdcostoventa.Text)) Then
                MessageBox.Show("Datos modificados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIdcostoventa.Clear()
                txtNombre.Clear()

                MostrarDatosEmpresa()
                MostrarDatosUsuario()
                MostrarDatosMoneda()

                MostrarcboOculto()


                GroupBox2.Visible = False
                GroupBox1.Visible = True
                Conexion.Desconectado()

            Else
                MessageBox.Show("Error al modificar")
            End If

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(txtIdcostoventa.Text) Then
                MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else

                If (Conexion.Eliminar("tbl_frm_presupuesto_cv", "id_presupuesto_cv= " + txtIdcostoventa.Text)) Then
                    MessageBox.Show("Datos Eliminados exitosamente", "Software FRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdcostoventa.Clear()
                    txtNombre.Clear()

                    MostrarDatosEmpresa()
                    MostrarDatosUsuario()
                    MostrarDatosMoneda()

                    MostrarcboOculto()

                    txtaat.Text = 0
                    txtpp.Text = 0
                    txtimd.Text = 0
                    txtcmdt.Text = 0
                    txttcp.Text = 0
                    txttpp.Text = 0
                    txtppid.Text = 0
                    txtcpat.Text = 0
                    txtcatd.Text = 0
                    txtaat.Text = 0
                    txtaatd.Text = 0
                    txtTotal.Text = 0
                    txtNombre.Clear()



                    GroupBox2.Visible = False
                    GroupBox1.Visible = True

                Else
                    MessageBox.Show("Error al eliminar, el dato no existe")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea costos asignados a el")
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim popup As New wfPopupcv
        popup.Show()
    End Sub
End Class