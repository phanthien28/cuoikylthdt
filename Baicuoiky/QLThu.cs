using ManagerZoo___Final_Exam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Manager
{
    class QLThu
    {
        public static List<Thu> listthu = new List<Thu>();

        public static Thu checkThu(String IDthu)
        {
            foreach(Thu t in listthu)
            {
                if(t.IDThu1.Equals(IDthu))
                {
                    return t;
                }    
            }
            return null;
        }

        public static void add(String IDChuong)
        {
            String LoaiThu;
            String IDThu;
            String Ten;
            String NgayNuoi;
            String NguonGoc;
            String SucKhoe;
            Thu t;
            do
            {
                Console.Write("ID Thu: ");
                IDThu = Console.ReadLine();
                t = QLThu.checkThu(IDThu);
                if (t != null)
                {
                    Console.WriteLine("ID Thu da ton tai !!!");
                    Console.WriteLine("Vui long nhap lai !!!");
                }
            } while (t != null);
            Console.WriteLine("Loai Thu: ");
            LoaiThu = Console.ReadLine();
            Console.WriteLine("Ten Thu: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Ngay Nuoi: ");
            NgayNuoi = Console.ReadLine();
            Console.WriteLine("Nguon Goc: ");
            NguonGoc = Console.ReadLine();
            Console.WriteLine("Tinh trang suc khoe: ");
            SucKhoe = Console.ReadLine();
            t = new Thu(IDThu, LoaiThu, Ten, IDChuong, NgayNuoi, NguonGoc, SucKhoe);
            listthu.Add(t);
            QLChuong.checkChuong(IDChuong).ListThu.Add(t);
        }

        public static void delete(Chuong chuong)
        {
            Console.Write("Nhap ID Thu: ");
            String IDThu = Console.ReadLine();
            Thu t;
            t = QLThu.checkThu(IDThu);
            if (t == null)
            {
                Console.WriteLine("Khong tim thay thu !!!");
            }
            else
            {
                listthu.Remove(t);
                chuong.ListThu.Remove(t);
            }
        }

        public static void hienthi(Chuong chuong)
        {
            int check = 0;
            Console.WriteLine("Chuong {0}", chuong.TenChuong1);
            Console.WriteLine("ID Thu\t|\tLoai Thu\t|\tTen Thu\t|\tNgay nuoi\t|\tNguon goc\t|\tSuc khoe\t");
            foreach(Thu t in chuong.ListThu)
            {
                check++;
                Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}\t|\t{5}\t", t.IDThu1, t.LoaiThu1, t.Ten1, t.NgayNuoi1, t.NgayNuoi1, t.SucKhoe1);
            }
            if(check == 0)
            {
                Console.WriteLine("Khong co con thu nay trong chuong !!!");
            }    
        }
    }
}
