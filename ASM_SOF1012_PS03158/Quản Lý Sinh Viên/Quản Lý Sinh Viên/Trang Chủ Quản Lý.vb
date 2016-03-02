Public Class Trang_Chủ_Quản_Lý


    Private Sub SinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinhViênToolStripMenuItem.Click
        Sinh_Viên.Show()
        Me.Hide()
    End Sub

    Private Sub MônHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MônHọcToolStripMenuItem.Click
        Môn_Học.Show()
        Me.Hide()
    End Sub

    Private Sub LớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpToolStripMenuItem.Click
        Lớp.Show()
        Me.Hide()
    End Sub

    Private Sub ChỉTiêuXếpLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉTiêuXếpLoạiToolStripMenuItem.Click
        Chỉ_Tiêu_Xếp_Loại_Học_Sinh.Show()
        Me.Hide()
    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BangĐiêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BangĐiêmToolStripMenuItem.Click
        Bảng_Điểm.Show()
        Me.Hide()
    End Sub
End Class