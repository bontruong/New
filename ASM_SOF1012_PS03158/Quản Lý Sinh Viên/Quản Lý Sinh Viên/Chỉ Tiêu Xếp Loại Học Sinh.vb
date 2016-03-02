Imports System.IO
Public Class Chỉ_Tiêu_Xếp_Loại_Học_Sinh
    'List chứa danh sách chỉ tiêu
    Dim dsct = New List(Of Classct)
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Select Case txtdtb.Text

            Case Is >= 9
                txtmact.Text = "Giỏi"
                txttenct.Text = "Ong Vàng"
            Case Is >= 8
                txtmact.Text = "Khá"
                txttenct.Text = "Ong Bạc"
            Case Is >= 7
                txtmact.Text = "Trung Bình"
                txttenct.Text = "Ong Đồng"
            Case Else
                txtmact.Text = "0"
                txttenct.Text = "Không đạt danh hiệu"
        End Select

        'Mở file để ghi
        Dim output = New StreamWriter("data/Chitieu.txt", True)

        'Ghi một chuỗi vào file
        output.Write(txtmact.Text)
        output.Write(vbTab)

        output.Write(txttenct.Text)
        output.Write(vbTab)


        'Ghi một chuỗi vào file và xuống dòng
        output.WriteLine(txtdtb.Text)

        'Đóng file
        output.Close()
    End Sub


    Private Sub btnCap_Click(sender As Object, e As EventArgs) Handles btnCap.Click


        'Mở file để đọc
        Dim input = New StreamReader("data/Chitieu.txt")
        While (input.EndOfStream = False)

            'Đọc một hàng từ file
            Dim Line() As String = input.ReadLine().Split(vbTab)

            'Tạo một chỉ tiêu từ hàng vừa đọc được
            Dim ct As New Classct
            ct.MaChiTieu = Line(0)
            ct.TenChiTieu = Line(1)
            ct.DiemTB = Line(2)



            'Bổ sung chỉ tiêu vào danh sách chỉ tiêu
            dsct.Add(ct)



        End While
        input.Close()

        'Hiển thị danh sách chỉ tiêu lên lưới
        dgvChitieu.DataSource = dsct

    End Sub

    Private Sub frmchitieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Mở file để đọc
        Dim input = New StreamReader("data/Chitieu.txt")
        While (input.EndOfStream = False)

            'Đọc một hàng từ file
            Dim Line() As String = input.ReadLine().Split(vbTab)

            'Tạo một chỉ tiêu từ hàng vừa đọc được
            Dim ct As New Classct
            ct.MaChiTieu = Line(0)
            ct.TenChiTieu = Line(1)
            ct.DiemTB = Line(2)



            'Bổ sung chỉ tiêu vào danh sách chỉ tiêu
            dsct.Add(ct)



        End While
        input.Close()

        'Hiển thị danh sách chỉ tiêu lên lưới
        dgvChitieu.DataSource = dsct
    End Sub
    Private Sub dgvchitieu_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChitieu.RowEnter
        If dgvChitieu.SelectedRows.Count > 0 Then
            Dim machitieu As String = dgvChitieu.SelectedRows(0).Cells(0).Value
            For Each ct As Classct In dsct
                If machitieu = ct.MaChiTieu Then
                    txtmact.Text = ct.MaChiTieu
                    txttenct.Text = ct.TenChiTieu
                    txtdtb.Text = ct.DiemTB


                End If
            Next
        End If
    End Sub
End Class