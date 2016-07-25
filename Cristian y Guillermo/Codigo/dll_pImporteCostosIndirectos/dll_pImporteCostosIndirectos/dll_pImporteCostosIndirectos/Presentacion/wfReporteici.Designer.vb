<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfReporteici
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
        Me.crIci = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crIci
        '
        Me.crIci.ActiveViewIndex = -1
        Me.crIci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crIci.Cursor = System.Windows.Forms.Cursors.Default
        Me.crIci.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crIci.Location = New System.Drawing.Point(0, 0)
        Me.crIci.Name = "crIci"
        Me.crIci.ShowGroupTreeButton = False
        Me.crIci.ShowLogo = False
        Me.crIci.Size = New System.Drawing.Size(651, 385)
        Me.crIci.TabIndex = 0
        Me.crIci.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'wfReporteici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 385)
        Me.Controls.Add(Me.crIci)
        Me.Name = "wfReporteici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte importe de costos indirectos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crIci As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
