using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepchuong : IComparer<Chuong>
    {
        public int Compare(Chuong x, Chuong y)
        {
            int a = x.Tenchuong.CompareTo(y.Tenchuong);
            if (a == 0)
                return x.IDchuong.CompareTo(y.IDchuong);
            return a;
        }
    }
}
