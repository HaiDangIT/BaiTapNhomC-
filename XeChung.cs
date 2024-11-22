using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    internal class XeChung
    {
        private string bienso;
        private DateTime ngaysanxuat;

        public string Bienso { get => bienso; set => bienso = value; }
        public DateTime Ngaysanxuat { get => ngaysanxuat; set => ngaysanxuat = value; }

        public XeChung() { }

        public XeChung(string bienso, DateTime ngaysanxuat)
        {
            this.bienso = bienso;
            this.ngaysanxuat = ngaysanxuat;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            bienso = Console.ReadLine();
            Console.Write("Nhap ngay thang nam san xuat: ");
            ngaysanxuat = DateTime.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Bien so: {bienso} , NgaySX: {ngaysanxuat}");
        }

    }
}
