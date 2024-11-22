using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    internal class XeOto : XeChung
    {
        private int socho;
        private string sodangky;

        public int Socho { get => socho; set => socho = value; }
        public string Sodangky { get => sodangky; set => sodangky = value; }

        public XeOto() { }
        public XeOto(string Bienso, DateTime Ngaysanxuat, int socho,string sodangky)
        {
            this.Bienso = Bienso;
            this.Ngaysanxuat = Ngaysanxuat;
            this.socho = socho;
            this.sodangky = sodangky;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho: ");
            socho = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dang ky: ");
            sodangky = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Bien so: {Bienso} , NgaySX: {Ngaysanxuat} , So cho: {socho} , So dang ky: {sodangky}");

        }

    }

}
