using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLChuong : Chuong
    {
        List<Chuong> ch = new List<Chuong>();
        public void Hienthich()
        {
            foreach (Chuong a in ch)
            {
                Console.WriteLine("ID Chuong: {0}", IDchuong);
                Console.WriteLine("Ten Chuong: {0}", Tenchuong);

            }
        }
        public void Nhapchuong()
        {
            string trl;
            Chuong Ch;
            while (true)
            {
                Ch = new Chuong();
                Ch.Nhap();
                ch.Add(Ch);
                Console.Write("Ban muon nhap tiep thi nhan (c): ");
                trl = Console.ReadLine();
                if (trl != "c") break;
            }
        }
        public void Sapxep()
        {
            ch.Sort(new Sapxepchuong());
        }
    }
}
