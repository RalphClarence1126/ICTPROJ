Public Class Form1
    'Opens Form_2'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_Mail.Show()
    End Sub

    'Close the program'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
