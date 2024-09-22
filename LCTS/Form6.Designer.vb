<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.btn_NewBalance = New System.Windows.Forms.Button()
        Me.txt_Payment = New System.Windows.Forms.TextBox()
        Me.lbl_Name2 = New System.Windows.Forms.Label()
        Me.lbl_Balance2 = New System.Windows.Forms.Label()
        Me.lbl_Current2 = New System.Windows.Forms.Label()
        Me.lbl_Amount = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_Bar = New System.Windows.Forms.Label()
        Me.lbl_Sum = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_DueNum = New System.Windows.Forms.Label()
        Me.lbl_Due = New System.Windows.Forms.Label()
        Me.lst_Monitor = New System.Windows.Forms.ListBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Location = New System.Windows.Forms.Label()
        Me.lbl_Current = New System.Windows.Forms.Label()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_Home = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_NewBalance
        '
        Me.btn_NewBalance.BackColor = System.Drawing.SystemColors.Control
        Me.btn_NewBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewBalance.Location = New System.Drawing.Point(98, 174)
        Me.btn_NewBalance.Name = "btn_NewBalance"
        Me.btn_NewBalance.Size = New System.Drawing.Size(101, 23)
        Me.btn_NewBalance.TabIndex = 0
        Me.btn_NewBalance.Text = "Accept"
        Me.btn_NewBalance.UseVisualStyleBackColor = False
        '
        'txt_Payment
        '
        Me.txt_Payment.Location = New System.Drawing.Point(129, 129)
        Me.txt_Payment.Name = "txt_Payment"
        Me.txt_Payment.Size = New System.Drawing.Size(100, 20)
        Me.txt_Payment.TabIndex = 1
        Me.txt_Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Name2
        '
        Me.lbl_Name2.AutoSize = True
        Me.lbl_Name2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name2.Location = New System.Drawing.Point(8, 29)
        Me.lbl_Name2.Name = "lbl_Name2"
        Me.lbl_Name2.Size = New System.Drawing.Size(54, 18)
        Me.lbl_Name2.TabIndex = 9
        Me.lbl_Name2.Text = "Name"
        '
        'lbl_Balance2
        '
        Me.lbl_Balance2.AutoSize = True
        Me.lbl_Balance2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Balance2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance2.Location = New System.Drawing.Point(53, 79)
        Me.lbl_Balance2.Name = "lbl_Balance2"
        Me.lbl_Balance2.Size = New System.Drawing.Size(87, 17)
        Me.lbl_Balance2.TabIndex = 10
        Me.lbl_Balance2.Text = "BALANCE:"
        '
        'lbl_Current2
        '
        Me.lbl_Current2.AutoSize = True
        Me.lbl_Current2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Current2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current2.ForeColor = System.Drawing.Color.Black
        Me.lbl_Current2.Location = New System.Drawing.Point(138, 80)
        Me.lbl_Current2.Name = "lbl_Current2"
        Me.lbl_Current2.Size = New System.Drawing.Size(114, 17)
        Me.lbl_Current2.TabIndex = 15
        Me.lbl_Current2.Text = "Current Balance"
        '
        'lbl_Amount
        '
        Me.lbl_Amount.AutoSize = True
        Me.lbl_Amount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Amount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Amount.ForeColor = System.Drawing.Color.Black
        Me.lbl_Amount.Location = New System.Drawing.Point(67, 135)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(56, 14)
        Me.lbl_Amount.TabIndex = 16
        Me.lbl_Amount.Text = "Amount:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 46)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(306, 410)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage1.Controls.Add(Me.lbl_Bar)
        Me.TabPage1.Controls.Add(Me.lbl_Sum)
        Me.TabPage1.Controls.Add(Me.lbl_Total)
        Me.TabPage1.Controls.Add(Me.lbl_DueNum)
        Me.TabPage1.Controls.Add(Me.lbl_Due)
        Me.TabPage1.Controls.Add(Me.lst_Monitor)
        Me.TabPage1.Controls.Add(Me.lbl_Address)
        Me.TabPage1.Controls.Add(Me.lbl_Location)
        Me.TabPage1.Controls.Add(Me.lbl_Current)
        Me.TabPage1.Controls.Add(Me.lbl_Balance)
        Me.TabPage1.Controls.Add(Me.lbl_Name)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(298, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'lbl_Bar
        '
        Me.lbl_Bar.AutoSize = True
        Me.lbl_Bar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Bar.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bar.Location = New System.Drawing.Point(5, 304)
        Me.lbl_Bar.Name = "lbl_Bar"
        Me.lbl_Bar.Size = New System.Drawing.Size(287, 14)
        Me.lbl_Bar.TabIndex = 38
        Me.lbl_Bar.Text = "--------------------------------------------------------"
        '
        'lbl_Sum
        '
        Me.lbl_Sum.AutoSize = True
        Me.lbl_Sum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Sum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sum.ForeColor = System.Drawing.Color.Red
        Me.lbl_Sum.Location = New System.Drawing.Point(190, 335)
        Me.lbl_Sum.Name = "lbl_Sum"
        Me.lbl_Sum.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Sum.TabIndex = 37
        Me.lbl_Sum.Text = "Total"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total.Location = New System.Drawing.Point(12, 334)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(146, 18)
        Me.lbl_Total.TabIndex = 36
        Me.lbl_Total.Text = "TOTAL PAYMENT"
        '
        'lbl_DueNum
        '
        Me.lbl_DueNum.AutoSize = True
        Me.lbl_DueNum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DueNum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DueNum.ForeColor = System.Drawing.Color.Black
        Me.lbl_DueNum.Location = New System.Drawing.Point(146, 129)
        Me.lbl_DueNum.Name = "lbl_DueNum"
        Me.lbl_DueNum.Size = New System.Drawing.Size(42, 17)
        Me.lbl_DueNum.TabIndex = 23
        Me.lbl_DueNum.Text = "Days"
        '
        'lbl_Due
        '
        Me.lbl_Due.AutoSize = True
        Me.lbl_Due.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Due.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Due.Location = New System.Drawing.Point(31, 131)
        Me.lbl_Due.Name = "lbl_Due"
        Me.lbl_Due.Size = New System.Drawing.Size(100, 14)
        Me.lbl_Due.TabIndex = 22
        Me.lbl_Due.Text = "DUE PAYMENT:"
        '
        'lst_Monitor
        '
        Me.lst_Monitor.BackColor = System.Drawing.Color.PeachPuff
        Me.lst_Monitor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_Monitor.FormattingEnabled = True
        Me.lst_Monitor.Location = New System.Drawing.Point(37, 165)
        Me.lst_Monitor.Name = "lst_Monitor"
        Me.lst_Monitor.ScrollAlwaysVisible = True
        Me.lst_Monitor.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lst_Monitor.Size = New System.Drawing.Size(240, 130)
        Me.lst_Monitor.Sorted = True
        Me.lst_Monitor.TabIndex = 21
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.ForeColor = System.Drawing.Color.Black
        Me.lbl_Address.Location = New System.Drawing.Point(131, 69)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(49, 14)
        Me.lbl_Address.TabIndex = 20
        Me.lbl_Address.Text = "Address"
        '
        'lbl_Location
        '
        Me.lbl_Location.AutoSize = True
        Me.lbl_Location.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Location.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Location.Location = New System.Drawing.Point(46, 70)
        Me.lbl_Location.Name = "lbl_Location"
        Me.lbl_Location.Size = New System.Drawing.Size(71, 14)
        Me.lbl_Location.TabIndex = 19
        Me.lbl_Location.Text = "ADDRESS:"
        '
        'lbl_Current
        '
        Me.lbl_Current.AutoSize = True
        Me.lbl_Current.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Current.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current.ForeColor = System.Drawing.Color.Black
        Me.lbl_Current.Location = New System.Drawing.Point(137, 99)
        Me.lbl_Current.Name = "lbl_Current"
        Me.lbl_Current.Size = New System.Drawing.Size(114, 17)
        Me.lbl_Current.TabIndex = 18
        Me.lbl_Current.Text = "Current Balance"
        '
        'lbl_Balance
        '
        Me.lbl_Balance.AutoSize = True
        Me.lbl_Balance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Balance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.Location = New System.Drawing.Point(47, 102)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(71, 14)
        Me.lbl_Balance.TabIndex = 17
        Me.lbl_Balance.Text = "BALANCE:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(8, 29)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(54, 18)
        Me.lbl_Name.TabIndex = 16
        Me.lbl_Name.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage2.Controls.Add(Me.lbl_Current2)
        Me.TabPage2.Controls.Add(Me.lbl_Amount)
        Me.TabPage2.Controls.Add(Me.btn_NewBalance)
        Me.TabPage2.Controls.Add(Me.txt_Payment)
        Me.TabPage2.Controls.Add(Me.lbl_Balance2)
        Me.TabPage2.Controls.Add(Me.lbl_Name2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(298, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'btn_Home
        '
        Me.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Home.Location = New System.Drawing.Point(25, 12)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(29, 26)
        Me.btn_Home.TabIndex = 18
        Me.btn_Home.Text = "⌂"
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.Location = New System.Drawing.Point(250, 13)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(50, 25)
        Me.btn_Back.TabIndex = 19
        Me.btn_Back.Text = "back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(325, 466)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_NewBalance As System.Windows.Forms.Button
    Friend WithEvents txt_Payment As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Name2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Balance2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Current2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Amount As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Current As System.Windows.Forms.Label
    Friend WithEvents lbl_Balance As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Address As System.Windows.Forms.Label
    Friend WithEvents lbl_Location As System.Windows.Forms.Label
    Friend WithEvents lst_Monitor As System.Windows.Forms.ListBox
    Friend WithEvents lbl_DueNum As System.Windows.Forms.Label
    Friend WithEvents lbl_Due As System.Windows.Forms.Label
    Friend WithEvents lbl_Bar As System.Windows.Forms.Label
    Friend WithEvents lbl_Sum As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents btn_Home As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
