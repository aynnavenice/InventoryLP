<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scrn_WelcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scrn_WelcomeForm))
        Me.txt_gn = New System.Windows.Forms.TextBox()
        Me.txt_ln = New System.Windows.Forms.TextBox()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.txt_un = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.grp_signup = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnk_signIn = New System.Windows.Forms.LinkLabel()
        Me.grp_signIn = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_no_acc = New System.Windows.Forms.Label()
        Me.lnk_signUp = New System.Windows.Forms.LinkLabel()
        Me.txt_login_un = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_login_pw = New System.Windows.Forms.TextBox()
        Me.grp_signup.SuspendLayout()
        Me.grp_signIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_gn
        '
        Me.txt_gn.Location = New System.Drawing.Point(33, 187)
        Me.txt_gn.Multiline = True
        Me.txt_gn.Name = "txt_gn"
        Me.txt_gn.Size = New System.Drawing.Size(265, 26)
        Me.txt_gn.TabIndex = 4
        '
        'txt_ln
        '
        Me.txt_ln.Location = New System.Drawing.Point(33, 259)
        Me.txt_ln.Multiline = True
        Me.txt_ln.Name = "txt_ln"
        Me.txt_ln.Size = New System.Drawing.Size(265, 30)
        Me.txt_ln.TabIndex = 5
        '
        'txt_pw
        '
        Me.txt_pw.Location = New System.Drawing.Point(33, 409)
        Me.txt_pw.Multiline = True
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.Size = New System.Drawing.Size(265, 36)
        Me.txt_pw.TabIndex = 7
        '
        'txt_un
        '
        Me.txt_un.Location = New System.Drawing.Point(33, 336)
        Me.txt_un.Multiline = True
        Me.txt_un.Name = "txt_un"
        Me.txt_un.Size = New System.Drawing.Size(265, 32)
        Me.txt_un.TabIndex = 6
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_submit.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(194, 464)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(105, 48)
        Me.btn_submit.TabIndex = 8
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'grp_signup
        '
        Me.grp_signup.Controls.Add(Me.Label6)
        Me.grp_signup.Controls.Add(Me.Label5)
        Me.grp_signup.Controls.Add(Me.Label4)
        Me.grp_signup.Controls.Add(Me.Label3)
        Me.grp_signup.Controls.Add(Me.lnk_signIn)
        Me.grp_signup.Controls.Add(Me.txt_pw)
        Me.grp_signup.Controls.Add(Me.txt_gn)
        Me.grp_signup.Controls.Add(Me.btn_submit)
        Me.grp_signup.Controls.Add(Me.txt_ln)
        Me.grp_signup.Controls.Add(Me.txt_un)
        Me.grp_signup.Dock = System.Windows.Forms.DockStyle.Right
        Me.grp_signup.Location = New System.Drawing.Point(1010, 0)
        Me.grp_signup.Name = "grp_signup"
        Me.grp_signup.Size = New System.Drawing.Size(332, 668)
        Me.grp_signup.TabIndex = 10
        Me.grp_signup.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "GIVEN NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "SURNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "USERNAME"
        '
        'lnk_signIn
        '
        Me.lnk_signIn.AutoSize = True
        Me.lnk_signIn.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_signIn.Location = New System.Drawing.Point(30, 464)
        Me.lnk_signIn.Name = "lnk_signIn"
        Me.lnk_signIn.Size = New System.Drawing.Size(158, 18)
        Me.lnk_signIn.TabIndex = 10
        Me.lnk_signIn.TabStop = True
        Me.lnk_signIn.Text = "Back to Sign In"
        '
        'grp_signIn
        '
        Me.grp_signIn.Controls.Add(Me.Button1)
        Me.grp_signIn.Controls.Add(Me.Label2)
        Me.grp_signIn.Controls.Add(Me.Label1)
        Me.grp_signIn.Controls.Add(Me.lbl_no_acc)
        Me.grp_signIn.Controls.Add(Me.lnk_signUp)
        Me.grp_signIn.Controls.Add(Me.txt_login_un)
        Me.grp_signIn.Controls.Add(Me.Button2)
        Me.grp_signIn.Controls.Add(Me.txt_login_pw)
        Me.grp_signIn.Location = New System.Drawing.Point(988, 0)
        Me.grp_signIn.Name = "grp_signIn"
        Me.grp_signIn.Size = New System.Drawing.Size(354, 668)
        Me.grp_signIn.TabIndex = 12
        Me.grp_signIn.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(223, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USERNAME"
        '
        'lbl_no_acc
        '
        Me.lbl_no_acc.AutoSize = True
        Me.lbl_no_acc.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_acc.Location = New System.Drawing.Point(30, 381)
        Me.lbl_no_acc.Name = "lbl_no_acc"
        Me.lbl_no_acc.Size = New System.Drawing.Size(158, 18)
        Me.lbl_no_acc.TabIndex = 12
        Me.lbl_no_acc.Text = "No account yet?"
        '
        'lnk_signUp
        '
        Me.lnk_signUp.AutoSize = True
        Me.lnk_signUp.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_signUp.Location = New System.Drawing.Point(28, 411)
        Me.lnk_signUp.Name = "lnk_signUp"
        Me.lnk_signUp.Size = New System.Drawing.Size(78, 18)
        Me.lnk_signUp.TabIndex = 11
        Me.lnk_signUp.TabStop = True
        Me.lnk_signUp.Text = "Sign Up"
        '
        'txt_login_un
        '
        Me.txt_login_un.Location = New System.Drawing.Point(33, 233)
        Me.txt_login_un.Multiline = True
        Me.txt_login_un.Name = "txt_login_un"
        Me.txt_login_un.Size = New System.Drawing.Size(265, 39)
        Me.txt_login_un.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "TEACHER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_login_pw
        '
        Me.txt_login_pw.Location = New System.Drawing.Point(33, 324)
        Me.txt_login_pw.Multiline = True
        Me.txt_login_pw.Name = "txt_login_pw"
        Me.txt_login_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_login_pw.Size = New System.Drawing.Size(265, 41)
        Me.txt_login_pw.TabIndex = 5
        '
        'Scrn_WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 668)
        Me.Controls.Add(Me.grp_signIn)
        Me.Controls.Add(Me.grp_signup)
        Me.DoubleBuffered = True
        Me.Name = "Scrn_WelcomeForm"
        Me.Text = "WELCOME SIGN IN"
        Me.grp_signup.ResumeLayout(False)
        Me.grp_signup.PerformLayout()
        Me.grp_signIn.ResumeLayout(False)
        Me.grp_signIn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_gn As TextBox
    Friend WithEvents txt_ln As TextBox
    Friend WithEvents txt_pw As TextBox
    Friend WithEvents txt_un As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents grp_signup As GroupBox
    Friend WithEvents grp_signIn As GroupBox
    Friend WithEvents txt_login_un As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_login_pw As TextBox
    Friend WithEvents lnk_signIn As LinkLabel
    Friend WithEvents lbl_no_acc As Label
    Friend WithEvents lnk_signUp As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
