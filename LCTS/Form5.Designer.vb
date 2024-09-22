<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_List = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Box = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Home = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(350, 17)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(100, 20)
        Me.txt_Search.TabIndex = 0
        Me.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.Location = New System.Drawing.Point(299, 23)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(48, 12)
        Me.lbl_Search.TabIndex = 1
        Me.lbl_Search.Text = "Search:"
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(456, 14)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(26, 23)
        Me.btn_Search.TabIndex = 2
        Me.btn_Search.Text = "🔍"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'lbl_List
        '
        Me.lbl_List.AutoSize = True
        Me.lbl_List.BackColor = System.Drawing.Color.Transparent
        Me.lbl_List.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_List.Location = New System.Drawing.Point(182, 52)
        Me.lbl_List.Name = "lbl_List"
        Me.lbl_List.Size = New System.Drawing.Size(127, 22)
        Me.lbl_List.TabIndex = 9
        Me.lbl_List.Text = "CLIENT LIST"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Box})
        Me.DataGridView1.GridColor = System.Drawing.Color.PeachPuff
        Me.DataGridView1.Location = New System.Drawing.Point(19, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(466, 192)
        Me.DataGridView1.TabIndex = 10
        '
        'Box
        '
        Me.Box.HeaderText = "*"
        Me.Box.Name = "Box"
        '
        'btn_Edit
        '
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(403, 290)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(84, 23)
        Me.btn_Edit.TabIndex = 3
        Me.btn_Edit.Text = "Show Profile"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Home
        '
        Me.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Home.Location = New System.Drawing.Point(12, 14)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(29, 26)
        Me.btn_Home.TabIndex = 19
        Me.btn_Home.Text = "⌂"
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(506, 331)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_List)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.txt_Search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Search As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents lbl_List As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Box As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Home As System.Windows.Forms.Button
End Class
