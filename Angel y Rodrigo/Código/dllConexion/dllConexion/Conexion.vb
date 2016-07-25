'*****************************************************************************************
'NOMBRE: DLL_CONEXION
'FECHA: 03/07/16
'CREADOR: ANGEL TOBAR
'DESCRIPCIÓN: CONEXION A BASE DE DATOS
'DETALLE: REALIZA CONEXION Y CONTIENE FUNCIONES PARA INSERTAR, MODIFICAR Y ELIMINAR
'MODIFICACIÓN: 20/07/16
'*****************************************************************************************
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Conexion

    Public Shared con As New SqlConnection
    Public Shared cmb As SqlCommandBuilder
    Public Shared ds As DataSet = New DataSet()
    Public Shared da As SqlDataAdapter
    Public shared comando As SqlCommand

    Public Shared Function Conectado()
        Try
            con = New SqlConnection(My.Settings.Conexion)
            con.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function Desconectado()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, con)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Function
    Public Shared Function Insertar(ByVal sql)
        Conectado()
        comando = New SqlCommand(sql, con)
        Dim i As Integer = comando.ExecuteNonQuery()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function Eliminar(ByVal tabla, ByVal condicion)
        Conectado()
        Dim elimina As String = "delete from  " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, con)
        Dim i As Integer = comando.ExecuteNonQuery()
        Desconectado()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function Modificar(ByVal tabla, ByVal campos, ByVal condicion)
        Conectado()
        Dim modifica As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modifica, con)
        Dim i As Integer = comando.ExecuteNonQuery()
        Desconectado()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
