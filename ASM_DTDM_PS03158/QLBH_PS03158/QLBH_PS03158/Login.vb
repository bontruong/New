Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtTenDn.Text = "ngutdps03158" And txtMk.Text = "123" Then
            MsgBox("Welcome PS03158")
            Home.Show()
            Me.Hide()
        ElseIf txtTenDn.Text = "" And txtMk.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin")
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub txtMk_TextChanged(sender As Object, e As EventArgs) Handles txtMk.TextChanged

    End Sub
End Class
