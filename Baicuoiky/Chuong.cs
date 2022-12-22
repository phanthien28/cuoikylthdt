using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    interface Ichuong
    {
        int IDchuong { get; set; }
        string Tenchuong { get; set; }
    }
    class Chuong : Ichuong
    {
        public int IDchuong { get; set; }
        public string Tenchuong { get; set; }
        public void Nhap()
        {
            Console.Write("Nhap IDChuong: ");
            IDchuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten chuong: ");
            Tenchuong = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Nhap ID chuong: {0}", IDchuong);
            Console.WriteLine("Ten chuong: {0}", Tenchuong);
        }
    }
}
