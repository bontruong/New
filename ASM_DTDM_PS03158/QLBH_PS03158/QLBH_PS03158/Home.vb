Public Class Home
    Private Sub btnViewKH_Click(sender As Object, e As EventArgs) Handles btnViewKH.Click
        ViewKh.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpSP_Click(sender As Object, e As EventArgs) Handles btnUpSP.Click
        UpdateSP.Show()
        Me.Hide()

    End Sub

    Private Sub btnViewSp_Click(sender As Object, e As EventArgs) Handles btnViewSp.Click
        ViewSP.Show()
        Me.Hide()
    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Contact.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpKH_Click(sender As Object, e As EventArgs) Handles btnUpKH.Click
        UpdateKH.Show()
        Me.Hide()
    End Sub

    Private Sub btnIntro_Click(sender As Object, e As EventArgs) Handles btnIntro.Click
        Introduce.Show()
        Me.Hide()
    End Sub
End Class