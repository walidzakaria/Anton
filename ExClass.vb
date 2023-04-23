Imports System.IO.Ports
Imports System.Data.SqlClient

Public Class ExClass
    Public Shared myConn As New SqlConnection(GV.myConn)
    Public Shared Sub PoleDisplay(ByVal Text As String)
        Dim sp As New SerialPort("COM1", 9600, Parity.Even)
        If sp.IsOpen = False Then
            sp.Open()
        End If
        'to clear the previous display
        sp.Write("")

        'first line
        sp.WriteLine(Text)
        sp.Close()
        sp.Dispose()
        sp = Nothing

    End Sub

    Public Shared Function validAccess() As Boolean
        Dim result As Boolean = False
        frmValidate.ShowDialog()
        If frmValidate.DialogResult = DialogResult.OK Then
            result = True
        End If
        Return result
    End Function

    Public Shared Function GetPercentage(ByVal Number As Single, ByVal Discount As Single) As Single
        Dim result As Single
        Discount = 100 - Discount
        Discount = Discount / 100
        result = Number * Discount
        result = Number - result

        Return result
    End Function

    Public Shared Function GetData(ByVal query As String) As DataTable
        Dim adt As New SqlDataAdapter
        Dim ds As New DataSet()
        Using cmd = New SqlCommand(query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            adt.SelectCommand = cmd
            adt.Fill(ds)
            adt.Dispose()

            myConn.Close()
        End Using

        Return ds.Tables(0)
    End Function

    Public Shared Function SetData(ByVal query As String) As Boolean
        Dim result As Boolean = False
        Using cmd = New SqlCommand(query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Try
                cmd.ExecuteNonQuery()
                result = True
            Catch ex As Exception
                result = False
            End Try

            myConn.Close()
        End Using

        Return result
    End Function

    Public Shared Sub Wait(ByVal wait As Boolean)
        If wait = True Then
            Try
                frmForWaiting.SplashScreenManager1.ShowWaitForm()
            Catch ex As Exception

            End Try
        Else
            Try
                frmForWaiting.SplashScreenManager1.CloseWaitForm()
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
