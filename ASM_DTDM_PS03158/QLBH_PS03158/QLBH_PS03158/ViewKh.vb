Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class ViewKh

    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLCHPS03158.mssql.somee.com;packet size=4096;user id=ngutd_SQLLogin_1;pwd=121v3lashk;data source=QLCHPS03158.mssql.somee.com;persist security info=False;initial catalog=QLCHPS03158"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG where MaKH='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvXemkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemkh.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemkh.CellContentClick
        Dim click As Integer = dgvXemkh.CurrentCell.RowIndex
        txtMAKH.Text = dgvXemkh.Item(0, click).Value
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa chỉ' from KHACHHANG", conn)
        conn.Open()
        load.Fill(db)
        dgvXemkh.DataSource = db.DefaultView
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemkh.DataSource = hienthi.Loadkhachhang.Tables(0)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ViewKh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class