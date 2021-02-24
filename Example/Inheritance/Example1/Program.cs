using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
          // lop cha Nguoi
          Console.WriteLine("Nhap thong tin cho nguoi: ");
          Nguoi nguoi = new Nguoi();
          nguoi.nhap();
          Console.WriteLine("Hien thi thong tin cho nguoi");
          nguoi.hienThi();

          // // lop con NhanVien
          Console.WriteLine("Nhap thong tin cho nhan vien: ");
          NhanVien nhanvien = new NhanVien();
          nhanvien.nhap();
          Console.WriteLine("Hien thi thong tin cho nhan vien");
          nhanvien.hienThi();

          // lop khach hang ke thua lop nhan vien
          Console.WriteLine("Nhap thong tin cho khach hang: ");
          KhachHang khachhang = new KhachHang();
          khachhang.nhap();
        }
    }
}
