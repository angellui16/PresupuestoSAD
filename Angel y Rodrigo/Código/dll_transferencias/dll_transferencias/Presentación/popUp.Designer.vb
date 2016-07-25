<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class popUp
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(120, 93)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha inicial"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(39, 93)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 9
        Me.btnGenerar.Text = "&Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha final"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(65, 26)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(104, 20)
        Me.dtFecha.TabIndex = 13
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(65, 65)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(104, 20)
        Me.dtFecha2.TabIndex = 14
        '
        'popUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(231, 126)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "popUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFecha2 As System.Windows.Forms.DateTimePicker
End Class
