using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLThu : Dongvat
    {
        List<Dongvat> dv = new List<Dongvat>();
        public void Hienthithu()
        {
            foreach (Dongvat a in dv)
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
        public void Nhapthu()
        {
            string trl;
            Dongvat dvat;
            while (true)
            {
                dvat = new Dongvat();
                dvat.nhap();
                dv.Add(dvat);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
        public void Sapxepthu()
        {
            dv.Sort(new Sapxepthu());
        }
        /*public void timkiem()
        {
            dv.Sort(new Timkiemthu());
        }*/
    }
}
