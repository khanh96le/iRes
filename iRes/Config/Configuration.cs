﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Title.Config {
    public class Configuration {

        public string GetProjectLinkDirectory()
        {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }

        public string DATA_SOURCE = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";
        //public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

        // Proceduces of NhanVien
        public string PROC_GET_LIST_NHANVIEN = "DanhSachNhanVien";
        public string PROC_INSERT_NHANVIEN = "ThemNhanVien";
        public string PROC_DELETE_NHANVIEN = "XoaNhanVien";
        public string PROC_UPDATE_NHANVIEN = "SuaNhanVien";

        // Proceduces of KhachHang
        public string PROC_GET_LIST_KHACHHANG = "GetListKhachHang";
        public string PROC_UPDATE_KHACHHANG = "SuaKhachHang";
        public string PROC_DELETE_KHACHHANG = "XoaKhachHang";
        public string PROC_INSERT_KHACHHANG  = "ThemKhachHang";

        public string PROC_GET_LIST_MONAN = "GetListMonAn";

        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\Tran\Documents\Visual Studio 2012\Projects\iRes\iRes\Resources\MonAn\'
                                                + hinhanh as nvarchar(4000)) as [Hình ảnh],
                                                MaMon as [Mã món ăn], 
                                                TenMon as [Tên món ăn],
                                                MaNhom as [Mã nhóm],
                                                DonGia as [Đơn giá],
                                                SoLuong as [Số lương] from MonAn";

        public string TAB_NHAN_VIEN = "TabNhanVien";
        public string TAB_KHACH_HANG = "TabKhachHang";
        public string TAB_MON_AN = "TabMonAn";
        public string TAB_NHOM_MON = "TabNhomMon";



    }
}
