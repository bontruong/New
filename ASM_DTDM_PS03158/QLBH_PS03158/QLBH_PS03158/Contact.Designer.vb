﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contact))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 281)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(317, 142)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QLBH_PS03158.My.Resources.Resources.Brick_house
        Me.btnBack.Location = New System.Drawing.Point(553, 332)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 91)
        Me.btnBack.TabIndex = 2
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBH_PS03158.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 425)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.RichTextBox1)
        Me.DoubleBuffered = True
        Me.Name = "Contact"
        Me.Text = "Contact"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnBack As Button
End Class
