﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class NhanVien {
        public NhanVien () {
        }

        public NhanVien (string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string queQuan, int luong, string chucVu, string MatKhau ) {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.Luong = luong;
            this.ChucVu = chucVu;
            this.MatKhau = MatKhau;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public int Luong { get; set; }
        public string ChucVu { get; set; }
        public string MatKhau { get; set; }
        public string HinhAnh { get; set; }
        public string TinhTrangLamViec { get; set; }
    }
}
