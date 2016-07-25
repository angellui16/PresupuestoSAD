<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frCMaterialesDirectos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frCMaterialesDirectos))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbGTotal = New System.Windows.Forms.TextBox()
        Me.lblGTotal = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbIdpresupuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardarMaestro = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtFilas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbControl = New System.Windows.Forms.ComboBox()
        Me.tbControl = New System.Windows.Forms.TextBox()
        Me.cbId_produccion = New System.Windows.Forms.ComboBox()
        Me.cbId_PProduccion = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgDMD = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgMD = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgUltimo2 = New System.Windows.Forms.DataGridView()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatD3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgUltimo = New System.Windows.Forms.DataGridView()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MD3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDMD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgMD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgUltimo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUltimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(500, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 15)
        Me.Label25.TabIndex = 117
        Me.Label25.Text = "Id Pres. Producción"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(500, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 15)
        Me.Label24.TabIndex = 116
        Me.Label24.Text = "Id Producción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Moneda:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(321, 85)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 114
        Me.lblUsuario.Text = "Usuario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Id empresa:"
        '
        'tbGTotal
        '
        Me.tbGTotal.Enabled = False
        Me.tbGTotal.Location = New System.Drawing.Point(201, 586)
        Me.tbGTotal.Name = "tbGTotal"
        Me.tbGTotal.ReadOnly = True
        Me.tbGTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbGTotal.TabIndex = 99
        Me.tbGTotal.Text = "0"
        '
        'lblGTotal
        '
        Me.lblGTotal.AutoSize = True
        Me.lblGTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGTotal.Location = New System.Drawing.Point(7, 589)
        Me.lblGTotal.Name = "lblGTotal"
        Me.lblGTotal.Size = New System.Drawing.Size(188, 13)
        Me.lblGTotal.TabIndex = 112
        Me.lblGTotal.Text = "Gran Total de Mat. a Comprarse"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy/MM/dd"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodo.Location = New System.Drawing.Point(126, 104)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(100, 20)
        Me.dtpPeriodo.TabIndex = 2
        Me.dtpPeriodo.Value = New Date(2016, 7, 6, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Fecha:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(126, 76)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(185, 20)
        Me.tbNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Nombre:"
        '
        'tbIdpresupuesto
        '
        Me.tbIdpresupuesto.Location = New System.Drawing.Point(126, 50)
        Me.tbIdpresupuesto.Name = "tbIdpresupuesto"
        Me.tbIdpresupuesto.ReadOnly = True
        Me.tbIdpresupuesto.Size = New System.Drawing.Size(48, 20)
        Me.tbIdpresupuesto.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Id presupuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 25)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Módulo Compras Materiales Directos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnGuardarMaestro)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 83)
        Me.Panel1.TabIndex = 106
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(86, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Reporte"
        '
        'btnReporte
        '
        Me.btnReporte.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.print_icon
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Location = New System.Drawing.Point(71, 6)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(65, 55)
        Me.btnReporte.TabIndex = 84
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(400, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Detalle"
        '
        'btnGuardarMaestro
        '
        Me.btnGuardarMaestro.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.download
        Me.btnGuardarMaestro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarMaestro.FlatAppearance.BorderSize = 0
        Me.btnGuardarMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMaestro.Location = New System.Drawing.Point(392, 2)
        Me.btnGuardarMaestro.Name = "btnGuardarMaestro"
        Me.btnGuardarMaestro.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardarMaestro.TabIndex = 82
        Me.btnGuardarMaestro.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 81
        Me.Label23.Text = "Transferencia"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.outside
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(8, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 55)
        Me.Button3.TabIndex = 22
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(664, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Salir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(596, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Eliminar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(528, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Modificar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Limpiar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(464, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.inside
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(650, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 59)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.close2
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(584, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(58, 59)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.pen
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(520, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(58, 59)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.substract
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(328, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(58, 59)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.Floppy_disk_512
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(456, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtFilas
        '
        Me.txtFilas.Location = New System.Drawing.Point(621, 101)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(87, 20)
        Me.txtFilas.TabIndex = 121
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(502, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "No. Productos"
        '
        'btnCrear
        '
        Me.btnCrear.Enabled = False
        Me.btnCrear.Location = New System.Drawing.Point(621, 130)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(61, 27)
        Me.btnCrear.TabIndex = 123
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(399, 50)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(95, 21)
        Me.cbEmpresa.TabIndex = 125
        '
        'cbUsuario
        '
        Me.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(399, 75)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(95, 21)
        Me.cbUsuario.TabIndex = 126
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(399, 100)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(95, 21)
        Me.cbMoneda.TabIndex = 127
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.dll_ComprasMaterialesDirectos.My.Resources.Resources.phonebook1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(41, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 52)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbControl
        '
        Me.cbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbControl.Enabled = False
        Me.cbControl.FormattingEnabled = True
        Me.cbControl.Location = New System.Drawing.Point(666, 582)
        Me.cbControl.Name = "cbControl"
        Me.cbControl.Size = New System.Drawing.Size(39, 21)
        Me.cbControl.TabIndex = 128
        '
        'tbControl
        '
        Me.tbControl.Enabled = False
        Me.tbControl.Location = New System.Drawing.Point(666, 582)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.Size = New System.Drawing.Size(39, 20)
        Me.tbControl.TabIndex = 129
        '
        'cbId_produccion
        '
        Me.cbId_produccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbId_produccion.FormattingEnabled = True
        Me.cbId_produccion.Location = New System.Drawing.Point(621, 51)
        Me.cbId_produccion.Name = "cbId_produccion"
        Me.cbId_produccion.Size = New System.Drawing.Size(87, 21)
        Me.cbId_produccion.TabIndex = 130
        '
        'cbId_PProduccion
        '
        Me.cbId_PProduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbId_PProduccion.FormattingEnabled = True
        Me.cbId_PProduccion.Location = New System.Drawing.Point(621, 78)
        Me.cbId_PProduccion.Name = "cbId_PProduccion"
        Me.cbId_PProduccion.Size = New System.Drawing.Size(87, 21)
        Me.cbId_PProduccion.TabIndex = 131
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgDMD)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(694, 393)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle Materiales Directos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgDMD
        '
        Me.dgDMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDMD.Location = New System.Drawing.Point(0, 0)
        Me.dgDMD.Name = "dgDMD"
        Me.dgDMD.Size = New System.Drawing.Size(694, 393)
        Me.dgDMD.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgMD)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta Materiales Directos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgMD
        '
        Me.dgMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMD.Location = New System.Drawing.Point(3, 3)
        Me.dgMD.Name = "dgMD"
        Me.dgMD.Size = New System.Drawing.Size(688, 387)
        Me.dgMD.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgUltimo2)
        Me.TabPage4.Controls.Add(Me.dgUltimo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(694, 393)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Detalle Materiales Directos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgUltimo2
        '
        Me.dgUltimo2.AllowUserToAddRows = False
        Me.dgUltimo2.AllowUserToDeleteRows = False
        Me.dgUltimo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUltimo2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.MatD1, Me.MatD2, Me.MatD3})
        Me.dgUltimo2.Location = New System.Drawing.Point(8, 207)
        Me.dgUltimo2.Name = "dgUltimo2"
        Me.dgUltimo2.Size = New System.Drawing.Size(683, 179)
        Me.dgUltimo2.TabIndex = 4
        Me.dgUltimo2.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = ""
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 200
        '
        'MatD1
        '
        DataGridViewCellStyle1.Format = "Q###,###,###.##"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.MatD1.DefaultCellStyle = DataGridViewCellStyle1
        Me.MatD1.HeaderText = ""
        Me.MatD1.Name = "MatD1"
        Me.MatD1.Width = 145
        '
        'MatD2
        '
        DataGridViewCellStyle2.Format = "Q###,###,###.##"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.MatD2.DefaultCellStyle = DataGridViewCellStyle2
        Me.MatD2.HeaderText = ""
        Me.MatD2.Name = "MatD2"
        Me.MatD2.Width = 145
        '
        'MatD3
        '
        DataGridViewCellStyle3.Format = "Q###,###,###.##"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.MatD3.DefaultCellStyle = DataGridViewCellStyle3
        Me.MatD3.HeaderText = ""
        Me.MatD3.Name = "MatD3"
        Me.MatD3.Width = 145
        '
        'dgUltimo
        '
        Me.dgUltimo.AllowUserToAddRows = False
        Me.dgUltimo.AllowUserToDeleteRows = False
        Me.dgUltimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUltimo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripción, Me.MD1, Me.MD2, Me.MD3})
        Me.dgUltimo.Location = New System.Drawing.Point(8, 3)
        Me.dgUltimo.Name = "dgUltimo"
        Me.dgUltimo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUltimo.Size = New System.Drawing.Size(683, 198)
        Me.dgUltimo.TabIndex = 0
        Me.dgUltimo.Visible = False
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "DESCRIPCIÓN"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Width = 200
        '
        'MD1
        '
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.MD1.DefaultCellStyle = DataGridViewCellStyle4
        Me.MD1.HeaderText = "PRODUCTO D. 1"
        Me.MD1.Name = "MD1"
        Me.MD1.Width = 145
        '
        'MD2
        '
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.MD2.DefaultCellStyle = DataGridViewCellStyle5
        Me.MD2.HeaderText = "PRODUCTO D.2"
        Me.MD2.Name = "MD2"
        Me.MD2.Width = 145
        '
        'MD3
        '
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.MD3.DefaultCellStyle = DataGridViewCellStyle6
        Me.MD3.HeaderText = "PRODUCTO D.3"
        Me.MD3.Name = "MD3"
        Me.MD3.Width = 145
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(10, 145)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(702, 419)
        Me.TabControl1.TabIndex = 105
        '
        'frCMaterialesDirectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbId_PProduccion)
        Me.Controls.Add(Me.cbId_produccion)
        Me.Controls.Add(Me.tbControl)
        Me.Controls.Add(Me.cbControl)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtFilas)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbGTotal)
        Me.Controls.Add(Me.lblGTotal)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbIdpresupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frCMaterialesDirectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Compras Materiales Directos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgDMD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgMD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgUltimo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUltimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbGTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblGTotal As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbIdpresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarMaestro As System.Windows.Forms.Button
    Friend WithEvents cbControl As System.Windows.Forms.ComboBox
    Friend WithEvents tbControl As System.Windows.Forms.TextBox
    Friend WithEvents cbId_produccion As System.Windows.Forms.ComboBox
    Friend WithEvents cbId_PProduccion As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgDMD As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgMD As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgUltimo2 As System.Windows.Forms.DataGridView
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatD3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgUltimo As System.Windows.Forms.DataGridView
    Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MD3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
