Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class vcDatos

    Public Sub sqlcombo(ByVal combobox As System.Windows.Forms.ComboBox, ByVal sql As String)
        Dim ingresarsql As String = "Data Source=RODRIGO_MIRANDA\\SQLEXPRESS;" +
            "Integrated Security=SSPI;Initial Catalog=presupuesto;"
        Dim conexion As New SqlConnection(ingresarsql)
        Try
            conexion.Open()
            Dim comand As New SqlCommand(sql, conexion)
            Dim da As New SqlDataAdapter(comand)
            Dim ds As New DataSet
            da.Fill(ds)
            combobox.DataSource = ds.Tables(0)
            combobox.DisplayMember = ds.Tables(0).Columns(1).Caption.ToString
            combobox.ValueMember = ds.Tables(0).Columns(0).Caption
        Catch ex As Exception
            MsgBox("Error")
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
    Public Sub cargarid()


    End Sub

End Class
