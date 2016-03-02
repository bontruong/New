<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewKh
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
        Me.dgvXemkh = New System.Windows.Forms.DataGridView()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvXemkh
        '
        Me.dgvXemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemkh.Location = New System.Drawing.Point(57, 119)
        Me.dgvXemkh.Name = "dgvXemkh"
        Me.dgvXemkh.Size = New System.Drawing.Size(534, 276)
        Me.dgvXemkh.TabIndex = 10
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(100, 30)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(150, 20)
        Me.txtMAKH.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã KH"
        '
        'btnDong
        '
        Me.btnDong.Image = Global.QLBH_PS03158.My.Resources.Resources.Closed_door1
        Me.btnDong.Location = New System.Drawing.Point(337, 69)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 44)
        Me.btnDong.TabIndex = 9
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemall
        '
        Me.btnXemall.Image = Global.QLBH_PS03158.My.Resources.Resources.Zoom_in
        Me.btnXemall.Location = New System.Drawing.Point(256, 70)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 43)
        Me.btnXemall.TabIndex = 7
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Image = Global.QLBH_PS03158.My.Resources.Resources.Zoom
        Me.btnXem.Location = New System.Drawing.Point(175, 70)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 43)
        Me.btnXem.TabIndex = 8
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QLBH_PS03158.My.Resources.Resources.Brick_house
        Me.btnBack.Location = New System.Drawing.Point(418, 69)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 44)
        Me.btnBack.TabIndex = 22
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewKh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBH_PS03158.My.Resources.Resources._20136121616352858730070364761
        Me.ClientSize = New System.Drawing.Size(645, 425)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvXemkh)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewKh"
        Me.Text = "ViewKh"
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvXemkh As DataGridView
    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMAKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
