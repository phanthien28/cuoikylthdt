using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepthu : IComparer<Dongvat>
    {
        public int Compare(Dongvat x,  Dongvat y)
        {
            int a = x.Loai.CompareTo(y.Loai);
            if (a == 0)
                return x.Idthu.CompareTo(y.Idthu);
            return a;
        }
    }
}
