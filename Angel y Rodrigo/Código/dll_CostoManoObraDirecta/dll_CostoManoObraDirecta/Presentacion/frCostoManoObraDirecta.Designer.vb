<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frCostoManoObraDirecta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frCostoManoObraDirecta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgCManoObra = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgCDMO = New System.Windows.Forms.DataGridView()
        Me.tbGTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbIdpresupuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.tbControl = New System.Windows.Forms.TextBox()
        Me.cbControl = New System.Windows.Forms.ComboBox()
        Me.cbId_PProduccion = New System.Windows.Forms.ComboBox()
        Me.cbId_produccion = New System.Windows.Forms.ComboBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFilas = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnTransf = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardarMaestro = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgUltimo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUltimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgCManoObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgCDMO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(14, 145)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(702, 430)
        Me.TabControl1.TabIndex = 102
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.dgUltimo2)
        Me.TabPage1.Controls.Add(Me.dgUltimo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle Mano de Obra"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgUltimo2
        '
        Me.dgUltimo2.AllowUserToAddRows = False
        Me.dgUltimo2.AllowUserToDeleteRows = False
        Me.dgUltimo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUltimo2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.MatD1, Me.MatD2, Me.MatD3})
        Me.dgUltimo2.Location = New System.Drawing.Point(6, 282)
        Me.dgUltimo2.Name = "dgUltimo2"
        Me.dgUltimo2.Size = New System.Drawing.Size(683, 112)
        Me.dgUltimo2.TabIndex = 12
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
        Me.dgUltimo.Location = New System.Drawing.Point(6, 11)
        Me.dgUltimo.Name = "dgUltimo"
        Me.dgUltimo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUltimo.Size = New System.Drawing.Size(683, 265)
        Me.dgUltimo.TabIndex = 11
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgCManoObra)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 404)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta Costo Mano de Obra"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgCManoObra
        '
        Me.dgCManoObra.AllowUserToDeleteRows = False
        Me.dgCManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCManoObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCManoObra.Location = New System.Drawing.Point(3, 3)
        Me.dgCManoObra.Name = "dgCManoObra"
        Me.dgCManoObra.Size = New System.Drawing.Size(688, 398)
        Me.dgCManoObra.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgCDMO)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(694, 404)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Consulta Det. Mano Obra"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgCDMO
        '
        Me.dgCDMO.AllowUserToDeleteRows = False
        Me.dgCDMO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCDMO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCDMO.Location = New System.Drawing.Point(0, 0)
        Me.dgCDMO.Name = "dgCDMO"
        Me.dgCDMO.Size = New System.Drawing.Size(694, 404)
        Me.dgCDMO.TabIndex = 0
        '
        'tbGTotal
        '
        Me.tbGTotal.Enabled = False
        Me.tbGTotal.Location = New System.Drawing.Point(117, 590)
        Me.tbGTotal.Name = "tbGTotal"
        Me.tbGTotal.ReadOnly = True
        Me.tbGTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbGTotal.TabIndex = 91
        Me.tbGTotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 593)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Gran total MOD"
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(308, 121)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(49, 13)
        Me.lblMoneda.TabIndex = 100
        Me.lblMoneda.Text = "Moneda:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(308, 94)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 99
        Me.lblUsuario.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(308, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Id empresa:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy/MM/dd"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodo.Location = New System.Drawing.Point(112, 115)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(100, 20)
        Me.dtpPeriodo.TabIndex = 2
        Me.dtpPeriodo.Value = New Date(2016, 7, 6, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Fecha:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(112, 87)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(185, 20)
        Me.tbNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Nombre:"
        '
        'tbIdpresupuesto
        '
        Me.tbIdpresupuesto.Enabled = False
        Me.tbIdpresupuesto.Location = New System.Drawing.Point(112, 61)
        Me.tbIdpresupuesto.Name = "tbIdpresupuesto"
        Me.tbIdpresupuesto.ReadOnly = True
        Me.tbIdpresupuesto.Size = New System.Drawing.Size(100, 20)
        Me.tbIdpresupuesto.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Id presupuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 25)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Módulo Costo de Mano de Obra"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnTransf)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnGuardarMaestro)
        Me.Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 83)
        Me.Panel1.TabIndex = 92
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(474, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Guardar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Transferencia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(678, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Salir"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(95, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Reporte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(607, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Eliminar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(535, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Modificar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(355, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Limpiar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Detalle"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(384, 65)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(107, 21)
        Me.cbEmpresa.TabIndex = 3
        '
        'cbUsuario
        '
        Me.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(384, 91)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(107, 21)
        Me.cbUsuario.TabIndex = 4
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(384, 118)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(107, 21)
        Me.cbMoneda.TabIndex = 5
        '
        'tbControl
        '
        Me.tbControl.Enabled = False
        Me.tbControl.Location = New System.Drawing.Point(664, 586)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.Size = New System.Drawing.Size(41, 20)
        Me.tbControl.TabIndex = 106
        '
        'cbControl
        '
        Me.cbControl.Enabled = False
        Me.cbControl.FormattingEnabled = True
        Me.cbControl.Location = New System.Drawing.Point(665, 586)
        Me.cbControl.Name = "cbControl"
        Me.cbControl.Size = New System.Drawing.Size(40, 21)
        Me.cbControl.TabIndex = 107
        '
        'cbId_PProduccion
        '
        Me.cbId_PProduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbId_PProduccion.FormattingEnabled = True
        Me.cbId_PProduccion.Location = New System.Drawing.Point(621, 86)
        Me.cbId_PProduccion.Name = "cbId_PProduccion"
        Me.cbId_PProduccion.Size = New System.Drawing.Size(87, 21)
        Me.cbId_PProduccion.TabIndex = 7
        '
        'cbId_produccion
        '
        Me.cbId_produccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbId_produccion.FormattingEnabled = True
        Me.cbId_produccion.Location = New System.Drawing.Point(621, 59)
        Me.cbId_produccion.Name = "cbId_produccion"
        Me.cbId_produccion.Size = New System.Drawing.Size(87, 21)
        Me.cbId_produccion.TabIndex = 6
        '
        'btnCrear
        '
        Me.btnCrear.Enabled = False
        Me.btnCrear.Location = New System.Drawing.Point(625, 138)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(61, 27)
        Me.btnCrear.TabIndex = 10
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(511, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "No. Productos"
        '
        'txtFilas
        '
        Me.txtFilas.Location = New System.Drawing.Point(621, 109)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(87, 20)
        Me.txtFilas.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(509, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 15)
        Me.Label25.TabIndex = 134
        Me.Label25.Text = "Id Pres. Producción"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(509, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 15)
        Me.Label24.TabIndex = 133
        Me.Label24.Text = "Id Producción"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.calculator
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(19, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 94
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.Floppy_disk_512
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(469, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnTransf
        '
        Me.btnTransf.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.outside
        Me.btnTransf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransf.FlatAppearance.BorderSize = 0
        Me.btnTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransf.Location = New System.Drawing.Point(12, 10)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(65, 55)
        Me.btnTransf.TabIndex = 14
        Me.btnTransf.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.print_icon
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Location = New System.Drawing.Point(83, 10)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(65, 55)
        Me.btnReporte.TabIndex = 15
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.inside
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(661, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 59)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.close2
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(597, 6)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(58, 59)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.pen
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(533, 8)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(58, 59)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.substract
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(342, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(58, 59)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardarMaestro
        '
        Me.btnGuardarMaestro.BackgroundImage = Global.dll_CostoManoObraDirecta.My.Resources.Resources.download
        Me.btnGuardarMaestro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarMaestro.FlatAppearance.BorderSize = 0
        Me.btnGuardarMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMaestro.Location = New System.Drawing.Point(405, 8)
        Me.btnGuardarMaestro.Name = "btnGuardarMaestro"
        Me.btnGuardarMaestro.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardarMaestro.TabIndex = 8
        Me.btnGuardarMaestro.UseVisualStyleBackColor = True
        '
        'frCostoManoObraDirecta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbId_PProduccion)
        Me.Controls.Add(Me.cbId_produccion)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFilas)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbControl)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tbGTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbIdpresupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frCostoManoObraDirecta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Costo Mano Obra Directa"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgUltimo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUltimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgCManoObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgCDMO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbGTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbIdpresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardarMaestro As System.Windows.Forms.Button
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents dgCManoObra As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCDMO As System.Windows.Forms.DataGridView
    Friend WithEvents tbControl As System.Windows.Forms.TextBox
    Friend WithEvents cbControl As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
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
    Friend WithEvents cbId_PProduccion As System.Windows.Forms.ComboBox
    Friend WithEvents cbId_produccion As System.Windows.Forms.ComboBox
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
