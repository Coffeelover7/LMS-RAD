Imports System.Windows
Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cn As New SqlConnection("Data Source=DESKTOP-UC9FRIF;Initial Catalog=crms;Integrated Security=True")
        Dim cmd As New SqlCommand("Select * from User where UserName = '" + txtUsername.Text + "'and UserPassword='" + txtPassword.Text + "'", cn)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login SuceessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            MDI_Form.Show()
        Else
            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
