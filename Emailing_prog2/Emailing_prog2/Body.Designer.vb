<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class body_Mail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bodyLabel_Recipient = New System.Windows.Forms.Label()
        Me.bodyLabel_Subject = New System.Windows.Forms.Label()
        Me.bodyLabel_Body = New System.Windows.Forms.Label()
        Me.body_Recipient = New System.Windows.Forms.TextBox()
        Me.body_Subject = New System.Windows.Forms.TextBox()
        Me.body_Body = New System.Windows.Forms.RichTextBox()
        Me.bodyButton_Send = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bodyButton_Back = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bodyLabel_Recipient
        '
        Me.bodyLabel_Recipient.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bodyLabel_Recipient.Location = New System.Drawing.Point(0, 0)
        Me.bodyLabel_Recipient.Name = "bodyLabel_Recipient"
        Me.bodyLabel_Recipient.Size = New System.Drawing.Size(88, 40)
        Me.bodyLabel_Recipient.TabIndex = 4
        Me.bodyLabel_Recipient.Text = "To:"
        Me.bodyLabel_Recipient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bodyLabel_Subject
        '
        Me.bodyLabel_Subject.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bodyLabel_Subject.Location = New System.Drawing.Point(0, 40)
        Me.bodyLabel_Subject.Name = "bodyLabel_Subject"
        Me.bodyLabel_Subject.Size = New System.Drawing.Size(88, 40)
        Me.bodyLabel_Subject.TabIndex = 5
        Me.bodyLabel_Subject.Text = "Subject:"
        Me.bodyLabel_Subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bodyLabel_Body
        '
        Me.bodyLabel_Body.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bodyLabel_Body.Location = New System.Drawing.Point(0, 80)
        Me.bodyLabel_Body.Name = "bodyLabel_Body"
        Me.bodyLabel_Body.Size = New System.Drawing.Size(88, 40)
        Me.bodyLabel_Body.TabIndex = 6
        Me.bodyLabel_Body.Text = "Body:"
        Me.bodyLabel_Body.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'body_Recipient
        '
        Me.body_Recipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.body_Recipient.Location = New System.Drawing.Point(104, 8)
        Me.body_Recipient.Name = "body_Recipient"
        Me.body_Recipient.Size = New System.Drawing.Size(440, 26)
        Me.body_Recipient.TabIndex = 9
        '
        'body_Subject
        '
        Me.body_Subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.body_Subject.Location = New System.Drawing.Point(104, 48)
        Me.body_Subject.Name = "body_Subject"
        Me.body_Subject.Size = New System.Drawing.Size(440, 26)
        Me.body_Subject.TabIndex = 10
        '
        'body_Body
        '
        Me.body_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.body_Body.Location = New System.Drawing.Point(104, 88)
        Me.body_Body.Name = "body_Body"
        Me.body_Body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.body_Body.Size = New System.Drawing.Size(440, 360)
        Me.body_Body.TabIndex = 11
        Me.body_Body.Text = ""
        '
        'bodyButton_Send
        '
        Me.bodyButton_Send.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bodyButton_Send.Enabled = False
        Me.bodyButton_Send.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bodyButton_Send.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bodyButton_Send.Location = New System.Drawing.Point(8, 408)
        Me.bodyButton_Send.Name = "bodyButton_Send"
        Me.bodyButton_Send.Size = New System.Drawing.Size(88, 39)
        Me.bodyButton_Send.TabIndex = 12
        Me.bodyButton_Send.Text = "SEND"
        Me.bodyButton_Send.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'bodyButton_Back
        '
        Me.bodyButton_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bodyButton_Back.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bodyButton_Back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bodyButton_Back.Location = New System.Drawing.Point(8, 360)
        Me.bodyButton_Back.Name = "bodyButton_Back"
        Me.bodyButton_Back.Size = New System.Drawing.Size(88, 39)
        Me.bodyButton_Back.TabIndex = 13
        Me.bodyButton_Back.Text = "BACK"
        Me.bodyButton_Back.UseVisualStyleBackColor = False
        '
        'body_Mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 482)
        Me.Controls.Add(Me.bodyButton_Back)
        Me.Controls.Add(Me.bodyButton_Send)
        Me.Controls.Add(Me.body_Body)
        Me.Controls.Add(Me.body_Subject)
        Me.Controls.Add(Me.body_Recipient)
        Me.Controls.Add(Me.bodyLabel_Body)
        Me.Controls.Add(Me.bodyLabel_Subject)
        Me.Controls.Add(Me.bodyLabel_Recipient)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "body_Mail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail Sender"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bodyLabel_Recipient As Label
    Friend WithEvents bodyLabel_Subject As Label
    Friend WithEvents bodyLabel_Body As Label
    Friend WithEvents body_Recipient As TextBox
    Friend WithEvents body_Subject As TextBox
    Friend WithEvents body_Body As RichTextBox
    Friend WithEvents bodyButton_Send As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents bodyButton_Back As System.Windows.Forms.Button

End Class
