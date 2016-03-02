<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sinh_Viên
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvdssv = New System.Windows.Forms.DataGridView()
        Me.Masv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hoten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ngaysinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Khoahoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbbGT = New System.Windows.Forms.ComboBox()
        Me.dtpNgaysinh = New System.Windows.Forms.DateTimePicker()
        Me.txtKhoahoc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtHoten = New System.Windows.Forms.TextBox()
        Me.txtMasv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        CType(Me.dgvdssv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdssv
        '
        Me.dgvdssv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdssv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdssv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Masv, Me.Hoten, Me.GT, Me.Ngaysinh, Me.SDT, Me.Diachi, Me.Email, Me.Khoahoc})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdssv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdssv.Location = New System.Drawing.Point(1, 213)
        Me.dgvdssv.Name = "dgvdssv"
        Me.dgvdssv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdssv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdssv.RowHeadersVisible = False
        Me.dgvdssv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdssv.Size = New System.Drawing.Size(759, 258)
        Me.dgvdssv.TabIndex = 43
        '
        'Masv
        '
        Me.Masv.DataPropertyName = "Masv"
        Me.Masv.HeaderText = "Mã sv"
        Me.Masv.Name = "Masv"
        Me.Masv.ReadOnly = True
        '
        'Hoten
        '
        Me.Hoten.DataPropertyName = "Hoten"
        Me.Hoten.HeaderText = "Họ và tên"
        Me.Hoten.Name = "Hoten"
        Me.Hoten.ReadOnly = True
        '
        'GT
        '
        Me.GT.DataPropertyName = "GT"
        Me.GT.HeaderText = "Giới tính"
        Me.GT.Name = "GT"
        Me.GT.ReadOnly = True
        '
        'Ngaysinh
        '
        Me.Ngaysinh.DataPropertyName = "Ngaysinh"
        Me.Ngaysinh.HeaderText = "Ngày sinh"
        Me.Ngaysinh.Name = "Ngaysinh"
        Me.Ngaysinh.ReadOnly = True
        '
        'SDT
        '
        Me.SDT.DataPropertyName = "SDT"
        Me.SDT.HeaderText = "SĐT"
        Me.SDT.Name = "SDT"
        Me.SDT.ReadOnly = True
        '
        'Diachi
        '
        Me.Diachi.DataPropertyName = "Diachi"
        Me.Diachi.HeaderText = "Địa chỉ"
        Me.Diachi.Name = "Diachi"
        Me.Diachi.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Khoahoc
        '
        Me.Khoahoc.DataPropertyName = "Khoahoc"
        Me.Khoahoc.HeaderText = "Khóa học"
        Me.Khoahoc.Name = "Khoahoc"
        Me.Khoahoc.ReadOnly = True
        '
        'cbbGT
        '
        Me.cbbGT.FormattingEnabled = True
        Me.cbbGT.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbGT.Location = New System.Drawing.Point(362, 49)
        Me.cbbGT.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbGT.Name = "cbbGT"
        Me.cbbGT.Size = New System.Drawing.Size(61, 21)
        Me.cbbGT.TabIndex = 40
        '
        'dtpNgaysinh
        '
        Me.dtpNgaysinh.CustomFormat = ""
        Me.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaysinh.Location = New System.Drawing.Point(485, 52)
        Me.dtpNgaysinh.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgaysinh.Name = "dtpNgaysinh"
        Me.dtpNgaysinh.Size = New System.Drawing.Size(91, 20)
        Me.dtpNgaysinh.TabIndex = 39
        '
        'txtKhoahoc
        '
        Me.txtKhoahoc.Location = New System.Drawing.Point(661, 125)
        Me.txtKhoahoc.Name = "txtKhoahoc"
        Me.txtKhoahoc.Size = New System.Drawing.Size(99, 20)
        Me.txtKhoahoc.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(585, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Khóa học :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(361, 126)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 20)
        Me.txtEmail.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Ngày sinh :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Email :"
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(366, 92)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(394, 20)
        Me.txtDiachi.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Địa chỉ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(597, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "SĐT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Giới Tính :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Họ và Tên :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Mã SV :"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(638, 50)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(122, 20)
        Me.txtSDT.TabIndex = 27
        '
        'txtHoten
        '
        Me.txtHoten.Location = New System.Drawing.Point(556, 11)
        Me.txtHoten.Name = "txtHoten"
        Me.txtHoten.Size = New System.Drawing.Size(204, 20)
        Me.txtHoten.TabIndex = 26
        '
        'txtMasv
        '
        Me.txtMasv.Location = New System.Drawing.Point(362, 12)
        Me.txtMasv.Name = "txtMasv"
        Me.txtMasv.Size = New System.Drawing.Size(86, 20)
        Me.txtMasv.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Home
        Me.Button1.Location = New System.Drawing.Point(588, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.poly_welcome
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'btnthem
        '
        Me.btnthem.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Add
        Me.btnthem.Location = New System.Drawing.Point(328, 157)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 33)
        Me.btnthem.TabIndex = 44
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Delete
        Me.btnxoa.Location = New System.Drawing.Point(501, 157)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 33)
        Me.btnxoa.TabIndex = 42
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Edit
        Me.btnsua.Location = New System.Drawing.Point(412, 157)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 33)
        Me.btnsua.TabIndex = 41
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'Sinh_Viên
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(763, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgvdssv)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.cbbGT)
        Me.Controls.Add(Me.dtpNgaysinh)
        Me.Controls.Add(Me.txtKhoahoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtHoten)
        Me.Controls.Add(Me.txtMasv)
        Me.Name = "Sinh_Viên"
        Me.Text = "Sinh_Viên"
        CType(Me.dgvdssv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnthem As Button
    Friend WithEvents dgvdssv As DataGridView
    Friend WithEvents Masv As DataGridViewTextBoxColumn
    Friend WithEvents Hoten As DataGridViewTextBoxColumn
    Friend WithEvents GT As DataGridViewTextBoxColumn
    Friend WithEvents Ngaysinh As DataGridViewTextBoxColumn
    Friend WithEvents SDT As DataGridViewTextBoxColumn
    Friend WithEvents Diachi As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Khoahoc As DataGridViewTextBoxColumn
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents cbbGT As ComboBox
    Friend WithEvents dtpNgaysinh As DateTimePicker
    Friend WithEvents txtKhoahoc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtHoten As TextBox
    Friend WithEvents txtMasv As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
