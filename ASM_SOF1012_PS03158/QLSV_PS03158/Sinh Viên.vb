Imports System.IO

Public Class Sinh_Viên
    Dim list As New List(Of Classsv)
    Private Sub Sinh_Viên_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mở file để đọc'
        Dim input As New StreamReader("data/SV.txt")
        While Not input.EndOfStream
            'để đọc một hàng từ file'
            Dim line() As String = input.ReadLine().Split(vbTab)

            'tạo một sinh viên từ dòng vừa đọc'
            Dim sv As New Classsv()
            sv.Masv = line(0)
            sv.Hoten = line(1)
            sv.GT = line(2)
            sv.Ngaysinh = line(3)
            sv.SDT = line(4)
            sv.Diachi = line(5)
            sv.Email = line(6)
            sv.Khoahoc = line(7)

            'bổ sung sinh viên vào list'
            List.Add(sv)
        End While
        input.Close()

        Displaylist()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        'Mở file để ghi
        Dim output As New StreamWriter("data/SV.txt", True)

        'Ghi một chuỗi vào file
        output.Write(txtMasv.Text)
        output.Write(vbTab)

        output.Write(txtHoten.Text)
        output.Write(vbTab)

        output.Write(cbbGT.Text)
        output.Write(vbTab)

        output.Write(dtpNgaysinh.Value)
        output.Write(vbTab)

        output.Write(txtSDT.Text)
        output.Write(vbTab)

        output.Write(txtDiachi.Text)
        output.Write(vbTab)

        output.Write(txtEmail.Text)
        output.Write(vbTab)



        'Ghi một chuỗi vào file và xuống dòng
        output.WriteLine(txtKhoahoc.Text)

        'Đóng file
        output.Close()
        Displaylist()

    End Sub
    Private Sub dgvdssv_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdssv.RowEnter
        If dgvdssv.SelectedRows.Count > 0 Then
            Dim masv As String = dgvdssv.SelectedRows(0).Cells(0).Value
            For Each sv As Classsv In list
                If masv = sv.Masv Then
                    txtMasv.Text = sv.Masv
                    txtHoten.Text = sv.Hoten
                    cbbGT.Text = sv.GT
                    dtpNgaysinh.Value = sv.Ngaysinh
                    txtSDT.Text = sv.SDT
                    txtDiachi.Text = sv.Diachi
                    txtEmail.Text = sv.Email
                    txtKhoahoc.Text = sv.Khoahoc
                End If
            Next
        End If
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Masv As String = txtMasv.Text
        For Each sv As Classsv In list
            If Masv = sv.Masv Then
                list.Remove(sv)
                Savelist()
                Displaylist()
                Exit For
            End If
        Next
    End Sub

    Sub Displaylist()
        dgvdssv.DataSource = Nothing
        dgvdssv.DataSource = list
    End Sub

    Sub Savelist()
        Dim output As New StreamWriter("data/SV.txt")
        For Each sv As Classsv In list
            output.Write(sv.Masv)
            output.Write(vbTab)

            output.Write(sv.Hoten)
            output.Write(vbTab)

            output.Write(sv.GT)
            output.Write(vbTab)

            output.Write(sv.Ngaysinh)
            output.Write(vbTab)

            output.Write(sv.SDT)
            output.Write(vbTab)

            output.Write(sv.Diachi)
            output.Write(vbTab)

            output.Write(sv.Email)
            output.Write(vbTab)

            output.WriteLine(sv.Khoahoc)
        Next
        output.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Masv As String = txtMasv.Text
        For Each sv As Classsv In list
            If Masv = sv.Masv Then
                sv.Masv = txtMasv.Text
                sv.Hoten = txtHoten.Text
                sv.GT = cbbGT.Text
                sv.Ngaysinh = dtpNgaysinh.Value
                sv.SDT = txtSDT.Text
                sv.Diachi = txtDiachi.Text
                sv.Email = txtEmail.Text
                sv.Khoahoc = txtKhoahoc.Text
                Savelist()
                Displaylist()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class