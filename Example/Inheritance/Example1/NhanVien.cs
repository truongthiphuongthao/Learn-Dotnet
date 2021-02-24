using System;

namespace Example1
{
    class NhanVien : Nguoi
    {
      protected String bangCap;

      public NhanVien(){}

      // su dung lai constructor cua lop cha
      public NhanVien(String maSo, String hoTen, String gioiTinh, String bangCap)
      : base(maSo, hoTen, gioiTinh)
      {
          this.bangCap = bangCap;
      }

      // overriding ham nhap
      public override void nhap(){
        base.nhap();
        Console.Write("Bang cap: ");
        bangCap = Console.ReadLine();
      }

      // overriding ham hien thi
      public sealed override void hienThi(){
        base.hienThi();
        Console.WriteLine("Bang cap: {0}", bangCap);
      }
    }
}
