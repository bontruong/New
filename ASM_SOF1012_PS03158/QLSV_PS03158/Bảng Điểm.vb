Public Class Bảng_Điểm
    Dim BangDiem(0 To 9, 0 To 2) As Integer   ' Khai báo biến mảng 2 chiều có số phần tử là 10x 3=30 phần tử
    Dim SoSinhVien, hang, cot As Integer      ' lưu số lượng sinh viên hiện có lúc đầu là 0, mỗi lần tăng lên 1


    Private Sub Bảng_Điểm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoSinhVien = 0
    End Sub


    Private Sub lbldtb_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub lstbangdiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbangdiem.SelectedIndexChanged

    End Sub




    'khai báo điểm trung bình
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim dtb As Double
        Dim tongdiemsv As Integer

        'gán điểm cho sinh viên
        BangDiem(SoSinhVien, 0) = Convert.ToInt32(txtdiem1.Text)
        BangDiem(SoSinhVien, 1) = Convert.ToInt32(txtdiem2.Text)
        BangDiem(SoSinhVien, 2) = Convert.ToInt32(txtdiem3.Text)
        'tính điểm trung bình cho sinh viên
        tongdiemsv = 0
        For cot = 0 To BangDiem.GetUpperBound(1)
            tongdiemsv = tongdiemsv + BangDiem(SoSinhVien, cot)
        Next
        dtb = tongdiemsv / (BangDiem.GetUpperBound(1) + 1) 'chia điểm cho tổng số cột nhập vào
        lstbangdiem.Items.Add("Sinhvien" & SoSinhVien.ToString() + vbTab + BangDiem(SoSinhVien, 0).ToString() + vbTab + BangDiem(SoSinhVien, 1).ToString() + vbTab + BangDiem(SoSinhVien, 2).ToString() + vbTab + String.Format("{0:F}", dtb))
        SoSinhVien = SoSinhVien + 1 'mỗi lần nhập vào sẽ thêm 1 sinh viên mới
    End Sub
End Class