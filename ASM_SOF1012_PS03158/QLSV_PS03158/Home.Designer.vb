﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LớpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MônHọcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BangĐiêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.XêpLoaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinhViênToolStripMenuItem, Me.LớpToolStripMenuItem, Me.MônHọcToolStripMenuItem, Me.BangĐiêmToolStripMenuItem, Me.XêpLoaiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SinhViênToolStripMenuItem
        '
        Me.SinhViênToolStripMenuItem.Name = "SinhViênToolStripMenuItem"
        Me.SinhViênToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SinhViênToolStripMenuItem.Text = "Sinh Viên"
        '
        'LớpToolStripMenuItem
        '
        Me.LớpToolStripMenuItem.Name = "LớpToolStripMenuItem"
        Me.LớpToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.LớpToolStripMenuItem.Text = "Lớp"
        '
        'MônHọcToolStripMenuItem
        '
        Me.MônHọcToolStripMenuItem.Name = "MônHọcToolStripMenuItem"
        Me.MônHọcToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MônHọcToolStripMenuItem.Text = "Môn Học"
        '
        'BangĐiêmToolStripMenuItem
        '
        Me.BangĐiêmToolStripMenuItem.Name = "BangĐiêmToolStripMenuItem"
        Me.BangĐiêmToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.BangĐiêmToolStripMenuItem.Text = "Bảng Điểm"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLSV_PS03158.My.Resources.Resources.sinh_vien_poly_icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(628, 433)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'XêpLoaiToolStripMenuItem
        '
        Me.XêpLoaiToolStripMenuItem.Name = "XêpLoaiToolStripMenuItem"
        Me.XêpLoaiToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.XêpLoaiToolStripMenuItem.Text = "Xếp Loại"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SinhViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LớpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MônHọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BangĐiêmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XêpLoaiToolStripMenuItem As ToolStripMenuItem
End Class
