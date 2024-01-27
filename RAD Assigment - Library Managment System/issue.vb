Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class issue
    Public db As New SQL
    Public isuueID As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.cn.Open()
        Dim cmd = "Select * from Student where StudentID = '" & txtStdID.Text & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Dim cmd2 = "Select * from Eligibility where StudentID = '" & txtStdID.Text & "'"
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(cmd2, db.cn)
        Dim dt2 As DataTable = New DataTable()
        da2.Fill(dt2)
        db.cn.Close()
        If (dt.Rows.Count > 0) Then
            With dt.Rows(0)
                txtStdName.Text = .Item("StudentName")
                txtStdAge.Text = .Item("StudentAge")
                txtStdCon.Text = .Item("StudentContact")
                txtStdAddress.Text = .Item("StudentAddress")
                txtStdDept.Text = .Item("StudentDepartment")
                txtStdCourse.Text = .Item("StudentCourse")
                txtSdtYear.Text = .Item("StudnetYear")
                If (dt2.Rows.Count > 0) Then
                    With dt2.Rows(0)
                        If .Item("StudentEligibility") = "True" Or .Item("StudentEligibility") = "" Then
                            txtEligibility.Text = "Yes"
                            GroupBox2.Enabled = True
                        Else
                            txtEligibility.Text = "No"
                            GroupBox2.Enabled = False
                        End If
                    End With
                End If
            End With
        Else
            MsgBox("No Records Found...")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        db.cn.Open()
        Dim cmd = "Select * from Books where BookID = '" & txtBookID.Text & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        db.cn.Close()
        If (dt.Rows.Count > 0) Then
            With dt.Rows(0)
                txtBookName.Text = .Item("BookName")
                txtBookAuthor.Text = .Item("BookAuthor")
                txtBookCategory.Text = .Item("BookCategory")
                txtBookPrice.Text = .Item("BookPrice")
            End With
        Else
            MsgBox("No Records Found...")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim today As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        If GroupBox1.Enabled = "True" And GroupBox2.Enabled = "True" Then
            db.cn.Open()
            Try
                Dim genstid = "Select nextIssueID=MAX(IssueID)+1 From Issue"
                Dim com = New SqlCommand(genstid, db.cn)
                Dim Dr = com.ExecuteReader()
                If Dr.Read() Then
                    isuueID = Dr.GetValue(0).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            db.cn.Close()
            db.cn.Open()
            Dim cmd = "Insert into Issue (IssueID,StudentID,StudentName,BookID,BookName,IssuedDate) values('" & isuueID & "','" & txtStdID.Text & "','" & txtStdName.Text & "','" & txtBookID.Text & "','" & txtBookName.Text & "','" & today & "')"
            Dim sqlcmd As SqlCommand = New SqlCommand(cmd, db.cn)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Record Successfully Added",, "Sucess")
            clear()
            Dim scmd = "select * from Eligibility where StudentID = '" & txtStdID.Text & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(scmd, db.cn)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Dim cmd1 = "update Eligibility set StudentEligibility = 'False' where StudentID = '" & txtStdID.Text & "'"
            Else
                Dim cmd1 = "Insert into Eligibility (StudentID,StudentEligibility) values('" & txtStdID.Text & "','False')"
            End If
            Dim sqlcmd1 As SqlCommand = New SqlCommand(cmd, db.cn)
            Try
                sqlcmd1.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            db.cn.Close()
        Else
            MsgBox("Missing Information",, "Error")
        End If
    End Sub

    Private Sub clear()
        txtStdName.Text = ""
        txtStdAge.Text = ""
        txtStdCon.Text = ""
        txtStdAddress.Text = ""
        txtStdDept.Text = ""
        txtStdCourse.Text = ""
        txtSdtYear.Text = ""
        txtBookName.Text = ""
        txtBookAuthor.Text = ""
        txtBookCategory.Text = ""
        txtBookPrice.Text = ""
        txtStdID.Text = ""
        txtBookID.Text = ""
        txtBookID.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class