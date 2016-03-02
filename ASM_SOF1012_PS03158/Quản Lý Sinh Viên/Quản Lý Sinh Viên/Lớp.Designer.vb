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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Delete
        Me.btnxoa.Location = New System.Drawing.Point(566, 67)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(74, 39)
        Me.btnxoa.TabIndex = 15
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgvdslop
        '
        Me.dgvdslop.AllowUserToAddRows = False
        Me.dgvdslop.AllowUserToDeleteRows = False
        Me.dgvdslop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdslop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Malop, Me.Tenlop})
        Me.dgvdslop.Location = New System.Drawing.Point(385, 113)
        Me.dgvdslop.Name = "dgvdslop"
        Me.dgvdslop.ReadOnly = True
        Me.dgvdslop.RowHeadersVisible = False
        Me.dgvdslop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdslop.Size = New System.Drawing.Size(362, 132)
        Me.dgvdslop.TabIndex = 14
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
        Me.Label2.Location = New System.Drawing.Point(391, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tên lớp :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã lớp :"
        '
        'btnsua
        '
        Me.btnsua.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Edit
        Me.btnsua.Location = New System.Drawing.Point(474, 67)
        Me.btnsua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(84, 39)
        Me.btnsua.TabIndex = 11
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(385, 67)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(81, 39)
        Me.btnThem.TabIndex = 10
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'TxtTenLop
        '
        Me.TxtTenLop.Location = New System.Drawing.Point(454, 45)
        Me.TxtTenLop.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTenLop.Name = "TxtTenLop"
        Me.TxtTenLop.Size = New System.Drawing.Size(160, 20)
        Me.TxtTenLop.TabIndex = 9
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(454, 5)
        Me.txtMaLop.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.Size = New System.Drawing.Size(160, 20)
        Me.txtMaLop.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Home
        Me.Button1.Location = New System.Drawing.Point(647, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 47
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.poly_welcome
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Lớp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(753, 252)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
