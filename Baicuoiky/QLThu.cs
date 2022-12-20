using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLThu : Dongvat
    {
        List<Dongvat> dv = new List<Dongvat>();
        public void hienthilop()
        {
            foreach (Lophoc a in lop)
            {
                Console.WriteLine("Ma lop hoc: {0}", a.malop);
                Console.WriteLine("Ten lop hoc: {0}", a.tenlop);
            }
        }
        public void Nhaplop()
        {
            string trl;
            Lophoc sv;
            while (true)
            {
                sv = new Lophoc();
                sv.nhap();
                lop.Add(sv);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
    }
}
