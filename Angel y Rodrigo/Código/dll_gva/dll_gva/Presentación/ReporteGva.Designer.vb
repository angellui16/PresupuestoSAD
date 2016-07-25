<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteGva
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
        Me.crGva = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crGva
        '
        Me.crGva.ActiveViewIndex = -1
        Me.crGva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crGva.Cursor = System.Windows.Forms.Cursors.Default
        Me.crGva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crGva.Location = New System.Drawing.Point(0, 0)
        Me.crGva.Name = "crGva"
        Me.crGva.ShowLogo = False
        Me.crGva.Size = New System.Drawing.Size(625, 372)
        Me.crGva.TabIndex = 0
        Me.crGva.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteGva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 372)
        Me.Controls.Add(Me.crGva)
        Me.Name = "ReporteGva"
        Me.Text = "Reportes Gastos de venta y administración"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crGva As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
