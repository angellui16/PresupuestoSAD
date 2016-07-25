<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteTransferencia
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
        Me.crTransferencia = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crTransferencia
        '
        Me.crTransferencia.ActiveViewIndex = -1
        Me.crTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crTransferencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.crTransferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crTransferencia.Location = New System.Drawing.Point(0, 0)
        Me.crTransferencia.Name = "crTransferencia"
        Me.crTransferencia.ShowLogo = False
        Me.crTransferencia.Size = New System.Drawing.Size(284, 261)
        Me.crTransferencia.TabIndex = 0
        Me.crTransferencia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.crTransferencia)
        Me.Name = "ReporteTransferencia"
        Me.Text = "Reportes Transferencias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crTransferencia As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
