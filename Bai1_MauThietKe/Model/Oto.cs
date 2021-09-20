using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.model
{
    public class Oto : ThongTin
    {

        public Oto(String bienso, DateTime timevaobai, DateTime timerabai, String ttvaobai, String ttrabai)
        {
            this.Bienso = bienso;
            this.Timevaobai = timevaobai;
            this.Timerabai = timerabai;
            this.Ttvaobai = ttvaobai;
            this.Ttrabai = ttrabai;
        }

        private String ttrabai;
        private String ttvaobai;
        private DateTime timerabai;
        private DateTime timevaobai;
        private String bienso;

        public string Bienso { get => bienso; set => bienso = value; }
        public DateTime Timevaobai { get => timevaobai; set => timevaobai = value; }
        public DateTime Timerabai { get => timerabai; set => timerabai = value; }
        public string Ttvaobai { get => ttvaobai; set => ttvaobai = value; }
        public string Ttrabai { get => ttrabai; set => ttrabai = value; }

        public override string getThongTin()
        {
            return String.Format("Thông tin xe ô tô: ", this.bienso, this.timevaobai, this.timerabai, this.ttvaobai, this.ttrabai);
        }
    }
}
