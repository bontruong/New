Imports System.IO
Public Class Môn_Học
    Dim list = New List(Of Classmh)
    Private Sub Môn_Học_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mở file để đọc
        Dim input = New StreamReader("data/MH.txt")
        While (input.EndOfStream = False)

            'Đọc một hàng từ file
            Dim Line() As String = input.ReadLine().Split(vbTab)

            'Tạo một môn học từ hàng vừa đọc được
            Dim mh As New Classmh
            mh.Mamh = Line(0)
            mh.Tenmh = Line(1)


            'Bổ sung môn học vào danh sách môn học
            List.Add(mh)



        End While
        input.Close()

        Displaylist()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Mở file để ghi
        Dim output = New StreamWriter("data/MH.txt", True)

        'Ghi một chuỗi vào file
        output.Write(txtMamh.Text)
        output.Write(vbTab)



        'Ghi một chuỗi vào file và xuống dòng
        output.WriteLine(txtTenmh.Text)

        'Đóng file
        output.Close()


    End Sub




    Private Sub dgvmonhoc_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmonhoc.RowEnter
        If dgvmonhoc.SelectedRows.Count > 0 Then
            Dim mamon As String = dgvmonhoc.SelectedRows(0).Cells(0).Value
            For Each mh As Classmh In list
                If mamon = mh.Mamh Then
                    txtMamh.Text = mh.Mamh
                    txtTenmh.Text = mh.Tenmh


                End If
            Next
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Mamon As String = txtMamh.Text
        For Each mh As Classmh In list
            If Mamon = mh.Mamh Then
                list.Remove(mh)
                Savelist()
                Displaylist()
                Exit For
            End If
        Next
    End Sub

    Sub Displaylist()
        dgvmonhoc.DataSource = Nothing
        dgvmonhoc.DataSource = list
    End Sub

    Sub Savelist()
        Dim output As New StreamWriter("data/MH.txt")
        For Each mh As Classmh In list
            output.Write(mh.Mamh)
            output.Write(vbTab)



            output.WriteLine(mh.Tenmh)
        Next
        output.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Mamon As String = txtMamh.Text
        For Each mh As Classmh In list
            If Mamon = mh.Mamh Then
                mh.Mamh = txtMamh.Text
                mh.Tenmh = txtTenmh.Text

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