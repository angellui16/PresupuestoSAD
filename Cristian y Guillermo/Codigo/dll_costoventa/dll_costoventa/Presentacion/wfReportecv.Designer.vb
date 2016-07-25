<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfReportecv
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
        Me.crCv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crCv
        '
        Me.crCv.ActiveViewIndex = -1
        Me.crCv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crCv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crCv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crCv.Location = New System.Drawing.Point(0, 0)
        Me.crCv.Name = "crCv"
        Me.crCv.ShowGroupTreeButton = False
        Me.crCv.ShowLogo = False
        Me.crCv.Size = New System.Drawing.Size(574, 380)
        Me.crCv.TabIndex = 0
        Me.crCv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'wfReportecv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 380)
        Me.Controls.Add(Me.crCv)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wfReportecv"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte costos de venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crCv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
