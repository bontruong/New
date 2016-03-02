<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenDn = New System.Windows.Forms.TextBox()
        Me.txtMk = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Đăng Nhập:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu:"
        '
        'txtTenDn
        '
        Me.txtTenDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDn.Location = New System.Drawing.Point(115, 38)
        Me.txtTenDn.Name = "txtTenDn"
        Me.txtTenDn.Size = New System.Drawing.Size(148, 20)
        Me.txtTenDn.TabIndex = 2
        Me.txtTenDn.Text = "ngutdps03158"
        '
        'txtMk
        '
        Me.txtMk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMk.Location = New System.Drawing.Point(115, 64)
        Me.txtMk.Name = "txtMk"
        Me.txtMk.Size = New System.Drawing.Size(148, 20)
        Me.txtMk.TabIndex = 3
        Me.txtMk.Text = "123"
        Me.txtMk.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.tải_xuống__1_
        Me.PictureBox1.Location = New System.Drawing.Point(269, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnthoat
        '
        Me.btnthoat.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Log_out
        Me.btnthoat.Location = New System.Drawing.Point(188, 90)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 26)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Open_door
        Me.btnlogin.Location = New System.Drawing.Point(107, 90)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 26)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 160)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtMk)
        Me.Controls.Add(Me.txtTenDn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenDn As TextBox
    Friend WithEvents txtMk As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
