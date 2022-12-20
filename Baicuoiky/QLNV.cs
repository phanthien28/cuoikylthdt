using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLNV : Nhanvien
    {
    List<Nhanvien> nv = new List<Nhanvien>();
        public void Hienthinv()
        {
            foreach (Nhanvien a in nv)
            {
                Console.WriteLine("ID nhan vien: {0}", Idnv);
                Console.WriteLine("Ho va ten nhan vien: {0}", hoten);
                Console.WriteLine("Tuoi nhan vien: {0}", tuoi);
                Console.WriteLine("Chuc vu nhan vien: {0}", chucvu);
                Console.WriteLine("Phu trach nhan vien: {0}", phutrach);
            }
        }
        public void Nhapnv()
        {
            string trl;
            Nhanvien NV;
            while (true)
            {
                NV = new Nhanvien();
                NV.nhap();
                nv.Add(NV);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
    }
}
