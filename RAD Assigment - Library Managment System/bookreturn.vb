Imports System.Data.SqlClient
Imports System.Net

Public Class bookreturn
    Public db As New SQL
    Dim BKID, isuueID As String
    Private Sub bookreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        txtStatus.Text = ""
        txtIssueDate.Text = ""
        cmbBook.Enabled = False
        GroupBox2.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.cn.Open()
        Dim cmd = "Select * from Student where StudentID = '" & txtStdID.Text & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
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
            End With
            GroupBox2.Enabled = True
            cmbBook.Enabled = True
        Else
            MsgBox("No Records Found...")
        End If
        db.cn.Open()
        Dim cmd2 = "Select * from Issue where StudentID = '" & txtStdID.Text & "'"
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(cmd2, db.cn)
        Dim dt2 As DataTable = New DataTable()
        da2.Fill(dt2)
        cmbBook.DataSource = dt2
        cmbBook.DisplayMember = "BookName"
        cmbBook.ValueMember = "IssueID"
        db.cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BookID As String
        db.cn.Open()
        Dim cmd2 = "Select * from Issue where IssueID = '" & cmbBook.SelectedValue & "'"
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(cmd2, db.cn)
        Dim dt2 As DataTable = New DataTable()
        da2.Fill(dt2)
        With dt2.Rows(0)
            BookID = .Item("BookID")
            txtIssueDate.Text = .Item("IssuedDate")
            isuueID = .Item("IssueID")
        End With
        Dim cmd = "Select * from Books where BookID = '" & BookID & "'"
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
        Dim today As DateTime = DateTime.Now
        Dim span As TimeSpan = today.Subtract(txtIssueDate.Text)
        If span.Days <= 14 Then
            txtStatus.Text = "No Fine"
        ElseIf span.Days <= 21 Then
            txtStatus.Text = "Fine is Rs.50"
        ElseIf span.Days <= 30 Then
            txtStatus.Text = "Fine is Rs.100"
        ElseIf span.Days > 30 Then
            txtStatus.Text = "Fine is Rs.100 + " & txtBookPrice.Text
        End If
        BKID = BookID
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim today As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        Dim returnID As String
        If GroupBox1.Enabled = "True" And GroupBox2.Enabled = "True" Then
            db.cn.Open()
            Try
                Dim genstid = "Select nextReturnID=MAX(ReturnID)+1 From [Return]"
                Dim com = New SqlCommand(genstid, db.cn)
                Dim Dr = com.ExecuteReader()
                If Dr.Read() Then
                    returnID = Dr.GetValue(0).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            db.cn.Close()
            db.cn.Open()
            Dim cmd = "Insert into [Return] (ReturnID,IssueID,StudentID,StudentName,BookID,BookName,IssuedDate,ReturnDate,Fine) values('" & returnID & "','" & isuueID & "','" & txtStdID.Text & "','" & txtStdName.Text & "','" & BKID & "','" & txtBookName.Text & "','" & txtIssueDate.Text & "','" & today & "','" & txtStatus.Text & "')"
            Dim sqlcmd As SqlCommand = New SqlCommand(cmd, db.cn)
            sqlcmd.ExecuteNonQuery()
            Dim cmd2 = "Delete from Issue where IssueID = '" & isuueID & "'"
            Dim sqlcmd2 As SqlCommand = New SqlCommand(cmd2, db.cn)
            sqlcmd2.ExecuteNonQuery()
            MsgBox("Record Successfully Added",, "Sucess")
            clear()
            Dim scmd = "select * from Eligibility where StudentID = '" & txtStdID.Text & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(scmd, db.cn)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Dim cmd1 = "update Eligibility set StudentEligibility = 'True' where StudentID = '" & txtStdID.Text & "'"
            Else
                Dim cmd1 = "Insert into Eligibility (StudentID,StudentEligibility) values('" & txtStdID.Text & "','True')"
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
End Class