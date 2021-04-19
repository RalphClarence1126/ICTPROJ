<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_Mail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_Mail))
        Me.loginLabel_Email = New System.Windows.Forms.Label()
        Me.loginLabel_Password = New System.Windows.Forms.Label()
        Me.login_Email = New System.Windows.Forms.TextBox()
        Me.login_Password = New System.Windows.Forms.TextBox()
        Me.login_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loginLabel_Email
        '
        Me.loginLabel_Email.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel_Email.Location = New System.Drawing.Point(32, 32)
        Me.loginLabel_Email.Name = "loginLabel_Email"
        Me.loginLabel_Email.Size = New System.Drawing.Size(88, 40)
        Me.loginLabel_Email.TabIndex = 2
        Me.loginLabel_Email.Text = "Email:"
        Me.loginLabel_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'loginLabel_Password
        '
        Me.loginLabel_Password.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel_Password.Location = New System.Drawing.Point(32, 88)
        Me.loginLabel_Password.Name = "loginLabel_Password"
        Me.loginLabel_Password.Size = New System.Drawing.Size(88, 40)
        Me.loginLabel_Password.TabIndex = 3
        Me.loginLabel_Password.Text = "Password:"
        Me.loginLabel_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'login_Email
        '
        Me.login_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_Email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_Email.Location = New System.Drawing.Point(136, 40)
        Me.login_Email.Name = "login_Email"
        Me.login_Email.Size = New System.Drawing.Size(200, 26)
        Me.login_Email.TabIndex = 7
        '
        'login_Password
        '
        Me.login_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_Password.Enabled = False
        Me.login_Password.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_Password.Location = New System.Drawing.Point(136, 96)
        Me.login_Password.Name = "login_Password"
        Me.login_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.login_Password.Size = New System.Drawing.Size(200, 26)
        Me.login_Password.TabIndex = 8
        '
        'login_Button
        '
        Me.login_Button.Enabled = False
        Me.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_Button.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.login_Button.Location = New System.Drawing.Point(24, 144)
        Me.login_Button.Name = "login_Button"
        Me.login_Button.Size = New System.Drawing.Size(312, 40)
        Me.login_Button.TabIndex = 9
        Me.login_Button.Text = "LOG IN"
        Me.login_Button.UseVisualStyleBackColor = True
        '
        'login_Mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 212)
        Me.Controls.Add(Me.login_Button)
        Me.Controls.Add(Me.login_Password)
        Me.Controls.Add(Me.login_Email)
        Me.Controls.Add(Me.loginLabel_Password)
        Me.Controls.Add(Me.loginLabel_Email)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login_Mail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail Sender Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginLabel_Email As Label
    Friend WithEvents loginLabel_Password As Label
    Friend WithEvents login_Email As TextBox
    Friend WithEvents login_Password As TextBox
    Friend WithEvents login_Button As System.Windows.Forms.Button

End Class