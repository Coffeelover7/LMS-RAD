Imports System.Data.SqlClient

Public Class SQL
    Public tablename As String
    Public cmd As String
    Public cn As New SqlConnection("Data Source=DESKTOP-UC9FRIF;Initial Catalog=crms;Integrated Security=True")
    Public sqlcmd As New SqlCommand(cmd, cn)
    Public da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
    Public ds As New DataSet("crms")
    Public n As Integer

    Public Sub filldataset()
        cn.Open()
        da.Fill(ds)
        cn.Close()
    End Sub
End Class
