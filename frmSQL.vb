Imports System.Data.SqlClient
Public Class frmSQL
    Dim myConn As New SqlConnection(GV.myConn)
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Using cmd = New SqlCommand(TextBox1.Text, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Done!")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            myConn.Close()
        End Using

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmLayout.Show()
    End Sub
End Class