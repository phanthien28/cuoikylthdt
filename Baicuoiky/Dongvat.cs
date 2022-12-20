using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
     interface Ithongtin
    {
        int Idthu { get; set; }
        string Loai { get; set; }
        string Ten { get; set; }
        int tuoi { get; set; }
        string Ngaynuoi { get; set; }
        string Nguongoc { get; set; }
        string Suckhoe { get; set; }
        string Dichuyen { get; set; }
        void nhap();
        void xuat();
    }
    class Dongvat : Ithongtin
    {
        
        public int Idthu { get; set; }
        public string Loai { get; set; }
        public string Ten { get; set; }
        public string Ngaynuoi { get; set; }
        public string Nguongoc { get; set; }
        public string Suckhoe { get; set; }
        public string Dichuyen { get; set; }
        public int tuoi { get; set; }

        public void nhap()
        {
            Console.Write("Nhap id thu: ");
            Idthu = int.Parse(Console.ReadLine());
            Console.Write("Nhap loai thu: ");
            Loai = Console.ReadLine();
            Console.Write("Nhap ten thu: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap tuoi thu: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay nuoi thu: ");
            Ngaynuoi = Console.ReadLine();
            Console.Write("Nhap nguon goc thu: ");
            Nguongoc = Console.ReadLine();
            Console.Write("Nhap suc khoe thu: ");
            Suckhoe = Console.ReadLine();
            Console.Write("Nhap cach di chuyen cua thu: ");
            Dichuyen = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Id thu: {0}", Idthu);
            Console.WriteLine("Loai thu: {0}", Loai);
            Console.WriteLine("Ten thu: {0}", Ten);
            Console.WriteLine("Tuoi thu: {0}", tuoi);
            Console.WriteLine("Ngay nuoi thu: {0}", Ngaynuoi);
            Console.WriteLine("Nguon goc thu: {0}", Nguongoc);
            Console.WriteLine("Suc khoe thu: {0}", Suckhoe);
            Console.WriteLine("Cach di chuyen thu: {0}", Dichuyen);

        }
    }
}
