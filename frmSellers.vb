Imports System.Data.SqlClient
Public Class frmSellers
    Public Shared myConn As New SqlConnection(GV.myConn)

    Private Sub loadCustomer()
        Dim Query As String
        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Seller", GetType(String))
        dt.Columns.Add("Code", GetType(String))
        Query = "SELECT * FROM tblSellers ORDER BY Seller"
        Using cmd = New SqlCommand(Query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Using dr As SqlDataReader = cmd.ExecuteReader
                dt.Load(dr)
            End Using
            myConn.Close()
        End Using
        GridControl1.DataSource = dt
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomer()
        GridView1.MoveLast()
    End Sub

    Private Sub windowsUIButtonPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
        If e.Button.Properties.Caption = "New" Then
            GridView1.AddNewRow()
        ElseIf e.Button.Properties.Caption = "Save" Then
            Dim Query As String = ""



            For x As Integer = 0 To GridView1.RowCount - 1
                GridView1.PostEditor()

                GridView1.UpdateCurrentRow()


                If Not IsDBNull(GridView1.GetRowCellValue(x, "Seller")) And Not IsDBNull(GridView1.GetRowCellValue(x, "Code")) Then
                    If IsDBNull(GridView1.GetRowCellValue(x, "ID")) Then
                        Query &= " INSERT INTO tblSellers (Seller, Code) VALUES (N'" & GridView1.GetRowCellValue(x, "Seller") & "', N'" & Val(GridView1.GetRowCellValue(x, "Code")) & "');"
                    Else
                        Query &= "UPDATE tblSellers SET Seller = N'" & GridView1.GetRowCellValue(x, "Seller") & "', Code = N'" & Val(GridView1.GetRowCellValue(x, "Code")) & "'" _
                            & " WHERE ID = " & GridView1.GetRowCellValue(x, "ID") & ";"
                    End If
                End If
            Next
            If Query = "" Then
                Exit Sub
            End If
            Using cmd = New SqlCommand(Query, myConn)
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                Try
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                Catch ex As Exception
                    MsgBox("!لم يتم الحفظ، برجاء مراجعة الأكواد")
                    myConn.Close()
                    Exit Sub
                End Try

            End Using
            loadCustomer()
            MsgBox("Saved!")

        ElseIf e.Button.Properties.Caption = "Delete" Then
            Dim DiaR As DialogResult = MessageBox.Show("هل تريد بالتأكيد حذف البائع؟", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DiaR = Windows.Forms.DialogResult.Yes Then
                Dim ID As String = GridView1.GetFocusedRowCellValue("ID")
                Dim Query As String = "DELETE FROM tblSellers WHERE ID = " & ID & ";"
                Using cmd = New SqlCommand(Query, myConn)
                    If myConn.State = ConnectionState.Closed Then
                        myConn.Open()
                    End If
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    loadCustomer()
                End Using
            End If

        End If
    End Sub


End Class