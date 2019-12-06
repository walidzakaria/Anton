Imports System.Data.SqlClient
Public Class ExTools
    Public Shared Sub ShrinkDB(ByVal DatabaseName As String, ByVal Conn As SqlConnection)
        Dim Query As String = "BEGIN TRY" _
                              & " 	DBCC SHRINKDATABASE ('" & DatabaseName & "')" _
                              & " END TRY" _
                              & " BEGIN CATCH" _
                              & " END CATCH"
        Using cmd = New SqlCommand(Query, Conn)
            Try
                If Conn.State = ConnectionState.Closed Then
                    Conn.Open()
                End If
                cmd.ExecuteNonQuery()
                Conn.Close()
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Public Shared Function Backup(ByVal Path As String, ByVal databaseName As String, ByVal conn As SqlConnection) As String
        Dim Result As String = ""

        Dim Query As String = "BACKUP DATABASE " & databaseName _
                              & " TO DISK = '" & Path & "'" _
                              & "    WITH FORMAT," _
                              & "       MEDIANAME = '" & databaseName & "'," _
                              & "       NAME = 'Full Backup of " & databaseName & "';"
        Using cmd = New SqlCommand(Query, conn)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Try
                cmd.ExecuteNonQuery()
                Result = "Backup done successfully!"
            Catch ex As Exception
                Result = ex.ToString
            End Try
            conn.Close()
        End Using

        Return Result
    End Function

End Class
