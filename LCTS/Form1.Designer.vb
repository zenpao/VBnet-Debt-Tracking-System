<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.lnk_Register = New System.Windows.Forms.LinkLabel()
        Me.lbl_Company = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Gold
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(123, 158)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(75, 23)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "Log-in"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Username.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(67, 95)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(48, 12)
        Me.lbl_Username.TabIndex = 1
        Me.lbl_Username.Text = "User ID:"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(57, 122)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(62, 12)
        Me.lbl_Password.TabIndex = 2
        Me.lbl_Password.Text = "Password:"
        '
        'txt_UserID
        '
        Me.txt_UserID.BackColor = System.Drawing.Color.White
        Me.txt_UserID.Location = New System.Drawing.Point(122, 88)
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Size = New System.Drawing.Size(130, 20)
        Me.txt_UserID.TabIndex = 1
        Me.txt_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.White
        Me.txt_Password.Location = New System.Drawing.Point(122, 119)
        Me.txt_Password.MaxLength = 24
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(130, 20)
        Me.txt_Password.TabIndex = 2
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'lnk_Register
        '
        Me.lnk_Register.AutoSize = True
        Me.lnk_Register.Location = New System.Drawing.Point(261, 188)
        Me.lnk_Register.Name = "lnk_Register"
        Me.lnk_Register.Size = New System.Drawing.Size(46, 13)
        Me.lnk_Register.TabIndex = 4
        Me.lnk_Register.TabStop = True
        Me.lnk_Register.Text = "Register"
        '
        'lbl_Company
        '
        Me.lbl_Company.AutoSize = True
        Me.lbl_Company.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Company.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Company.Location = New System.Drawing.Point(59, 36)
        Me.lbl_Company.Name = "lbl_Company"
        Me.lbl_Company.Size = New System.Drawing.Size(206, 18)
        Me.lbl_Company.TabIndex = 6
        Me.lbl_Company.Text = "DMAXFund Lending, INC."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(319, 210)
        Me.Controls.Add(Me.lbl_Company)
        Me.Controls.Add(Me.lnk_Register)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_UserID)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.btn_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log-in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents txt_UserID As System.Windows.Forms.TextBox
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents lnk_Register As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Company As System.Windows.Forms.Label

End Class
