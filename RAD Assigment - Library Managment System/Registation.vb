Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Registation
    Public db As New SQL
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.tablename = "Student"
        db.cn.Open()
        Try
            Dim genstid = "Select nextStudentID=MAX(StudentID)+1 From Student"
            Dim com = New SqlCommand(genstid, db.cn)
            Dim Dr = com.ExecuteReader()
            If Dr.Read() Then
                txtStdID.Text = Dr.GetValue(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        db.cn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtStdID.Text = "" Or txtStdName.Text = "" Or txtStdAge.Text = "" Or txtStdCon.Text = "" Or txtStdAdd.Text = "" Or txtStdDept.Text = "" Or txtStdCourse.Text = "" Or txtStdYear.Text = "" Then
            MsgBox("Missing Information",, "Error")
        Else
            db.cn.Open()
            Dim cmd = "Insert into Student (StudentID,StudentName,StudentAge,StudentContact,StudentAddress,StudentDepartment,StudentCourse,StudnetYear) values('" & txtStdID.Text & "','" & txtStdName.Text & "','" & txtStdAge.Text & "','" & txtStdCon.Text & "','" & txtStdAdd.Text & "','" & txtStdDept.Text & "','" & txtStdCourse.Text & "','" & txtStdYear.Text & "')"
            Dim sqlcmd As SqlCommand = New SqlCommand(cmd, db.cn)
            Try
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            db.cn.Close()
            db.cn.Open()
            Dim cmd1 = "Insert into Eligibility (StudentID,StudentEligibility) values('" & txtStdID.Text & "','True')"
            Dim sqlcmd1 As SqlCommand = New SqlCommand(cmd1, db.cn)
            sqlcmd1.ExecuteNonQuery()
            db.cn.Close()
            MsgBox("Record Successfully Added",, "Sucess")
            txtStdID.Text = txtStdID.Text + 1
            clear()
        End If
    End Sub
    Private Sub clear()
        txtStdName.Text = ""
        txtStdAge.Text = ""
        txtStdCon.Text = ""
        txtStdAdd.Text = ""
        txtStdDept.Text = ""
        txtStdCourse.Text = ""
        txtStdYear.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class