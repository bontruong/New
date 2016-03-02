<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chỉ_Tiêu_Xếp_Loại_Học_Sinh
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
        Me.dgvChitieu.Location = New System.Drawing.Point(10, 183)
        Me.dgvChitieu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvChitieu.Name = "dgvChitieu"
        Me.dgvChitieu.ReadOnly = True
        Me.dgvChitieu.RowHeadersVisible = False
        Me.dgvChitieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChitieu.Size = New System.Drawing.Size(391, 121)
        Me.dgvChitieu.TabIndex = 17
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
        Me.txtdtb.Location = New System.Drawing.Point(188, 91)
        Me.txtdtb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdtb.Name = "txtdtb"
        Me.txtdtb.Size = New System.Drawing.Size(131, 20)
        Me.txtdtb.TabIndex = 16
        '
        'txttenct
        '
        Me.txttenct.Enabled = False
        Me.txttenct.Location = New System.Drawing.Point(188, 58)
        Me.txttenct.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenct.Name = "txttenct"
        Me.txttenct.Size = New System.Drawing.Size(131, 20)
        Me.txttenct.TabIndex = 15
        '
        'txtmact
        '
        Me.txtmact.Enabled = False
        Me.txtmact.Location = New System.Drawing.Point(188, 23)
        Me.txtmact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmact.Name = "txtmact"
        Me.txtmact.Size = New System.Drawing.Size(131, 20)
        Me.txtmact.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Điểm Trung Bình :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tên Chỉ Tiêu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã Chỉ Tiêu :"
        '
        'btnCap
        '
        Me.btnCap.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Upload
        Me.btnCap.Location = New System.Drawing.Point(232, 133)
        Me.btnCap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCap.Name = "btnCap"
        Me.btnCap.Size = New System.Drawing.Size(100, 42)
        Me.btnCap.TabIndex = 10
        Me.btnCap.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(110, 133)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 42)
        Me.btnThem.TabIndex = 9
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Chỉ_Tiêu_Xếp_Loại_Học_Sinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 311)
        Me.Controls.Add(Me.dgvChitieu)
        Me.Controls.Add(Me.txtdtb)
        Me.Controls.Add(Me.txttenct)
        Me.Controls.Add(Me.txtmact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCap)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "Chỉ_Tiêu_Xếp_Loại_Học_Sinh"
        Me.Text = "Chỉ_Tiêu_Xếp_Loại_Học_Sinh"
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
End Class
