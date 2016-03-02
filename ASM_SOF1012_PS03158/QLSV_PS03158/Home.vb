Public Class Home


    Private Sub BangĐiêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BangĐiêmToolStripMenuItem.Click
        Bảng_Điểm.Show()
        Me.Hide()
    End Sub

    Private Sub SinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinhViênToolStripMenuItem.Click
        Sinh_Viên.Show()
        Me.Hide()
    End Sub

    Private Sub LớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpToolStripMenuItem.Click
        Lớp.Show()
        Me.Hide()
    End Sub

    Private Sub ChỉTiêuXếpLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MônHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MônHọcToolStripMenuItem.Click
        Môn_Học.Show()
        Me.Hide()
    End Sub

    Private Sub XêpLoaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XêpLoaiToolStripMenuItem.Click
        Xếp_loại.Show()
        Me.Hide()
    End Sub
End Class