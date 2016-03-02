<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.txtMk = New System.Windows.Forms.TextBox()
        Me.txtTenDn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMk
        '
        Me.txtMk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMk.Location = New System.Drawing.Point(141, 131)
        Me.txtMk.Name = "txtMk"
        Me.txtMk.Size = New System.Drawing.Size(148, 20)
        Me.txtMk.TabIndex = 17
        Me.txtMk.Text = "123"
        Me.txtMk.UseSystemPasswordChar = True
        '
        'txtTenDn
        '
        Me.txtTenDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDn.Location = New System.Drawing.Point(141, 105)
        Me.txtTenDn.Name = "txtTenDn"
        Me.txtTenDn.Size = New System.Drawing.Size(148, 20)
        Me.txtTenDn.TabIndex = 16
        Me.txtTenDn.Text = "ngutdps03158"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tên Đăng Nhập:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLBH_PS03158.My.Resources.Resources.tải_xuống__1_
        Me.PictureBox1.Location = New System.Drawing.Point(295, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnthoat
        '
        Me.btnthoat.Image = Global.QLBH_PS03158.My.Resources.Resources.Closed_door
        Me.btnthoat.Location = New System.Drawing.Point(214, 157)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 26)
        Me.btnthoat.TabIndex = 19
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Image = Global.QLBH_PS03158.My.Resources.Resources.Login
        Me.btnlogin.Location = New System.Drawing.Point(133, 157)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 26)
        Me.btnlogin.TabIndex = 18
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtMk)
        Me.Controls.Add(Me.txtTenDn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnthoat As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtMk As TextBox
    Friend WithEvents txtTenDn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
