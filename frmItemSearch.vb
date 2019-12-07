Imports System.Data.SqlClient

Public Class frmItemSearch
    Public Shared myConn As New SqlConnection(GV.myConn)
    Public Shared SearchedItem As String = ""
    Private Sub FillItems()


        Dim dt As New DataTable
        Dim query As String

        query = "SELECT item.PrKey, item.Serial, item.Name, item.Price" _
            & " FROM tblItems item" _
            & " UNION" _
            & " SELECT item.PrKey, mcode.Code AS Serial, item.Name, item.Price" _
            & " FROM tblItems item" _
            & " JOIN tblMultiCodes mcode ON item.PrKey = mcode.Item" _
            & " ORDER BY Name, Serial;"

        Using cmd = New SqlCommand(query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Using dr As SqlDataReader = cmd.ExecuteReader
                dt.Load(dr)
            End Using
            myConn.Close()
        End Using


        GridControl1.DataSource = Nothing
        GridControl1.DataSource = dt


    End Sub

    Private Sub frmItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillItems()
    End Sub

    Private Sub frmItemSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SearchControl1.Focus()

    End Sub

    Private Sub SearchControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchControl1.KeyDown
        If e.KeyCode = Keys.Down Then
            GridView1.MoveNext()
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.MovePrev()
            e.Handled = True
        ElseIf e.KeyCode = Keys.Enter Then
            Try
                Dim code As String
                code = GridView1.GetFocusedRowCellValue("Serial")
                SearchedItem = code
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                SearchedItem = ""
            End Try
        ElseIf e.KeyCode = Keys.Escape Then
            If SearchControl1.Text = "" Then
                SearchedItem = ""
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                SearchControl1.Text = ""
                SearchedItem = ""
            End If
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim code As String
            code = GridView1.GetFocusedRowCellValue("Serial")
            SearchedItem = code
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            SearchedItem = ""
        End Try
    End Sub
End Class