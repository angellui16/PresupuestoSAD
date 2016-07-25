Imports dllConexion

Public Class wfConsultacv
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
    Public Sub MostrarDatosEncabezado()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        dgvEncabezado.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
        dgvEncabezado.Columns(0).HeaderText = "ID presupuesto"
        dgvEncabezado.Columns(1).HeaderText = "Nombre"
        dgvEncabezado.Columns(2).HeaderText = "Fecha"
        dgvEncabezado.Columns(3).HeaderText = "Total presupuesto"
        dgvEncabezado.Columns(4).HeaderText = "ID empresa"
        dgvEncabezado.Columns(5).HeaderText = "ID usuario"
        dgvEncabezado.Columns(6).HeaderText = "ID moneda"
    End Sub

    Public Sub MostrarDatosFormulario()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_costos_equivalentes", "tbl_frm_costos_equivalentes")
        dgvForm.DataSource = Conexion.ds.Tables("tbl_frm_costos_equivalentes")
        dgvForm.Columns(0).HeaderText = "ID Costo de venta"
        dgvForm.Columns(1).HeaderText = "ID Mat. Directo"
        dgvForm.Columns(2).HeaderText = "ID Mano de obra"
        dgvForm.Columns(3).HeaderText = "Id Costo indirecto"
        dgvForm.Columns(4).HeaderText = "ID Costo de venta"
        dgvForm.Columns(5).HeaderText = "Articulos terminados(Art. T)"
        dgvForm.Columns(6).HeaderText = "Produccion en proceso(Inv. E)"
        dgvForm.Columns(7).HeaderText = "Inventario mat. directos"
        dgvForm.Columns(8).HeaderText = "Total costo de produccion"
        dgvForm.Columns(9).HeaderText = "Inventario mat. directos"
        dgvForm.Columns(10).HeaderText = "Total produccion en proceso"
        dgvForm.Columns(11).HeaderText = "Prod. Proceso inventario deseado"
        dgvForm.Columns(12).HeaderText = "Produccion art terminados."
        dgvForm.Columns(13).HeaderText = "Art. terminados disponible"
        dgvForm.Columns(14).HeaderText = "Art. terminados deseados"


    End Sub

    Private Sub wfConsultacv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEncabezado()
        MostrarDatosFormulario()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MostrarDatosEncabezado()
        MostrarDatosFormulario()
    End Sub
End Class