<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Môn_Học
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
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txtTenmh = New System.Windows.Forms.TextBox()
        Me.txtMamh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.dgvmonhoc = New System.Windows.Forms.DataGridView()
        Me.Mamh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tenmh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsua
        '
        Me.btnsua.Image = Global.QLSV_PS03158.My.Resources.Resources.Edit
        Me.btnsua.Location = New System.Drawing.Point(104, 66)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 36)
        Me.btnsua.TabIndex = 15
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txtTenmh
        '
        Me.txtTenmh.Location = New System.Drawing.Point(115, 42)
        Me.txtTenmh.Name = "txtTenmh"
        Me.txtTenmh.Size = New System.Drawing.Size(159, 20)
        Me.txtTenmh.TabIndex = 14
        '
        'txtMamh
        '
        Me.txtMamh.Location = New System.Drawing.Point(115, 6)
        Me.txtMamh.Name = "txtMamh"
        Me.txtMamh.Size = New System.Drawing.Size(159, 20)
        Me.txtMamh.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tên môn học :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã môn học :"
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.QLSV_PS03158.My.Resources.Resources.Delete
        Me.btnxoa.Location = New System.Drawing.Point(187, 66)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 36)
        Me.btnxoa.TabIndex = 10
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgvmonhoc
        '
        Me.dgvmonhoc.AllowUserToAddRows = False
        Me.dgvmonhoc.AllowUserToDeleteRows = False
        Me.dgvmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmonhoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mamh, Me.Tenmh})
        Me.dgvmonhoc.Location = New System.Drawing.Point(12, 108)
        Me.dgvmonhoc.Name = "dgvmonhoc"
        Me.dgvmonhoc.ReadOnly = True
        Me.dgvmonhoc.RowHeadersVisible = False
        Me.dgvmonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmonhoc.Size = New System.Drawing.Size(331, 150)
        Me.dgvmonhoc.TabIndex = 8
        '
        'Mamh
        '
        Me.Mamh.DataPropertyName = "Mamh"
        Me.Mamh.HeaderText = "Mã Môn Học"
        Me.Mamh.Name = "Mamh"
        Me.Mamh.ReadOnly = True
        '
        'Tenmh
        '
        Me.Tenmh.DataPropertyName = "Tenmh"
        Me.Tenmh.HeaderText = "Tên Môn Học"
        Me.Tenmh.Name = "Tenmh"
        Me.Tenmh.ReadOnly = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.QLSV_PS03158.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(12, 66)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 36)
        Me.btnThem.TabIndex = 9
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.QLSV_PS03158.My.Resources.Resources.Home
        Me.Button1.Location = New System.Drawing.Point(268, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 58
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Môn_Học
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(353, 260)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.txtTenmh)
        Me.Controls.Add(Me.txtMamh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvmonhoc)
        Me.Name = "Môn_Học"
        Me.Text = "Môn_Học"
        CType(Me.dgvmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsua As Button
    Friend WithEvents txtTenmh As TextBox
    Friend WithEvents txtMamh As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvmonhoc As DataGridView
    Friend WithEvents Mamh As DataGridViewTextBoxColumn
    Friend WithEvents Tenmh As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
