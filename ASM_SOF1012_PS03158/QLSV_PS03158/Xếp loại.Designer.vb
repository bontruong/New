<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Xếp_loại
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
        Me.dgvChitieu = New System.Windows.Forms.DataGridView()
        Me.MaChiTieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenChiTieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdtb = New System.Windows.Forms.TextBox()
        Me.txttenct = New System.Windows.Forms.TextBox()
        Me.txtmact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCap = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvChitieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvChitieu
        '
        Me.dgvChitieu.AllowUserToAddRows = False
        Me.dgvChitieu.AllowUserToDeleteRows = False
        Me.dgvChitieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChitieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChitieu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaChiTieu, Me.TenChiTieu, Me.DiemTB})
        Me.dgvChitieu.Location = New System.Drawing.Point(13, 167)
        Me.dgvChitieu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvChitieu.Name = "dgvChitieu"
        Me.dgvChitieu.ReadOnly = True
        Me.dgvChitieu.RowHeadersVisible = False
        Me.dgvChitieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChitieu.Size = New System.Drawing.Size(391, 121)
        Me.dgvChitieu.TabIndex = 26
        '
        'MaChiTieu
        '
        Me.MaChiTieu.DataPropertyName = "MaChiTieu"
        Me.MaChiTieu.HeaderText = "Mã Chỉ Tiêu"
        Me.MaChiTieu.Name = "MaChiTieu"
        Me.MaChiTieu.ReadOnly = True
        '
        'TenChiTieu
        '
        Me.TenChiTieu.DataPropertyName = "TenChiTieu"
        Me.TenChiTieu.HeaderText = "Tên Chỉ Tiêu"
        Me.TenChiTieu.Name = "TenChiTieu"
        Me.TenChiTieu.ReadOnly = True
        '
        'DiemTB
        '
        Me.DiemTB.DataPropertyName = "DiemTB"
        Me.DiemTB.HeaderText = "Điểm Trung Bình"
        Me.DiemTB.Name = "DiemTB"
        Me.DiemTB.ReadOnly = True
        '
        'txtdtb
        '
        Me.txtdtb.Location = New System.Drawing.Point(191, 75)
        Me.txtdtb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdtb.Name = "txtdtb"
        Me.txtdtb.Size = New System.Drawing.Size(131, 20)
        Me.txtdtb.TabIndex = 25
        '
        'txttenct
        '
        Me.txttenct.Enabled = False
        Me.txttenct.Location = New System.Drawing.Point(191, 42)
        Me.txttenct.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenct.Name = "txttenct"
        Me.txttenct.Size = New System.Drawing.Size(131, 20)
        Me.txttenct.TabIndex = 24
        '
        'txtmact
        '
        Me.txtmact.Enabled = False
        Me.txtmact.Location = New System.Drawing.Point(191, 7)
        Me.txtmact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmact.Name = "txtmact"
        Me.txtmact.Size = New System.Drawing.Size(131, 20)
        Me.txtmact.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Điểm Trung Bình :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tên Chỉ Tiêu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mã Chỉ Tiêu :"
        '
        'btnCap
        '
        Me.btnCap.Image = Global.QLSV_PS03158.My.Resources.Resources.Upload
        Me.btnCap.Location = New System.Drawing.Point(182, 117)
        Me.btnCap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCap.Name = "btnCap"
        Me.btnCap.Size = New System.Drawing.Size(100, 42)
        Me.btnCap.TabIndex = 19
        Me.btnCap.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.QLSV_PS03158.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(74, 117)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 42)
        Me.btnThem.TabIndex = 18
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.QLSV_PS03158.My.Resources.Resources.Home
        Me.Button1.Location = New System.Drawing.Point(289, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 42)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Xếp_loại
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 291)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvChitieu)
        Me.Controls.Add(Me.txtdtb)
        Me.Controls.Add(Me.txttenct)
        Me.Controls.Add(Me.txtmact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCap)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "Xếp_loại"
        Me.Text = "Xếp_loại"
        CType(Me.dgvChitieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvChitieu As DataGridView
    Friend WithEvents MaChiTieu As DataGridViewTextBoxColumn
    Friend WithEvents TenChiTieu As DataGridViewTextBoxColumn
    Friend WithEvents DiemTB As DataGridViewTextBoxColumn
    Friend WithEvents txtdtb As TextBox
    Friend WithEvents txttenct As TextBox
    Friend WithEvents txtmact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCap As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Button1 As Button
End Class
