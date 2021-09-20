using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.model
{
    public class XeDap : ThongTin
    {

        public XeDap(int sovexe, DateTime timevaobai, DateTime timerabai)
        {
            this.Sovexe = sovexe;
            this.Timevaobai = timevaobai;
            this.Timerabai = timerabai;
        }

        private DateTime timerabai;
        private DateTime timevaobai;
        private int sovexe;

        public int Sovexe { get => sovexe; set => sovexe = value; }
        public DateTime Timevaobai { get => timevaobai; set => timevaobai = value; }
        public DateTime Timerabai { get => timerabai; set => timerabai = value; }

        public override string getThongTin()
        {
            return String.Format("Thong tin xe dap: ", this.sovexe, this.timevaobai, this.timerabai);
        }
    }
}
