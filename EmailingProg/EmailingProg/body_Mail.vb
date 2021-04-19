Imports System.Net.Mail

Public Class body_Mail
    ' Declare login credentials
    ReadOnly body_userEmail As String = login_Mail.user_Email
    ReadOnly body_userPassword As String = login_Mail.user_Password

    ' Declare mail variiables
    Dim bodyVar_Recipient As String
    Dim bodyVar_Subject As String
    Dim bodyVar_Body As String

    Private Sub body_Recipient_TextChanged(sender As Object, e As EventArgs) Handles body_Recipient.TextChanged
        ' Check recipient email if correct
        ' Currently supports gmail as it is widely used
        If body_Recipient.Text.Contains("@gmail.com") Then
            bodyVar_Recipient = body_Recipient.Text
            body_Subject.Enabled = True ' Enable subject textbox
            body_Body.Enabled = True ' Enable body textbox
        Else
            body_Subject.Enabled = False ' Disable subject textbox
            body_Body.Enabled = False ' Disable body textbox
        End If
    End Sub

    Private Sub body_Subject_TextChanged(sender As Object, e As EventArgs) Handles body_Subject.TextChanged
        ' Check if user did input a subject
        If String.IsNullOrWhiteSpace(body_Subject.Text) = False Then
            bodyVar_Subject = body_Body.Text ' Use user subject input
        Else
            bodyVar_Subject = "User: " & body_userEmail & " has sent you an email!" ' Use user email as subject input
        End If
    End Sub

    Private Sub body_Body_TextChanged(sender As Object, e As EventArgs) Handles body_Body.TextChanged
        ' Check if user did input an email message
        If String.IsNullOrWhiteSpace(body_Body.Text) = False Then
            bodyVar_Body = body_Body.Text ' Set message body
            bodyButton_Send.Enabled = True ' Enable send button
        Else
            bodyButton_Send.Enabled = False ' Disable send button
        End If
    End Sub

    Private Sub bodyButton_Send_Click(sender As Object, e As EventArgs) Handles bodyButton_Send.Click
        Try
            ' Declare mail service
            Dim message_Mail As New MailMessage
            Dim smtp_Server As New SmtpClient("smtp.gmail.com")

            ' Mail Service Main Code
            message_Mail.From = New MailAddress(body_userEmail)
            message_Mail.To.Add(bodyVar_Recipient)
            message_Mail.Subject = bodyVar_Subject
            message_Mail.Body = bodyVar_Body

            ' SMTP Server Main Code
            smtp_Server.Port = 587
            smtp_Server.Credentials = New System.Net.NetworkCredential(body_userEmail, body_userPassword)
            smtp_Server.EnableSsl = True
            smtp_Server.Send(message_Mail)

            MsgBox("Email sent successfully", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Success")
        Catch ex As Exception
            MsgBox("There was an error sending the email." & vbCrLf &
                   "Please recheck your User login credentials.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error sending email")
            ErrorProvider.SetError(bodyButton_Back, "Possible error from user login credentials!") ' Set error provider to back button
        End Try
    End Sub

    Private Sub bodyButton_Back_Click(sender As Object, e As EventArgs) Handles bodyButton_Back.Click
        If vbYes = MsgBox("Are you sure to go back?" & vbCrLf &
                          "This will discard current email message.", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Mail Sender") Then
            ErrorProvider.SetError(bodyButton_Back, "") ' Clear error provider

            ' Proceed to login form
            login_Mail.Show()
            Me.Close()
        End If
    End Sub
End Class
