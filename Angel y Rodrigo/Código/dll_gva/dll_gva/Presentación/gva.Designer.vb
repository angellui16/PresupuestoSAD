<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTotalVentas = New System.Windows.Forms.TextBox()
        Me.txtTotalAdmon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblAdmon = New System.Windows.Forms.Label()
        Me.txtGranTotal = New System.Windows.Forms.TextBox()
        Me.lblGva = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnTransferencia = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboDgv = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAdmon = New System.Windows.Forms.DataGridView()
        Me.Column1Admon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboDgv2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3Admon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4Admon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcPresupuesto = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.cboOculto = New System.Windows.Forms.ComboBox()
        Me.txtOculto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAdmon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPresupuesto.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.Enabled = False
        Me.txtTotalVentas.Location = New System.Drawing.Point(761, 309)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        Me.txtTotalVentas.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalVentas.TabIndex = 4
        Me.txtTotalVentas.Visible = False
        '
        'txtTotalAdmon
        '
        Me.txtTotalAdmon.Enabled = False
        Me.txtTotalAdmon.Location = New System.Drawing.Point(761, 335)
        Me.txtTotalAdmon.Name = "txtTotalAdmon"
        Me.txtTotalAdmon.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAdmon.TabIndex = 10
        Me.txtTotalAdmon.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Presupuesto de gastos de venta y admón"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(620, 316)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(135, 13)
        Me.lblVenta.TabIndex = 16
        Me.lblVenta.Text = "Total gastos de venta:"
        Me.lblVenta.Visible = False
        '
        'lblAdmon
        '
        Me.lblAdmon.AutoSize = True
        Me.lblAdmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmon.Location = New System.Drawing.Point(571, 342)
        Me.lblAdmon.Name = "lblAdmon"
        Me.lblAdmon.Size = New System.Drawing.Size(184, 13)
        Me.lblAdmon.TabIndex = 22
        Me.lblAdmon.Text = "Total gastos de administración:"
        Me.lblAdmon.Visible = False
        '
        'txtGranTotal
        '
        Me.txtGranTotal.Enabled = False
        Me.txtGranTotal.Location = New System.Drawing.Point(761, 361)
        Me.txtGranTotal.Name = "txtGranTotal"
        Me.txtGranTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtGranTotal.TabIndex = 23
        Me.txtGranTotal.Visible = False
        '
        'lblGva
        '
        Me.lblGva.AutoSize = True
        Me.lblGva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGva.Location = New System.Drawing.Point(525, 368)
        Me.lblGva.Name = "lblGva"
        Me.lblGva.Size = New System.Drawing.Size(230, 13)
        Me.lblGva.TabIndex = 24
        Me.lblGva.Text = "Total gastos de venta y administración:"
        Me.lblGva.Visible = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(77, 115)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(54, 20)
        Me.txtId.TabIndex = 28
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(77, 141)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 29
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = ""
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodo.Location = New System.Drawing.Point(76, 167)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(95, 20)
        Me.dtpPeriodo.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "ID:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Nombre:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Fecha:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 428)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(867, 183)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvDatos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(859, 157)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gastos de venta y admón"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(3, 5)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(853, 150)
        Me.dgvDatos.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.btnTransferencia)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, 623)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 83)
        Me.Panel1.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(551, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Detalle"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.BackgroundImage = Global.dll_gva.My.Resources.Resources.download
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(540, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 59)
        Me.Button2.TabIndex = 50
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Reporte"
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReporte.BackgroundImage = Global.dll_gva.My.Resources.Resources.print_icon
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Location = New System.Drawing.Point(91, 4)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(58, 59)
        Me.btnReporte.TabIndex = 48
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 13)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Transferencia"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(487, 66)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "Limpiar"
        '
        'btnTransferencia
        '
        Me.btnTransferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTransferencia.BackgroundImage = Global.dll_gva.My.Resources.Resources.outside
        Me.btnTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransferencia.FlatAppearance.BorderSize = 0
        Me.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferencia.Location = New System.Drawing.Point(19, 5)
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.Size = New System.Drawing.Size(58, 59)
        Me.btnTransferencia.TabIndex = 46
        Me.btnTransferencia.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.BackgroundImage = Global.dll_gva.My.Resources.Resources.substract
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(476, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(58, 59)
        Me.btnLimpiar.TabIndex = 39
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(817, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 13)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Salir"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(744, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Eliminar"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(677, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Modificar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(612, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.BackgroundImage = Global.dll_gva.My.Resources.Resources.inside
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(798, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 59)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.BackgroundImage = Global.dll_gva.My.Resources.Resources.close2
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(734, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(58, 59)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.BackgroundImage = Global.dll_gva.My.Resources.Resources.pen
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(670, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(58, 59)
        Me.btnModificar.TabIndex = 29
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.BackgroundImage = Global.dll_gva.My.Resources.Resources.Floppy_disk_512
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(604, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardar.TabIndex = 28
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(683, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Empresa:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(688, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Usuario:"
        '
        'dgVenta
        '
        Me.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.cboDgv, Me.Column3, Me.Column4})
        Me.dgVenta.Location = New System.Drawing.Point(3, 3)
        Me.dgVenta.Name = "dgVenta"
        Me.dgVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgVenta.Size = New System.Drawing.Size(389, 150)
        Me.dgVenta.TabIndex = 44
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id Gastos venta"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'cboDgv
        '
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cboDgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.cboDgv.HeaderText = "Id Presupuesto gva"
        Me.cboDgv.Name = "cboDgv"
        Me.cboDgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboDgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboDgv.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Gastos de venta"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 105
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        '
        'dgAdmon
        '
        Me.dgAdmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAdmon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1Admon, Me.cboDgv2, Me.Column3Admon, Me.Column4Admon})
        Me.dgAdmon.Location = New System.Drawing.Point(1, 0)
        Me.dgAdmon.Name = "dgAdmon"
        Me.dgAdmon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgAdmon.Size = New System.Drawing.Size(395, 150)
        Me.dgAdmon.TabIndex = 45
        '
        'Column1Admon
        '
        Me.Column1Admon.HeaderText = "Id Gastos de admon"
        Me.Column1Admon.Name = "Column1Admon"
        Me.Column1Admon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1Admon.Visible = False
        '
        'cboDgv2
        '
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cboDgv2.DefaultCellStyle = DataGridViewCellStyle2
        Me.cboDgv2.HeaderText = "Id Presupuesto gva"
        Me.cboDgv2.Name = "cboDgv2"
        Me.cboDgv2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboDgv2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboDgv2.Width = 130
        '
        'Column3Admon
        '
        Me.Column3Admon.HeaderText = "Gastos de admón"
        Me.Column3Admon.Name = "Column3Admon"
        Me.Column3Admon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3Admon.Width = 105
        '
        'Column4Admon
        '
        Me.Column4Admon.HeaderText = "Cantidad"
        Me.Column4Admon.Name = "Column4Admon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(685, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Moneda:"
        '
        'tcPresupuesto
        '
        Me.tcPresupuesto.Controls.Add(Me.TabPage2)
        Me.tcPresupuesto.Controls.Add(Me.TabPage3)
        Me.tcPresupuesto.Location = New System.Drawing.Point(76, 215)
        Me.tcPresupuesto.Name = "tcPresupuesto"
        Me.tcPresupuesto.SelectedIndex = 0
        Me.tcPresupuesto.Size = New System.Drawing.Size(404, 178)
        Me.tcPresupuesto.TabIndex = 47
        Me.tcPresupuesto.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgVenta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(396, 152)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Gastos de venta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgAdmon)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(396, 152)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Gastos de admón"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(740, 114)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpresa.TabIndex = 48
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(740, 143)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 49
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(740, 170)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cboMoneda.TabIndex = 50
        '
        'cboOculto
        '
        Me.cboOculto.FormattingEnabled = True
        Me.cboOculto.Location = New System.Drawing.Point(816, 53)
        Me.cboOculto.Name = "cboOculto"
        Me.cboOculto.Size = New System.Drawing.Size(45, 21)
        Me.cboOculto.TabIndex = 51
        Me.cboOculto.Visible = False
        '
        'txtOculto
        '
        Me.txtOculto.Location = New System.Drawing.Point(816, 82)
        Me.txtOculto.Name = "txtOculto"
        Me.txtOculto.Size = New System.Drawing.Size(45, 20)
        Me.txtOculto.TabIndex = 52
        Me.txtOculto.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.dll_gva.My.Resources.Resources.phonebook1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(24, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(891, 703)
        Me.Controls.Add(Me.txtOculto)
        Me.Controls.Add(Me.cboOculto)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.tcPresupuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblGva)
        Me.Controls.Add(Me.txtGranTotal)
        Me.Controls.Add(Me.lblAdmon)
        Me.Controls.Add(Me.lblVenta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalAdmon)
        Me.Controls.Add(Me.txtTotalVentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gva"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAdmon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPresupuesto.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalVentas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAdmon As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents lblAdmon As System.Windows.Forms.Label
    Friend WithEvents txtGranTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblGva As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgVenta As System.Windows.Forms.DataGridView
    Friend WithEvents dgAdmon As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents tcPresupuesto As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboOculto As System.Windows.Forms.ComboBox
    Friend WithEvents txtOculto As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboDgv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1Admon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboDgv2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3Admon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4Admon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
