using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Example1
{
    class Nguoi
    {
      protected String maSo;
      protected String hoTen;
      protected String gioiTinh;

      // ham xay dung khong tham so
      public Nguoi(){}

      // ham xay dung co tham so
      public Nguoi(String maSo, String hoTen, String gioiTinh){
        this.maSo = maSo;
        this.hoTen = hoTen;
        this.gioiTinh = gioiTinh;
      }

      // ham nhap thong tin
      public virtual void nhap(){
        Console.Write("Nhap ma so: ");
        maSo = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap gioi tinh: ");
        gioiTinh = Console.ReadLine();
      }

      // ham hien thi
      public virtual void hienThi(){
        Console.WriteLine("Ma so: {0}", maSo);
        Console.WriteLine("Ho ten: {0}", hoTen);
        Console.WriteLine("Gioi tinh: {0}", gioiTinh);
      }
      



    }
}
