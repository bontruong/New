<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSP
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
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvXemsp
        '
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(368, 193)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemsp.TabIndex = 9
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(414, 117)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(160, 20)
        Me.txtMASP.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã SP"
        '
        'btnDong
        '
        Me.btnDong.Image = Global.QLBH_PS03158.My.Resources.Resources.Closed_door1
        Me.btnDong.Location = New System.Drawing.Point(530, 143)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 45)
        Me.btnDong.TabIndex = 10
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemall
        '
        Me.btnXemall.Image = Global.QLBH_PS03158.My.Resources.Resources.Zoom_in
        Me.btnXemall.Location = New System.Drawing.Point(449, 143)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 44)
        Me.btnXemall.TabIndex = 7
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Image = Global.QLBH_PS03158.My.Resources.Resources.Zoom
        Me.btnXem.Location = New System.Drawing.Point(368, 143)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 44)
        Me.btnXem.TabIndex = 8
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QLBH_PS03158.My.Resources.Resources.Brick_house
        Me.btnBack.Location = New System.Drawing.Point(611, 143)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 44)
        Me.btnBack.TabIndex = 22
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBH_PS03158.My.Resources.Resources._201504171142_1604957_822760511106555_5090
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(939, 434)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSP"
        Me.Text = "ViewSP"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents dgvXemsp As DataGridView
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMASP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
