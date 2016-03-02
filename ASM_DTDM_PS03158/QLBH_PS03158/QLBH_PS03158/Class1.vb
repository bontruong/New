Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Class1
    Public Function Loadkhachhang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QLCHPS03158.mssql.somee.com;packet size=4096;user id=ngutd_SQLLogin_1;pwd=121v3lashk;data source=QLCHPS03158.mssql.somee.com;persist security info=False;initial catalog=QLCHPS03158"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=QLCHPS03158.mssql.somee.com;packet size=4096;user id=ngutd_SQLLogin_1;pwd=121v3lashk;data source=QLCHPS03158.mssql.somee.com;persist security info=False;initial catalog=QLCHPS03158"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSPham As New SqlDataAdapter("select MaSP as 'Mã sản phẩm' ,TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSPham.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
