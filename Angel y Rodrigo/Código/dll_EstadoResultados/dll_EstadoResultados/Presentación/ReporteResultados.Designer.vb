﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteResultados
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
        Me.crResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crResultados
        '
        Me.crResultados.ActiveViewIndex = -1
        Me.crResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crResultados.Cursor = System.Windows.Forms.Cursors.Default
        Me.crResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crResultados.Location = New System.Drawing.Point(0, 0)
        Me.crResultados.Name = "crResultados"
        Me.crResultados.ShowLogo = False
        Me.crResultados.Size = New System.Drawing.Size(675, 431)
        Me.crResultados.TabIndex = 0
        Me.crResultados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 431)
        Me.Controls.Add(Me.crResultados)
        Me.Name = "ReporteResultados"
        Me.Text = "Estados de resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
