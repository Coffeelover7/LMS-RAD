Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Student
    Public db As New SQL
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.tablename = "Student"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.cn.Open()
        Dim cmd = "Select * from Student where StudentID = '" & txtSearch.Text & "' or StudentName = '" & txtSearch.Text & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        db.cn.Close()
        If (dt.Rows.Count > 0) Then
            With dt.Rows(0)
                txtStdID.Text = .Item("StudentID")
                txtStdName.Text = .Item("StudentName")
                txtStdAge.Text = .Item("StudentAge")
                txtStudCon.Text = .Item("StudentContact")
                txtStdAddress.Text = .Item("StudentAddress")
                txtDep.Text = .Item("StudentDepartment")
                txtCourse.Text = .Item("StudentCourse")
                txtYear.Text = .Item("StudnetYear")
            End With
            txtStdName.Enabled = True
            txtStdAge.Enabled = True
            txtStudCon.Enabled = True
            txtStdAddress.Enabled = True
            txtDep.Enabled = True
            txtCourse.Enabled = True
            txtYear.Enabled = True
        Else
            MessageBox.Show("The ID or Name of Student is Doesnot Exsits.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtStdID.Text = "" Or txtStdName.Text = "" Or txtStdAge.Text = "" Or txtStudCon.Text = "" Or txtStdAddress.Text = "" Or txtDep.Text = "" Or txtCourse.Text = "" Or txtYear.Text = "" Then
            MessageBox.Show("Missing Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            db.cn.Open()
            Dim cmd = "update Student set StudentID = '" & txtStdID.Text & "',StudentName = '" & txtStdName.Text & "',StudentAge = '" & txtStdAge.Text & "',StudentContact = '" & txtStudCon.Text & "',StudentAddress = '" & txtStdAddress.Text & "',StudentDepartment = '" & txtDep.Text & "',StudentCourse = '" & txtCourse.Text & "',StudnetYear = '" & txtYear.Text & "' where StudentID = '" & txtStdID.Text & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(cmd, db.cn)
            sqlcmd.ExecuteNonQuery()
            db.cn.Close()
            MsgBox("Record Successfully Updated",, "Sucess")
            clear()
        End If
    End Sub

    Private Sub clear()
        txtStdID.Text = ""
        txtStdName.Text = ""
        txtStdAge.Text = ""
        txtStudCon.Text = ""
        txtStdAddress.Text = ""
        txtDep.Text = ""
        txtCourse.Text = ""
        txtYear.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtStdID.Text = "" Then
            MsgBox("Please Select Record to Delete")
        Else
            db.cn.Open()
            Dim cmd = "Delete from Student where StudentID = '" & txtStdID.Text & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(cmd, db.cn)
            sqlcmd.ExecuteNonQuery()
            db.cn.Close()
            db.cn.Open()
            Dim cmd1 = "Delete from Eligibility where StudentID = '" & txtStdID.Text & "'"
            Dim sqlcmd1 As SqlCommand = New SqlCommand(cmd1, db.cn)
            sqlcmd1.ExecuteNonQuery()
            db.cn.Close()
            MsgBox("Record Delete Successfully",, "Sucess")
            clear()
        End If
    End Sub
End Class