Public Class LOGIN
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

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class