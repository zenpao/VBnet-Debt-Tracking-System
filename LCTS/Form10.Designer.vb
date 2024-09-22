<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.lbl_Welcome = New System.Windows.Forms.Label()
        Me.lbl_Company = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_Bar = New System.Windows.Forms.Label()
        Me.lbl_Sum = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lst_Client = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Collector = New System.Windows.Forms.Label()
        Me.lst_Collector = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_testDb = New System.Windows.Forms.Button()
        Me.btn_TestDue = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(694, 270)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage1.Controls.Add(Me.btn_Logout)
        Me.TabPage1.Controls.Add(Me.lbl_Welcome)
        Me.TabPage1.Controls.Add(Me.lbl_Company)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(686, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Snow
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(292, 182)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(116, 22)
        Me.btn_Logout.TabIndex = 14
        Me.btn_Logout.Text = "Log Out"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'lbl_Welcome
        '
        Me.lbl_Welcome.AutoSize = True
        Me.lbl_Welcome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Welcome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Welcome.Location = New System.Drawing.Point(175, 112)
        Me.lbl_Welcome.Name = "lbl_Welcome"
        Me.lbl_Welcome.Size = New System.Drawing.Size(86, 18)
        Me.lbl_Welcome.TabIndex = 13
        Me.lbl_Welcome.Text = "Welcome,"
        '
        'lbl_Company
        '
        Me.lbl_Company.AutoSize = True
        Me.lbl_Company.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Company.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Company.Location = New System.Drawing.Point(153, 53)
        Me.lbl_Company.Name = "lbl_Company"
        Me.lbl_Company.Size = New System.Drawing.Size(406, 37)
        Me.lbl_Company.TabIndex = 12
        Me.lbl_Company.Text = "DMAXFund Lending, INC."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage2.Controls.Add(Me.lbl_Bar)
        Me.TabPage2.Controls.Add(Me.lbl_Sum)
        Me.TabPage2.Controls.Add(Me.lbl_Total)
        Me.TabPage2.Controls.Add(Me.lst_Client)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lbl_Collector)
        Me.TabPage2.Controls.Add(Me.lst_Collector)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(686, 244)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'lbl_Bar
        '
        Me.lbl_Bar.AutoSize = True
        Me.lbl_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Bar.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bar.Location = New System.Drawing.Point(297, 174)
        Me.lbl_Bar.Name = "lbl_Bar"
        Me.lbl_Bar.Size = New System.Drawing.Size(372, 14)
        Me.lbl_Bar.TabIndex = 34
        Me.lbl_Bar.Text = "-------------------------------------------------------------------------"
        '
        'lbl_Sum
        '
        Me.lbl_Sum.AutoSize = True
        Me.lbl_Sum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Sum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sum.ForeColor = System.Drawing.Color.Black
        Me.lbl_Sum.Location = New System.Drawing.Point(553, 200)
        Me.lbl_Sum.Name = "lbl_Sum"
        Me.lbl_Sum.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Sum.TabIndex = 33
        Me.lbl_Sum.Text = "Total"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.Red
        Me.lbl_Total.Location = New System.Drawing.Point(329, 199)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(56, 22)
        Me.lbl_Total.TabIndex = 32
        Me.lbl_Total.Text = "Total"
        '
        'lst_Client
        '
        Me.lst_Client.BackColor = System.Drawing.Color.PeachPuff
        Me.lst_Client.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_Client.FormattingEnabled = True
        Me.lst_Client.Location = New System.Drawing.Point(315, 38)
        Me.lst_Client.Name = "lst_Client"
        Me.lst_Client.ScrollAlwaysVisible = True
        Me.lst_Client.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lst_Client.Size = New System.Drawing.Size(348, 130)
        Me.lst_Client.Sorted = True
        Me.lst_Client.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 12)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Clients:"
        '
        'lbl_Collector
        '
        Me.lbl_Collector.AutoSize = True
        Me.lbl_Collector.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Collector.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Collector.Location = New System.Drawing.Point(15, 14)
        Me.lbl_Collector.Name = "lbl_Collector"
        Me.lbl_Collector.Size = New System.Drawing.Size(59, 12)
        Me.lbl_Collector.TabIndex = 29
        Me.lbl_Collector.Text = "Collector:"
        '
        'lst_Collector
        '
        Me.lst_Collector.BackColor = System.Drawing.Color.Snow
        Me.lst_Collector.FormattingEnabled = True
        Me.lst_Collector.Location = New System.Drawing.Point(31, 38)
        Me.lst_Collector.Name = "lst_Collector"
        Me.lst_Collector.ScrollAlwaysVisible = True
        Me.lst_Collector.Size = New System.Drawing.Size(240, 134)
        Me.lst_Collector.Sorted = True
        Me.lst_Collector.TabIndex = 12
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage4.Controls.Add(Me.btn_TestDue)
        Me.TabPage4.Controls.Add(Me.btn_testDb)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(686, 244)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage3"
        '
        'btn_testDb
        '
        Me.btn_testDb.Location = New System.Drawing.Point(268, 149)
        Me.btn_testDb.Name = "btn_testDb"
        Me.btn_testDb.Size = New System.Drawing.Size(150, 44)
        Me.btn_testDb.TabIndex = 1
        Me.btn_testDb.Text = "Test Database Connection"
        Me.btn_testDb.UseVisualStyleBackColor = True
        '
        'btn_TestDue
        '
        Me.btn_TestDue.Location = New System.Drawing.Point(268, 58)
        Me.btn_TestDue.Name = "btn_TestDue"
        Me.btn_TestDue.Size = New System.Drawing.Size(150, 44)
        Me.btn_TestDue.TabIndex = 2
        Me.btn_TestDue.Text = "Test A Sample Due date"
        Me.btn_TestDue.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(719, 300)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form10"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Logout As System.Windows.Forms.Button
    Friend WithEvents lbl_Welcome As System.Windows.Forms.Label
    Friend WithEvents lbl_Company As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lst_Collector As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Collector As System.Windows.Forms.Label
    Friend WithEvents lst_Client As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Sum As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Bar As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btn_testDb As System.Windows.Forms.Button
    Friend WithEvents btn_TestDue As System.Windows.Forms.Button
End Class
