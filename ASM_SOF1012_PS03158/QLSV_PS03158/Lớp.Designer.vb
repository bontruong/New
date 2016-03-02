<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lớp
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.dgvdslop = New System.Windows.Forms.DataGridView()
        Me.Malop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tenlop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.TxtTenLop = New System.Windows.Forms.TextBox()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.QLSV_PS03158.My.Resources.Resources.Home
        Me.Button1.Location = New System.Drawing.Point(659, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 57
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.QLSV_PS03158.My.Resources.Resources.Delete
        Me.btnxoa.Location = New System.Drawing.Point(578, 79)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(74, 39)
        Me.btnxoa.TabIndex = 56
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgvdslop
        '
        Me.dgvdslop.AllowUserToAddRows = False
        Me.dgvdslop.AllowUserToDeleteRows = False
        Me.dgvdslop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdslop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Malop, Me.Tenlop})
        Me.dgvdslop.Location = New System.Drawing.Point(397, 125)
        Me.dgvdslop.Name = "dgvdslop"
        Me.dgvdslop.ReadOnly = True
        Me.dgvdslop.RowHeadersVisible = False
        Me.dgvdslop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdslop.Size = New System.Drawing.Size(362, 132)
        Me.dgvdslop.TabIndex = 55
        '
        'Malop
        '
        Me.Malop.DataPropertyName = "Malop"
        Me.Malop.HeaderText = "Mã Lớp"
        Me.Malop.Name = "Malop"
        Me.Malop.ReadOnly = True
        '
        'Tenlop
        '
        Me.Tenlop.DataPropertyName = "Tenlop"
        Me.Tenlop.HeaderText = "Tên Lớp"
        Me.Tenlop.Name = "Tenlop"
        Me.Tenlop.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Tên lớp :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Mã lớp :"
        '
        'btnsua
        '
        Me.btnsua.Image = Global.QLSV_PS03158.My.Resources.Resources.Edit
        Me.btnsua.Location = New System.Drawing.Point(486, 79)
        Me.btnsua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(84, 39)
        Me.btnsua.TabIndex = 52
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.QLSV_PS03158.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(397, 79)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(81, 39)
        Me.btnThem.TabIndex = 51
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'TxtTenLop
        '
        Me.TxtTenLop.Location = New System.Drawing.Point(466, 57)
        Me.TxtTenLop.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTenLop.Name = "TxtTenLop"
        Me.TxtTenLop.Size = New System.Drawing.Size(160, 20)
        Me.TxtTenLop.TabIndex = 50
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(466, 17)
        Me.txtMaLop.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.Size = New System.Drawing.Size(160, 20)
        Me.txtMaLop.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLSV_PS03158.My.Resources.Resources.tải_xuống
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Lớp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(761, 265)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.dgvdslop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.TxtTenLop)
        Me.Controls.Add(Me.txtMaLop)
        Me.Name = "Lớp"
        Me.Text = "Lớp"
        CType(Me.dgvdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents dgvdslop As DataGridView
    Friend WithEvents Malop As DataGridViewTextBoxColumn
    Friend WithEvents Tenlop As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents TxtTenLop As TextBox
    Friend WithEvents txtMaLop As TextBox
End Class
