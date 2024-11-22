using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    internal class XeTai : XeChung
    {
        private int trongtai;

        public int Trongtai { get => trongtai; set => trongtai = value; }

        public XeTai() { }

        public XeTai(string Bienso, DateTime Ngaysanxuat,int trongtai )
        {
            this.Bienso = Bienso;
            this.Ngaysanxuat = Ngaysanxuat;
            this.trongtai = trongtai;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap trong tai xe: ");
            trongtai = int.Parse(Console.ReadLine()); 
        }

        public override void Xuat()
        {
            Console.WriteLine($"Bien so: {Bienso} , NgaySX: {Ngaysanxuat} , Trong tai: {trongtai}");
        }
    }
}
