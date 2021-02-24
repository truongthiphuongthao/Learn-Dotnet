using System;

namespace Example1
{
    class KhachHang : NhanVien
    {
      private String tuoi;
      public KhachHang(){}

      // su dung lai constructor cua lop cha
      public KhachHang(String maSo, String hoTen, String gioiTinh, String bangCap, String tuoi)
      : base(maSo, hoTen, gioiTinh, bangCap)
      {
        this.tuoi = tuoi;
      }

      // overriding ham nhap
      public override void nhap(){
        base.nhap();
        Console.Write("Tuoi: ");
        tuoi = Console.ReadLine();
      }

      // public override void hienThi(){
      //   base.hienThi();
      //   Console.WriteLine("Tuoi: ", tuoi);
      // }

    }
}
