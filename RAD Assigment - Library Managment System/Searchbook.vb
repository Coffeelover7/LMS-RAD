Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Searchbook
    Public db As New SQL
    Private Sub DisplayBooks()
        db.cn.Open()
        Dim cmd = "Select * from Books"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        db.cn.Close()
    End Sub
    Private Sub Booksearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.tablename = "Books"
        DisplayBooks()
    End Sub

    Private Sub txtBookSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBookSearch.TextChanged
        db.cn.Open()
        Dim cmd = "Select * from Books where BookID like '%" & txtBookSearch.Text & "%' or BookName like '%" & txtBookSearch.Text & "%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd, db.cn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
        Else
            MsgBox("No Record Found!")
        End If

        db.cn.Close()
    End Sub
End Class