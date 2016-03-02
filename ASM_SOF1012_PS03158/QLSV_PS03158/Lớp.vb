Imports System.IO
Public Class Lớp

    'List chứa danh sách lớp
    Dim list = New List(Of Classlop)
    Private Sub Lớp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mở file để đọc'
        Dim input As New StreamReader("data/Class.txt")
        While Not input.EndOfStream
            'để đọc một hàng từ file'
            Dim line() As String = input.ReadLine().Split(vbTab)

            'tạo một sinh viên từ dòng vừa đọc'
            Dim lp As New Classlop()
            lp.Malop = line(0)
            lp.TenLop = line(1)


            'bổ sung sinh viên vào list'
            list.Add(lp)
        End While
        input.Close()

        Displaylist()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Mở file để ghi
        Dim output = New StreamWriter("data/Class.txt", True)

        'Ghi một chuỗi vào file
        output.Write(txtMaLop.Text)
        output.Write(vbTab)



        'Ghi một chuỗi vào file và xuống dòng
        output.WriteLine(TxtTenLop.Text)

        'Đóng file
        output.Close()


    End Sub




    Private Sub dgvdslop_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdslop.RowEnter
        If dgvdslop.SelectedRows.Count > 0 Then
            Dim malop As String = dgvdslop.SelectedRows(0).Cells(0).Value
            For Each lp As Classlop In list
                If malop = lp.Malop Then
                    txtMaLop.Text = lp.Malop
                    TxtTenLop.Text = lp.TenLop


                End If
            Next
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim malop As String = txtMaLop.Text
        For Each lp As Classlop In list
            If malop = lp.Malop Then
                list.Remove(lp)
                Savelist()
                Displaylist()
                Exit For
            End If
        Next
    End Sub

    Sub Displaylist()
        dgvdslop.DataSource = Nothing
        dgvdslop.DataSource = list
    End Sub

    Sub Savelist()
        Dim output As New StreamWriter("data/Class.txt")
        For Each lp As Classlop In list
            output.Write(lp.Malop)
            output.Write(vbTab)



            output.WriteLine(lp.TenLop)
        Next
        output.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Malop As String = txtMaLop.Text
        For Each lp As Classlop In list
            If Malop = lp.Malop Then
                lp.Malop = txtMaLop.Text
                lp.TenLop = TxtTenLop.Text

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