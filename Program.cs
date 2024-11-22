using System;
using System.Threading.Channels;

namespace QuanLyXe
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            List<XeChung> list = new List<XeChung>();
            list.Add(new XeChung("1111", new DateTime(2004, 11, 4)));
            list.Add(new XeTai("2222", new DateTime(2004, 06, 22), 30));
            list.Add(new XeOto("3333", new DateTime(2004, 01, 30), 30 , "22806"));
            foreach (var item in list) 
                {
                item.Xuat();
                }


        }

    }
}