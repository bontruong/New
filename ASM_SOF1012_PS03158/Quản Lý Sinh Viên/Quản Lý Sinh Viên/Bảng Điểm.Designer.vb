<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bảng_Điểm
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
        Me.txtdiem3 = New System.Windows.Forms.TextBox()
        Me.txtdiem2 = New System.Windows.Forms.TextBox()
        Me.txtdiem1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldtb = New System.Windows.Forms.Label()
        Me.lstbangdiem = New System.Windows.Forms.ListBox()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.lbldiem3 = New System.Windows.Forms.Label()
        Me.lbldiem2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Home = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdiem3
        '
        Me.txtdiem3.Location = New System.Drawing.Point(82, 104)
        Me.txtdiem3.Name = "txtdiem3"
        Me.txtdiem3.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem3.TabIndex = 34
        '
        'txtdiem2
        '
        Me.txtdiem2.Location = New System.Drawing.Point(82, 67)
        Me.txtdiem2.Name = "txtdiem2"
        Me.txtdiem2.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem2.TabIndex = 33
        '
        'txtdiem1
        '
        Me.txtdiem1.Location = New System.Drawing.Point(82, 29)
        Me.txtdiem1.Name = "txtdiem1"
        Me.txtdiem1.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem1.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Điểm trung bình cả lớp:"
        '
        'lbldtb
        '
        Me.lbldtb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldtb.Enabled = False
        Me.lbldtb.Location = New System.Drawing.Point(446, 187)
        Me.lbldtb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldtb.Name = "lbldtb"
        Me.lbldtb.Size = New System.Drawing.Size(78, 26)
        Me.lbldtb.TabIndex = 30
        '
        'lstbangdiem
        '
        Me.lstbangdiem.FormattingEnabled = True
        Me.lstbangdiem.Location = New System.Drawing.Point(188, 12)
        Me.lstbangdiem.Name = "lstbangdiem"
        Me.lstbangdiem.Size = New System.Drawing.Size(336, 147)
        Me.lstbangdiem.TabIndex = 29
        '
        'btnnhap
        '
        Me.btnnhap.Location = New System.Drawing.Point(74, 161)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnnhap.TabIndex = 27
        Me.btnnhap.Text = "Nhập"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'lbldiem3
        '
        Me.lbldiem3.AutoSize = True
        Me.lbldiem3.Location = New System.Drawing.Point(13, 107)
        Me.lbldiem3.Name = "lbldiem3"
        Me.lbldiem3.Size = New System.Drawing.Size(63, 13)
        Me.lbldiem3.TabIndex = 26
        Me.lbldiem3.Text = "Điểm môn 3"
        '
        'lbldiem2
        '
        Me.lbldiem2.AutoSize = True
        Me.lbldiem2.Location = New System.Drawing.Point(13, 70)
        Me.lbldiem2.Name = "lbldiem2"
        Me.lbldiem2.Size = New System.Drawing.Size(63, 13)
        Me.lbldiem2.TabIndex = 25
        Me.lbldiem2.Text = "Điểm môn 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Điểm môn 1"
        '
        'Home
        '
        Me.Home.Image = Global.Quản_Lý_Sinh_Viên.My.Resources.Resources.Home
        Me.Home.Location = New System.Drawing.Point(13, 292)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(75, 70)
        Me.Home.TabIndex = 35
        Me.Home.UseMnemonic = False
        Me.Home.UseVisualStyleBackColor = True
        '
        'Bảng_Điểm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 369)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.txtdiem3)
        Me.Controls.Add(Me.txtdiem2)
        Me.Controls.Add(Me.txtdiem1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbldtb)
        Me.Controls.Add(Me.lstbangdiem)
        Me.Controls.Add(Me.btnnhap)
        Me.Controls.Add(Me.lbldiem3)
        Me.Controls.Add(Me.lbldiem2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bảng_Điểm"
        Me.Text = "Bảng_Điểm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Home As Button
    Friend WithEvents txtdiem3 As TextBox
    Friend WithEvents txtdiem2 As TextBox
    Friend WithEvents txtdiem1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbldtb As Label
    Friend WithEvents lstbangdiem As ListBox
    Friend WithEvents btnnhap As Button
    Friend WithEvents lbldiem3 As Label
    Friend WithEvents lbldiem2 As Label
    Friend WithEvents Label1 As Label
End Class
