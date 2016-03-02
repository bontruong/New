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
        Me.lstbangdiem = New System.Windows.Forms.ListBox()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.lbldiem3 = New System.Windows.Forms.Label()
        Me.lbldiem2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdiem3
        '
        Me.txtdiem3.Location = New System.Drawing.Point(88, 99)
        Me.txtdiem3.Name = "txtdiem3"
        Me.txtdiem3.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem3.TabIndex = 45
        '
        'txtdiem2
        '
        Me.txtdiem2.Location = New System.Drawing.Point(88, 62)
        Me.txtdiem2.Name = "txtdiem2"
        Me.txtdiem2.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem2.TabIndex = 44
        '
        'txtdiem1
        '
        Me.txtdiem1.Location = New System.Drawing.Point(88, 24)
        Me.txtdiem1.Name = "txtdiem1"
        Me.txtdiem1.Size = New System.Drawing.Size(100, 20)
        Me.txtdiem1.TabIndex = 43
        '
        'lstbangdiem
        '
        Me.lstbangdiem.FormattingEnabled = True
        Me.lstbangdiem.Location = New System.Drawing.Point(194, 7)
        Me.lstbangdiem.Name = "lstbangdiem"
        Me.lstbangdiem.Size = New System.Drawing.Size(336, 147)
        Me.lstbangdiem.TabIndex = 40
        '
        'btnnhap
        '
        Me.btnnhap.Location = New System.Drawing.Point(80, 156)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnnhap.TabIndex = 39
        Me.btnnhap.Text = "Nhập"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'lbldiem3
        '
        Me.lbldiem3.AutoSize = True
        Me.lbldiem3.Location = New System.Drawing.Point(19, 102)
        Me.lbldiem3.Name = "lbldiem3"
        Me.lbldiem3.Size = New System.Drawing.Size(63, 13)
        Me.lbldiem3.TabIndex = 38
        Me.lbldiem3.Text = "Điểm môn 3"
        '
        'lbldiem2
        '
        Me.lbldiem2.AutoSize = True
        Me.lbldiem2.Location = New System.Drawing.Point(19, 65)
        Me.lbldiem2.Name = "lbldiem2"
        Me.lbldiem2.Size = New System.Drawing.Size(63, 13)
        Me.lbldiem2.TabIndex = 37
        Me.lbldiem2.Text = "Điểm môn 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Điểm môn 1"
        '
        'btnHome
        '
        Me.btnHome.Image = Global.QLSV_PS03158.My.Resources.Resources.Home
        Me.btnHome.Location = New System.Drawing.Point(536, 8)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 146)
        Me.btnHome.TabIndex = 46
        Me.btnHome.UseMnemonic = False
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Bảng_Điểm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 184)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.txtdiem3)
        Me.Controls.Add(Me.txtdiem2)
        Me.Controls.Add(Me.txtdiem1)
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

    Friend WithEvents btnHome As Button
    Friend WithEvents txtdiem3 As TextBox
    Friend WithEvents txtdiem2 As TextBox
    Friend WithEvents txtdiem1 As TextBox
    Friend WithEvents lstbangdiem As ListBox
    Friend WithEvents btnnhap As Button
    Friend WithEvents lbldiem3 As Label
    Friend WithEvents lbldiem2 As Label
    Friend WithEvents Label1 As Label
End Class
