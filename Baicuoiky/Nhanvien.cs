using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    interface Inhanvien
    {
        int Idnv { get; set; }
        string hoten { get; set; }
        int tuoi { get; set; }        
        string chucvu { get; set; }
        string phutrach { get; set; }
        void hienthi();
        void nhap();
    }

    class Nhanvien : Inhanvien
    {
        public int Idnv { get; set; }
        public string hoten { get; set; }
        public int tuoi { get; set; }
        public string chucvu { get; set; }
        public string phutrach { get; set; }

        public void hienthi()
        {
            Console.Write("Nhap id nhan vien: ");
            Idnv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho va ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap tuoi nhan vien: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu nhan vien: ");
            chucvu = Console.ReadLine();
            Console.Write("Nhap phu trach nhan vien: ");
            phutrach = Console.ReadLine();
        }
        public void nhap()
        {
            Console.WriteLine("ID nhan vien: {0}", Idnv);
            Console.WriteLine("Ho va ten nhan vien: {0}", hoten);
            Console.WriteLine("Tuoi nhan vien: {0}", tuoi);
            Console.WriteLine("Chuc vu nhan vien: {0}", chucvu);
            Console.WriteLine("Phu trach nhan vien: {0}", phutrach);
        }
    }
}
