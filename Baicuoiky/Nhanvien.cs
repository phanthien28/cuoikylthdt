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
            throw new NotImplementedException();
        }

        public void nhap()
        {
            throw new NotImplementedException();
        }
    }
}
