Imports System.Windows.Forms
Public Class vcLimpiar
    Sub LimpiarCampos(ByVal control As Form)
        Dim txt As Object
        Dim txtTemporal As TextBox
        Dim cmbTemporal As ComboBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            ElseIf TypeOf txt Is ComboBox Then
                cmbTemporal = CType(txt, ComboBox)
                cmbTemporal.SelectedIndex = 0
            End If
        Next

    End Sub
End Class
