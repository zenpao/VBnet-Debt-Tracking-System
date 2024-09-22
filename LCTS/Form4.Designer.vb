<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lbl_List = New System.Windows.Forms.Label()
        Me.lst_MonitorAll = New System.Windows.Forms.ListBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_Sum = New System.Windows.Forms.Label()
        Me.lbl_Bar = New System.Windows.Forms.Label()
        Me.btn_Home = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_List
        '
        Me.lbl_List.AutoSize = True
        Me.lbl_List.BackColor = System.Drawing.Color.Transparent
        Me.lbl_List.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_List.Location = New System.Drawing.Point(25, 29)
        Me.lbl_List.Name = "lbl_List"
        Me.lbl_List.Size = New System.Drawing.Size(43, 22)
        Me.lbl_List.TabIndex = 8
        Me.lbl_List.Text = "List"
        '
        'lst_MonitorAll
        '
        Me.lst_MonitorAll.BackColor = System.Drawing.Color.White
        Me.lst_MonitorAll.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_MonitorAll.FormattingEnabled = True
        Me.lst_MonitorAll.Location = New System.Drawing.Point(56, 64)
        Me.lst_MonitorAll.Name = "lst_MonitorAll"
        Me.lst_MonitorAll.ScrollAlwaysVisible = True
        Me.lst_MonitorAll.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lst_MonitorAll.Size = New System.Drawing.Size(348, 130)
        Me.lst_MonitorAll.Sorted = True
        Me.lst_MonitorAll.TabIndex = 12
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.Red
        Me.lbl_Total.Location = New System.Drawing.Point(63, 225)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(56, 22)
        Me.lbl_Total.TabIndex = 13
        Me.lbl_Total.Text = "Total"
        '
        'lbl_Sum
        '
        Me.lbl_Sum.AutoSize = True
        Me.lbl_Sum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Sum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sum.ForeColor = System.Drawing.Color.Black
        Me.lbl_Sum.Location = New System.Drawing.Point(289, 229)
        Me.lbl_Sum.Name = "lbl_Sum"
        Me.lbl_Sum.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Sum.TabIndex = 14
        Me.lbl_Sum.Text = "Total"
        '
        'lbl_Bar
        '
        Me.lbl_Bar.AutoSize = True
        Me.lbl_Bar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Bar.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bar.Location = New System.Drawing.Point(36, 199)
        Me.lbl_Bar.Name = "lbl_Bar"
        Me.lbl_Bar.Size = New System.Drawing.Size(377, 14)
        Me.lbl_Bar.TabIndex = 35
        Me.lbl_Bar.Text = "--------------------------------------------------------------------------"
        Me.lbl_Bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Home
        '
        Me.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Home.Location = New System.Drawing.Point(388, 14)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(29, 26)
        Me.btn_Home.TabIndex = 36
        Me.btn_Home.Text = "⌂"
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(438, 277)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.lbl_Bar)
        Me.Controls.Add(Me.lbl_Sum)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.lst_MonitorAll)
        Me.Controls.Add(Me.lbl_List)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collector's List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_List As System.Windows.Forms.Label
    Friend WithEvents lst_MonitorAll As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Sum As System.Windows.Forms.Label
    Friend WithEvents lbl_Bar As System.Windows.Forms.Label
    Friend WithEvents btn_Home As System.Windows.Forms.Button
End Class
