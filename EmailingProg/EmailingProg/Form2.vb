Imports System.Net.Mail
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim mail As New MailMessage
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(txtFrom.Text)
            mail.To.Add(txtTo.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text

            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential(txtFrom.Text, txtPassword.Text)
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)
            MsgBox("Your mail has been sent.", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

        If txtFrom.Text = "" Then
            Me.ErrorProvider1.SetError(txtFrom, "Please enter a valid E-mail address")
        Else Me.ErrorProvider1.SetError(Me.txtFrom, "")

        End If
        If txtTo.Text = "" Then
            Me.ErrorProvider1.SetError(txtTo, "Please enter a valid E-mail address")

        Else Me.ErrorProvider1.SetError(Me.txtTo, "")
        End If
        If txtPassword.Text = "" Then
            Me.ErrorProvider1.SetError(txtPassword, "Please enter a Password")
            System.Console.WriteLine(<args></args>)

        Else Me.ErrorProvider1.SetError(Me.txtPassword, "")
        End If
        If txtPassword.Text = False Then System.Console.WriteLine(<args></args>)
    End Sub
End Class