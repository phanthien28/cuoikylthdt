using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepnv : IComparer<Nhanvien>
    {
        public int Compare(Nhanvien x, Nhanvien y)
        {
            int a = x.hoten.CompareTo(y.hoten);
            if (a == 0)
                return x.Idnv.CompareTo(y.Idnv);
            return a;
        }
    }
}
