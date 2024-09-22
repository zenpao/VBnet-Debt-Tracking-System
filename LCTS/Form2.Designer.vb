<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.txt_ContactNum = New System.Windows.Forms.TextBox()
        Me.lbl_ContactNum = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.lbl_EmpID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_slashDays = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Start = New System.Windows.Forms.Label()
        Me.lst_Collector = New System.Windows.Forms.ListBox()
        Me.lbl_Collector = New System.Windows.Forms.Label()
        Me.txt_Due = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Balance = New System.Windows.Forms.TextBox()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.txt_CheckPass = New System.Windows.Forms.TextBox()
        Me.lbl_CheckPass = New System.Windows.Forms.Label()
        Me.lnk_Reset = New System.Windows.Forms.LinkLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Type = New System.Windows.Forms.ComboBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MiddleName = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.lbl_MiddleName = New System.Windows.Forms.Label()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_TestDue = New System.Windows.Forms.Button()
        Me.btn_testDb = New System.Windows.Forms.Button()
        Me.Box3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Box2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_LastName
        '
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LastName.Location = New System.Drawing.Point(9, 61)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(67, 12)
        Me.lbl_LastName.TabIndex = 0
        Me.lbl_LastName.Text = "Last Name:"
        '
        'txt_ContactNum
        '
        Me.txt_ContactNum.BackColor = System.Drawing.Color.White
        Me.txt_ContactNum.Location = New System.Drawing.Point(437, 88)
        Me.txt_ContactNum.MaxLength = 13
        Me.txt_ContactNum.Name = "txt_ContactNum"
        Me.txt_ContactNum.Size = New System.Drawing.Size(145, 20)
        Me.txt_ContactNum.TabIndex = 5
        Me.txt_ContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ContactNum
        '
        Me.lbl_ContactNum.AutoSize = True
        Me.lbl_ContactNum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ContactNum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ContactNum.Location = New System.Drawing.Point(374, 95)
        Me.lbl_ContactNum.Name = "lbl_ContactNum"
        Me.lbl_ContactNum.Size = New System.Drawing.Size(61, 12)
        Me.lbl_ContactNum.TabIndex = 3
        Me.lbl_ContactNum.Text = "Contact #:"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(9, 167)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(62, 12)
        Me.lbl_Password.TabIndex = 4
        Me.lbl_Password.Text = "Password:"
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.White
        Me.txt_Password.Location = New System.Drawing.Point(71, 160)
        Me.txt_Password.MaxLength = 24
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(100, 20)
        Me.txt_Password.TabIndex = 7
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'btn_Register
        '
        Me.btn_Register.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Register.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.Location = New System.Drawing.Point(507, 349)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(75, 23)
        Me.btn_Register.TabIndex = 10
        Me.btn_Register.Text = "Save"
        Me.btn_Register.UseVisualStyleBackColor = False
        '
        'lbl_EmpID
        '
        Me.lbl_EmpID.AutoSize = True
        Me.lbl_EmpID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EmpID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpID.Location = New System.Drawing.Point(454, 19)
        Me.lbl_EmpID.Name = "lbl_EmpID"
        Me.lbl_EmpID.Size = New System.Drawing.Size(19, 12)
        Me.lbl_EmpID.TabIndex = 7
        Me.lbl_EmpID.Text = "ID:"
        '
        'txt_ID
        '
        Me.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ID.Location = New System.Drawing.Point(482, 12)
        Me.txt_ID.MaxLength = 50
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ID.TabIndex = 8
        Me.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 20)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(604, 416)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage1.Controls.Add(Me.lbl_slashDays)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.lbl_Start)
        Me.TabPage1.Controls.Add(Me.lst_Collector)
        Me.TabPage1.Controls.Add(Me.lbl_Collector)
        Me.TabPage1.Controls.Add(Me.txt_Due)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_Balance)
        Me.TabPage1.Controls.Add(Me.lbl_Balance)
        Me.TabPage1.Controls.Add(Me.txt_CheckPass)
        Me.TabPage1.Controls.Add(Me.lbl_CheckPass)
        Me.TabPage1.Controls.Add(Me.lnk_Reset)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmb_Type)
        Me.TabPage1.Controls.Add(Me.txt_Email)
        Me.TabPage1.Controls.Add(Me.txt_Address)
        Me.TabPage1.Controls.Add(Me.lbl_Address)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_MiddleName)
        Me.TabPage1.Controls.Add(Me.txt_FirstName)
        Me.TabPage1.Controls.Add(Me.txt_LastName)
        Me.TabPage1.Controls.Add(Me.lbl_MiddleName)
        Me.TabPage1.Controls.Add(Me.lbl_FirstName)
        Me.TabPage1.Controls.Add(Me.lbl_EmpID)
        Me.TabPage1.Controls.Add(Me.btn_Register)
        Me.TabPage1.Controls.Add(Me.txt_ID)
        Me.TabPage1.Controls.Add(Me.lbl_LastName)
        Me.TabPage1.Controls.Add(Me.txt_ContactNum)
        Me.TabPage1.Controls.Add(Me.txt_Password)
        Me.TabPage1.Controls.Add(Me.lbl_ContactNum)
        Me.TabPage1.Controls.Add(Me.lbl_Password)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(596, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'lbl_slashDays
        '
        Me.lbl_slashDays.AutoSize = True
        Me.lbl_slashDays.BackColor = System.Drawing.Color.Transparent
        Me.lbl_slashDays.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_slashDays.Location = New System.Drawing.Point(524, 200)
        Me.lbl_slashDays.Name = "lbl_slashDays"
        Me.lbl_slashDays.Size = New System.Drawing.Size(33, 14)
        Me.lbl_slashDays.TabIndex = 31
        Me.lbl_slashDays.Text = "/days"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(220, 194)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 30
        '
        'lbl_Start
        '
        Me.lbl_Start.AutoSize = True
        Me.lbl_Start.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Start.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Start.Location = New System.Drawing.Point(179, 201)
        Me.lbl_Start.Name = "lbl_Start"
        Me.lbl_Start.Size = New System.Drawing.Size(35, 12)
        Me.lbl_Start.TabIndex = 29
        Me.lbl_Start.Text = "Start:"
        '
        'lst_Collector
        '
        Me.lst_Collector.BackColor = System.Drawing.Color.Snow
        Me.lst_Collector.FormattingEnabled = True
        Me.lst_Collector.Location = New System.Drawing.Point(73, 242)
        Me.lst_Collector.Name = "lst_Collector"
        Me.lst_Collector.ScrollAlwaysVisible = True
        Me.lst_Collector.Size = New System.Drawing.Size(240, 134)
        Me.lst_Collector.Sorted = True
        Me.lst_Collector.TabIndex = 11
        '
        'lbl_Collector
        '
        Me.lbl_Collector.AutoSize = True
        Me.lbl_Collector.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Collector.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Collector.Location = New System.Drawing.Point(12, 242)
        Me.lbl_Collector.Name = "lbl_Collector"
        Me.lbl_Collector.Size = New System.Drawing.Size(59, 12)
        Me.lbl_Collector.TabIndex = 28
        Me.lbl_Collector.Text = "Collector:"
        '
        'txt_Due
        '
        Me.txt_Due.BackColor = System.Drawing.Color.White
        Me.txt_Due.Location = New System.Drawing.Point(469, 193)
        Me.txt_Due.Name = "txt_Due"
        Me.txt_Due.Size = New System.Drawing.Size(55, 20)
        Me.txt_Due.TabIndex = 10
        Me.txt_Due.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 12)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Due:"
        '
        'txt_Balance
        '
        Me.txt_Balance.BackColor = System.Drawing.Color.White
        Me.txt_Balance.Location = New System.Drawing.Point(63, 194)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Size = New System.Drawing.Size(108, 20)
        Me.txt_Balance.TabIndex = 9
        Me.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Balance
        '
        Me.lbl_Balance.AutoSize = True
        Me.lbl_Balance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Balance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.Location = New System.Drawing.Point(10, 201)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(54, 12)
        Me.lbl_Balance.TabIndex = 24
        Me.lbl_Balance.Text = "Balance:"
        '
        'txt_CheckPass
        '
        Me.txt_CheckPass.BackColor = System.Drawing.Color.White
        Me.txt_CheckPass.Location = New System.Drawing.Point(291, 160)
        Me.txt_CheckPass.MaxLength = 24
        Me.txt_CheckPass.Name = "txt_CheckPass"
        Me.txt_CheckPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_CheckPass.Size = New System.Drawing.Size(100, 20)
        Me.txt_CheckPass.TabIndex = 8
        Me.txt_CheckPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_CheckPass.UseSystemPasswordChar = True
        '
        'lbl_CheckPass
        '
        Me.lbl_CheckPass.AutoSize = True
        Me.lbl_CheckPass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CheckPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CheckPass.Location = New System.Drawing.Point(179, 167)
        Me.lbl_CheckPass.Name = "lbl_CheckPass"
        Me.lbl_CheckPass.Size = New System.Drawing.Size(109, 12)
        Me.lbl_CheckPass.TabIndex = 23
        Me.lbl_CheckPass.Text = "Confirm Password:"
        '
        'lnk_Reset
        '
        Me.lnk_Reset.AutoSize = True
        Me.lnk_Reset.BackColor = System.Drawing.Color.Transparent
        Me.lnk_Reset.Location = New System.Drawing.Point(466, 359)
        Me.lnk_Reset.Name = "lnk_Reset"
        Me.lnk_Reset.Size = New System.Drawing.Size(35, 13)
        Me.lnk_Reset.TabIndex = 22
        Me.lnk_Reset.TabStop = True
        Me.lnk_Reset.Text = "Reset"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(74, 124)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Birthdate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Type:"
        '
        'cmb_Type
        '
        Me.cmb_Type.BackColor = System.Drawing.Color.Gold
        Me.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.Items.AddRange(New Object() {"Management", "Collector", "Client"})
        Me.cmb_Type.Location = New System.Drawing.Point(49, 13)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.Size = New System.Drawing.Size(87, 21)
        Me.cmb_Type.TabIndex = 0
        '
        'txt_Email
        '
        Me.txt_Email.BackColor = System.Drawing.Color.White
        Me.txt_Email.Location = New System.Drawing.Point(322, 124)
        Me.txt_Email.MaxLength = 50
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(208, 20)
        Me.txt_Email.TabIndex = 6
        Me.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.Color.White
        Me.txt_Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Address.Location = New System.Drawing.Point(63, 88)
        Me.txt_Address.MaxLength = 50
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(301, 20)
        Me.txt_Address.TabIndex = 4
        Me.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(9, 95)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(54, 12)
        Me.lbl_Address.TabIndex = 15
        Me.lbl_Address.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Email:"
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.BackColor = System.Drawing.Color.White
        Me.txt_MiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MiddleName.Location = New System.Drawing.Point(471, 54)
        Me.txt_MiddleName.MaxLength = 50
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(111, 20)
        Me.txt_MiddleName.TabIndex = 3
        Me.txt_MiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.Color.White
        Me.txt_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FirstName.Location = New System.Drawing.Point(256, 53)
        Me.txt_FirstName.MaxLength = 50
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(131, 20)
        Me.txt_FirstName.TabIndex = 2
        Me.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_LastName
        '
        Me.txt_LastName.BackColor = System.Drawing.Color.White
        Me.txt_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LastName.Location = New System.Drawing.Point(75, 53)
        Me.txt_LastName.MaxLength = 50
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(111, 20)
        Me.txt_LastName.TabIndex = 1
        Me.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_MiddleName
        '
        Me.lbl_MiddleName.AutoSize = True
        Me.lbl_MiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MiddleName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MiddleName.Location = New System.Drawing.Point(393, 60)
        Me.lbl_MiddleName.Name = "lbl_MiddleName"
        Me.lbl_MiddleName.Size = New System.Drawing.Size(79, 12)
        Me.lbl_MiddleName.TabIndex = 10
        Me.lbl_MiddleName.Text = "Middle Name:"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(190, 61)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(68, 12)
        Me.lbl_FirstName.TabIndex = 9
        Me.lbl_FirstName.Text = "First Name:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PeachPuff
        Me.TabPage2.Controls.Add(Me.btn_TestDue)
        Me.TabPage2.Controls.Add(Me.btn_testDb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(596, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'btn_TestDue
        '
        Me.btn_TestDue.Location = New System.Drawing.Point(223, 123)
        Me.btn_TestDue.Name = "btn_TestDue"
        Me.btn_TestDue.Size = New System.Drawing.Size(150, 44)
        Me.btn_TestDue.TabIndex = 1
        Me.btn_TestDue.Text = "Test A Sample Due date"
        Me.btn_TestDue.UseVisualStyleBackColor = True
        '
        'btn_testDb
        '
        Me.btn_testDb.Location = New System.Drawing.Point(223, 231)
        Me.btn_testDb.Name = "btn_testDb"
        Me.btn_testDb.Size = New System.Drawing.Size(150, 44)
        Me.btn_testDb.TabIndex = 0
        Me.btn_testDb.Text = "Test Database Connection"
        Me.btn_testDb.UseVisualStyleBackColor = True
        '
        'Box3
        '
        Me.Box3.HeaderText = "*"
        Me.Box3.Name = "Box3"
        '
        'Box2
        '
        Me.Box2.HeaderText = "*"
        Me.Box2.Name = "Box2"
        '
        'btn_Back
        '
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.Location = New System.Drawing.Point(542, 9)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(50, 25)
        Me.btn_Back.TabIndex = 20
        Me.btn_Back.Text = "back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(628, 446)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_LastName As System.Windows.Forms.Label
    Friend WithEvents txt_ContactNum As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ContactNum As System.Windows.Forms.Label
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents btn_Register As System.Windows.Forms.Button
    Friend WithEvents lbl_EmpID As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Box3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Box2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_LastName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MiddleName As System.Windows.Forms.Label
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lnk_Reset As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_CheckPass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CheckPass As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_testDb As System.Windows.Forms.Button
    Friend WithEvents txt_Balance As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Balance As System.Windows.Forms.Label
    Friend WithEvents lst_Collector As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Collector As System.Windows.Forms.Label
    Friend WithEvents txt_Due As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Start As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents lbl_slashDays As System.Windows.Forms.Label
    Friend WithEvents btn_TestDue As System.Windows.Forms.Button
End Class
