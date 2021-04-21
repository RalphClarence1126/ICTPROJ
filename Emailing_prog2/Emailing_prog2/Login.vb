Public Class login_Mail
    ' Declare user login credentials
    Public user_Email As String
    Public user_Password As String

    Private Sub login_Email_TextChanged(sender As Object, e As EventArgs) Handles login_Email.TextChanged
        ' Check user email if correct
        ' Currently supports gmail as it is widely used
        If login_Email.Text.Contains("@gmail.com") Then
            login_Password.Enabled = True ' Enable password textbox
        Else
            login_Password.Enabled = False ' Disable password textbox
        End If
    End Sub

    Private Sub login_Password_TextChanged(sender As Object, e As EventArgs) Handles login_Password.TextChanged
        'Check password textbox if not null
        If String.IsNullOrWhiteSpace(login_Password.Text) = False Then
            login_Button.Enabled = True ' Enable login button
        Else
            login_Button.Enabled = False ' Disable login button
        End If
    End Sub

    Private Sub login_Button_Click(sender As Object, e As EventArgs) Handles login_Button.Click
        ' Set email in variable
        user_Email = login_Email.Text

        ' Set password in variable
        user_Password = login_Password.Text

        ' Proceed to email composition
        body_Mail.Show()
        Me.Close()
    End Sub
End Class