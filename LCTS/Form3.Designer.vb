<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lbl_Welcome = New System.Windows.Forms.Label()
        Me.btn_List = New System.Windows.Forms.Button()
        Me.btn_Profile = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Welcome
        '
        Me.lbl_Welcome.AutoSize = True
        Me.lbl_Welcome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Welcome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Welcome.Location = New System.Drawing.Point(54, 29)
        Me.lbl_Welcome.Name = "lbl_Welcome"
        Me.lbl_Welcome.Size = New System.Drawing.Size(71, 15)
        Me.lbl_Welcome.TabIndex = 7
        Me.lbl_Welcome.Text = "Welcome,"
        '
        'btn_List
        '
        Me.btn_List.BackColor = System.Drawing.Color.Gold
        Me.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_List.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_List.Location = New System.Drawing.Point(123, 74)
        Me.btn_List.Name = "btn_List"
        Me.btn_List.Size = New System.Drawing.Size(116, 22)
        Me.btn_List.TabIndex = 8
        Me.btn_List.Text = "Collector's List"
        Me.btn_List.UseVisualStyleBackColor = False
        '
        'btn_Profile
        '
        Me.btn_Profile.BackColor = System.Drawing.Color.Orange
        Me.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Profile.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Profile.Location = New System.Drawing.Point(123, 121)
        Me.btn_Profile.Name = "btn_Profile"
        Me.btn_Profile.Size = New System.Drawing.Size(116, 22)
        Me.btn_Profile.TabIndex = 9
        Me.btn_Profile.Text = "Client Profile"
        Me.btn_Profile.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.LightCoral
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(123, 167)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(116, 22)
        Me.btn_Logout.TabIndex = 10
        Me.btn_Logout.Text = "Log Out"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(362, 217)
        Me.Controls.Add(Me.btn_Logout)
        Me.Controls.Add(Me.btn_Profile)
        Me.Controls.Add(Me.btn_List)
        Me.Controls.Add(Me.lbl_Welcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Welcome As System.Windows.Forms.Label
    Friend WithEvents btn_List As System.Windows.Forms.Button
    Friend WithEvents btn_Profile As System.Windows.Forms.Button
    Friend WithEvents btn_Logout As System.Windows.Forms.Button
End Class
