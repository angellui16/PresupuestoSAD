<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frReporteMO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frReporteMO))
        Me.crManoObra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crManoObra
        '
        Me.crManoObra.ActiveViewIndex = -1
        Me.crManoObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crManoObra.Cursor = System.Windows.Forms.Cursors.Default
        Me.crManoObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crManoObra.Location = New System.Drawing.Point(0, 0)
        Me.crManoObra.Name = "crManoObra"
        Me.crManoObra.Size = New System.Drawing.Size(284, 261)
        Me.crManoObra.TabIndex = 0
        '
        'frReporteMO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.crManoObra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frReporteMO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Costo de Mano Obra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crManoObra As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
