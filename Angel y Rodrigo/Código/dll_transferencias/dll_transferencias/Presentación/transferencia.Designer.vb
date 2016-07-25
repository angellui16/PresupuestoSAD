<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transferencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgMod = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.dgGastos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgCostoVentas = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgGva = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.txtTotalNuevo = New System.Windows.Forms.TextBox()
        Me.txtId2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtPeriodo2 = New System.Windows.Forms.TextBox()
        Me.txtTotal2 = New System.Windows.Forms.TextBox()
        Me.txtEmpresa2 = New System.Windows.Forms.TextBox()
        Me.txtUsuario2 = New System.Windows.Forms.TextBox()
        Me.txtMoneda2 = New System.Windows.Forms.TextBox()
        Me.txtTotalNuevo2 = New System.Windows.Forms.TextBox()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTabla = New System.Windows.Forms.TextBox()
        Me.txtTabla2 = New System.Windows.Forms.TextBox()
        Me.dtpNuevoPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.cboUsrMod = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.btnTransferencia = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgCostoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgGva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(36, 127)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(755, 183)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgVentas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(747, 157)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgVentas
        '
        Me.dgVentas.AllowUserToAddRows = False
        Me.dgVentas.AllowUserToDeleteRows = False
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Location = New System.Drawing.Point(3, 3)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ReadOnly = True
        Me.dgVentas.Size = New System.Drawing.Size(741, 150)
        Me.dgVentas.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgMateriales)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(747, 157)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Materiales directos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgMateriales
        '
        Me.dgMateriales.AllowUserToAddRows = False
        Me.dgMateriales.AllowUserToDeleteRows = False
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Location = New System.Drawing.Point(3, 3)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.ReadOnly = True
        Me.dgMateriales.Size = New System.Drawing.Size(741, 150)
        Me.dgMateriales.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgMod)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(747, 157)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Mano de obra directa"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgMod
        '
        Me.dgMod.AllowUserToAddRows = False
        Me.dgMod.AllowUserToDeleteRows = False
        Me.dgMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMod.Location = New System.Drawing.Point(3, 3)
        Me.dgMod.Name = "dgMod"
        Me.dgMod.ReadOnly = True
        Me.dgMod.Size = New System.Drawing.Size(741, 150)
        Me.dgMod.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.dgGastos)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(747, 157)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Gastos indirectos"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'dgGastos
        '
        Me.dgGastos.AllowUserToAddRows = False
        Me.dgGastos.AllowUserToDeleteRows = False
        Me.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastos.Location = New System.Drawing.Point(3, 3)
        Me.dgGastos.Name = "dgGastos"
        Me.dgGastos.ReadOnly = True
        Me.dgGastos.Size = New System.Drawing.Size(741, 150)
        Me.dgGastos.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgCostoVentas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(747, 157)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Costo de ventas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgCostoVentas
        '
        Me.dgCostoVentas.AllowUserToAddRows = False
        Me.dgCostoVentas.AllowUserToDeleteRows = False
        Me.dgCostoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCostoVentas.Location = New System.Drawing.Point(3, 3)
        Me.dgCostoVentas.Name = "dgCostoVentas"
        Me.dgCostoVentas.ReadOnly = True
        Me.dgCostoVentas.Size = New System.Drawing.Size(744, 150)
        Me.dgCostoVentas.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgGva)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(747, 157)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gastos de venta y admón"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgGva
        '
        Me.dgGva.AllowUserToAddRows = False
        Me.dgGva.AllowUserToDeleteRows = False
        Me.dgGva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGva.Location = New System.Drawing.Point(3, 3)
        Me.dgGva.Name = "dgGva"
        Me.dgGva.ReadOnly = True
        Me.dgGva.Size = New System.Drawing.Size(741, 150)
        Me.dgGva.TabIndex = 0
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(43, 329)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(44, 20)
        Me.txtId.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(93, 328)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Enabled = False
        Me.txtPeriodo.Location = New System.Drawing.Point(255, 329)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(183, 20)
        Me.txtPeriodo.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(444, 328)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(91, 20)
        Me.txtTotal.TabIndex = 4
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Location = New System.Drawing.Point(541, 328)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(42, 20)
        Me.txtEmpresa.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad a transferir:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(589, 328)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(42, 20)
        Me.txtUsuario.TabIndex = 9
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(639, 328)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(42, 20)
        Me.txtMoneda.TabIndex = 10
        '
        'txtTotalNuevo
        '
        Me.txtTotalNuevo.Enabled = False
        Me.txtTotalNuevo.Location = New System.Drawing.Point(688, 328)
        Me.txtTotalNuevo.Name = "txtTotalNuevo"
        Me.txtTotalNuevo.Size = New System.Drawing.Size(99, 20)
        Me.txtTotalNuevo.TabIndex = 11
        '
        'txtId2
        '
        Me.txtId2.Enabled = False
        Me.txtId2.Location = New System.Drawing.Point(43, 378)
        Me.txtId2.Name = "txtId2"
        Me.txtId2.Size = New System.Drawing.Size(44, 20)
        Me.txtId2.TabIndex = 12
        '
        'txtNombre2
        '
        Me.txtNombre2.Enabled = False
        Me.txtNombre2.Location = New System.Drawing.Point(93, 378)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(156, 20)
        Me.txtNombre2.TabIndex = 13
        '
        'txtPeriodo2
        '
        Me.txtPeriodo2.Enabled = False
        Me.txtPeriodo2.Location = New System.Drawing.Point(256, 378)
        Me.txtPeriodo2.Name = "txtPeriodo2"
        Me.txtPeriodo2.Size = New System.Drawing.Size(182, 20)
        Me.txtPeriodo2.TabIndex = 14
        '
        'txtTotal2
        '
        Me.txtTotal2.Enabled = False
        Me.txtTotal2.Location = New System.Drawing.Point(444, 379)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Size = New System.Drawing.Size(91, 20)
        Me.txtTotal2.TabIndex = 15
        '
        'txtEmpresa2
        '
        Me.txtEmpresa2.Enabled = False
        Me.txtEmpresa2.Location = New System.Drawing.Point(542, 378)
        Me.txtEmpresa2.Name = "txtEmpresa2"
        Me.txtEmpresa2.Size = New System.Drawing.Size(41, 20)
        Me.txtEmpresa2.TabIndex = 16
        '
        'txtUsuario2
        '
        Me.txtUsuario2.Enabled = False
        Me.txtUsuario2.Location = New System.Drawing.Point(589, 379)
        Me.txtUsuario2.Name = "txtUsuario2"
        Me.txtUsuario2.Size = New System.Drawing.Size(42, 20)
        Me.txtUsuario2.TabIndex = 17
        '
        'txtMoneda2
        '
        Me.txtMoneda2.Enabled = False
        Me.txtMoneda2.Location = New System.Drawing.Point(639, 378)
        Me.txtMoneda2.Name = "txtMoneda2"
        Me.txtMoneda2.Size = New System.Drawing.Size(42, 20)
        Me.txtMoneda2.TabIndex = 18
        '
        'txtTotalNuevo2
        '
        Me.txtTotalNuevo2.Enabled = False
        Me.txtTotalNuevo2.Location = New System.Drawing.Point(688, 378)
        Me.txtTotalNuevo2.Name = "txtTotalNuevo2"
        Me.txtTotalNuevo2.Size = New System.Drawing.Size(99, 20)
        Me.txtTotalNuevo2.TabIndex = 19
        '
        'txtTransferencia
        '
        Me.txtTransferencia.Location = New System.Drawing.Point(43, 437)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(123, 20)
        Me.txtTransferencia.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnValidar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnTransferencia)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Location = New System.Drawing.Point(1, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 83)
        Me.Panel1.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(633, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Validar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(681, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Transferencia"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(49, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Reportes"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(775, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 13)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Salir"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(563, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Limpiar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(345, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Transferencias presupuestarias"
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(211, 437)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Size = New System.Drawing.Size(203, 20)
        Me.txtTabla.TabIndex = 41
        Me.txtTabla.Visible = False
        '
        'txtTabla2
        '
        Me.txtTabla2.Location = New System.Drawing.Point(430, 437)
        Me.txtTabla2.Name = "txtTabla2"
        Me.txtTabla2.Size = New System.Drawing.Size(203, 20)
        Me.txtTabla2.TabIndex = 42
        Me.txtTabla2.Visible = False
        '
        'dtpNuevoPeriodo
        '
        Me.dtpNuevoPeriodo.CustomFormat = "dd/MM/yyyy"
        Me.dtpNuevoPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNuevoPeriodo.Location = New System.Drawing.Point(666, 87)
        Me.dtpNuevoPeriodo.Name = "dtpNuevoPeriodo"
        Me.dtpNuevoPeriodo.Size = New System.Drawing.Size(121, 20)
        Me.dtpNuevoPeriodo.TabIndex = 43
        '
        'cboUsrMod
        '
        Me.cboUsrMod.FormattingEnabled = True
        Me.cboUsrMod.Location = New System.Drawing.Point(666, 113)
        Me.cboUsrMod.Name = "cboUsrMod"
        Me.cboUsrMod.Size = New System.Drawing.Size(121, 21)
        Me.cboUsrMod.TabIndex = 44
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.file_folder
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(36, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 40
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnValidar.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.check1
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidar.FlatAppearance.BorderSize = 0
        Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidar.Location = New System.Drawing.Point(622, 4)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(58, 59)
        Me.btnValidar.TabIndex = 40
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'btnTransferencia
        '
        Me.btnTransferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTransferencia.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.outside
        Me.btnTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransferencia.FlatAppearance.BorderSize = 0
        Me.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferencia.Location = New System.Drawing.Point(687, 4)
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.Size = New System.Drawing.Size(58, 59)
        Me.btnTransferencia.TabIndex = 37
        Me.btnTransferencia.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.inside
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(756, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 59)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.substract
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(552, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(58, 59)
        Me.btnLimpiar.TabIndex = 28
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.BackgroundImage = Global.dll_transferencias.My.Resources.Resources.print_icon
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Location = New System.Drawing.Point(42, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(58, 59)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 549)
        Me.Controls.Add(Me.cboUsrMod)
        Me.Controls.Add(Me.dtpNuevoPeriodo)
        Me.Controls.Add(Me.txtTabla2)
        Me.Controls.Add(Me.txtTabla)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTransferencia)
        Me.Controls.Add(Me.txtTotalNuevo2)
        Me.Controls.Add(Me.txtMoneda2)
        Me.Controls.Add(Me.txtUsuario2)
        Me.Controls.Add(Me.txtEmpresa2)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.txtPeriodo2)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.txtId2)
        Me.Controls.Add(Me.txtTotalNuevo)
        Me.Controls.Add(Me.txtMoneda)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transferencia"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgCostoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgGva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgCostoVentas As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgGva As System.Windows.Forms.DataGridView
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtId2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNuevo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents dgMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents dgMod As System.Windows.Forms.DataGridView
    Friend WithEvents dgGastos As System.Windows.Forms.DataGridView
    Friend WithEvents txtTabla As System.Windows.Forms.TextBox
    Friend WithEvents txtTabla2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpNuevoPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboUsrMod As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnValidar As System.Windows.Forms.Button
End Class
