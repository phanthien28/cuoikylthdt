using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class Timkiemthu : Dongvat
    {
        string tim;
        public void tiemkiemloaidv()
        {
            Console.Write("Nhap loai thu ban can tim: ");
            tim = Console.ReadLine();
            if(tim == Loai)
            {
                Console.WriteLine("Ket qua: {0}", tim);
            }    
        }
    }
}
