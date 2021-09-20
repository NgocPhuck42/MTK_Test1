using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.model
{
    public class XeMay : ThongTin
    {

        public XeMay(String bienso, DateTime vaobai, DateTime rabai)
        {
            this.Bienso = bienso;
            this.Vaobai = vaobai;
            this.Rabai = rabai;

        }

        private String bienso;
        private DateTime vaobai;
        private DateTime rabai;

        public string Bienso { get => bienso; set => bienso = value; }
        public DateTime Vaobai { get => vaobai; set => vaobai = value; }
        public DateTime Rabai { get => rabai; set => rabai = value; }

        public override string getThongTin()
        {
            return String.Format("Thông tin xe máy: ", this.bienso, this.vaobai, this.rabai);
        }
    }
}
