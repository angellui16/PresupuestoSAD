<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gva2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Presupuesto de gastos de venta y admón"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.dll_gva.My.Resources.Resources.phonebook1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(27, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(650, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Moneda:"
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(705, 156)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(54, 20)
        Me.txtMoneda.TabIndex = 55
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(653, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(705, 130)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(54, 20)
        Me.txtUsuario.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(648, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Empresa:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(704, 104)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(54, 20)
        Me.txtEmpresa.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(67, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Periodo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(66, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(80, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "ID:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.Location = New System.Drawing.Point(118, 152)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.dtpPeriodo.TabIndex = 47
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(119, 126)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 46
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(119, 100)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(54, 20)
        Me.txtId.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Location = New System.Drawing.Point(0, 468)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 83)
        Me.Panel1.TabIndex = 57
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(60, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Calcular"
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
        Me.Label23.Location = New System.Drawing.Point(740, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Eliminar"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(666, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Modificar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(596, 65)
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
        Me.btnEliminar.Location = New System.Drawing.Point(729, 4)
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
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(658, 4)
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
        Me.btnGuardar.Location = New System.Drawing.Point(588, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(58, 59)
        Me.btnGuardar.TabIndex = 28
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.BackgroundImage = Global.dll_gva.My.Resources.Resources.calculator
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Location = New System.Drawing.Point(52, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(58, 59)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'gva2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(895, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtMoneda)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gva2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gva2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
End Class
