﻿Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=ps03025.mssql.somee.com;packet size=4096;user id=locppps03025_SQLLogin_1;pwd=yiud66mdj6;data source=ps03025.mssql.somee.com;persist security info=False;initial catalog=ps03025"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=ps03025.mssql.somee.com;packet size=4096;user id=locppps03025_SQLLogin_1;pwd=yiud66mdj6;data source=ps03025.mssql.somee.com;persist security info=False;initial catalog=ps03025"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class