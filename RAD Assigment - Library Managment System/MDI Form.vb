Public Class MDI_Form
    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        issue.Show()
    End Sub

    Private Sub RetrunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrunToolStripMenuItem.Click
        bookreturn.Show()
    End Sub

    Private Sub SearchBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBookToolStripMenuItem.Click
        Searchbook.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Student.Show()
    End Sub

    Private Sub RegistationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistationToolStripMenuItem.Click
        Registation.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
    End Sub
End Class