Imports System.Windows.Forms

Public Class wfCuentasIndirectas

    Private sId As String
    Private sCuenta As String

    Public Property SId1 As String
        Get
            Return sId
        End Get
        Set(value As String)
            Me.sId = value
        End Set
    End Property

    Public Property SCuenta1 As String
        Get
            Return sCuenta
        End Get
        Set(value As String)
            sCuenta = value
        End Set
    End Property

    Private Sub wfCuentasIndirectas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenando el grid de cuentas
        Me.dgvCuentas.Rows.Add()
        Me.dgvCuentas.Rows.Add()
        Me.dgvCuentas.Rows.Add()
        Me.dgvCuentas.Rows.Add()
        Me.dgvCuentas.Rows.Add()
        Me.dgvCuentas.Rows.Add()


        Me.dgvCuentas.Rows(0).Cells(0).Value = "1"
        Me.dgvCuentas.Rows(0).Cells(1).Value = "Sueldos"

        Me.dgvCuentas.Rows(1).Cells(0).Value = "2"
        Me.dgvCuentas.Rows(1).Cells(1).Value = "Energia"

        Me.dgvCuentas.Rows(2).Cells(0).Value = "3"
        Me.dgvCuentas.Rows(2).Cells(1).Value = "Agua"

        Me.dgvCuentas.Rows(3).Cells(0).Value = "4"
        Me.dgvCuentas.Rows(3).Cells(1).Value = "Depreciaciónes"

        Me.dgvCuentas.Rows(4).Cells(0).Value = "5"
        Me.dgvCuentas.Rows(4).Cells(1).Value = "Materiales"

        Me.dgvCuentas.Rows(5).Cells(0).Value = "6"
        Me.dgvCuentas.Rows(5).Cells(1).Value = "Mantenimiento"

        Me.dgvCuentas.Rows(6).Cells(0).Value = "7"
        Me.dgvCuentas.Rows(6).Cells(1).Value = "Seguros"


    End Sub

    Private Sub dgvCuentas_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellContentClick



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ''MessageBox.Show(Me.SCuenta1)
        Me.Close()
    End Sub

    Private Sub dgvCuentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCuentas.CellMouseClick
        Try
            Dim principal As New wfImporteCostosIndirectos

            Dim importe As New wfImporteCostosIndirectos
            Dim Index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvCuentas.Rows(Index)
            Me.sCuenta = selectedRow.Cells(1).Value.ToString()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("El valor seleccionado es invalido")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MessageBox.Show(Me.SCuenta1)
    End Sub
End Class