Public Class frmLogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtTenDn.Text = "ngutdps03158" And txtMk.Text = "123" Then
            MsgBox("Welcome PS03158")
            Home.Show()
            Me.Hide()
        Else
            txtTenDn.Text = "" And txtMk.Text = ""
            MsgBox("Vui lòng nhập đầy đủ thông tin")
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class
