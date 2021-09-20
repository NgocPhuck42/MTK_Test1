using MauThietKe.model;
using MauThietKe.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe
{
    public class Program
    {
        static void Main(string[] args)
        {

            IService svc = ServiceFactory.getService();

            List<ThongTin> list = svc.docThongTin();

            Console.WriteLine("danh sach");

            foreach (ThongTin t in list)
            {
                Console.WriteLine(t.getThongTin());
            }
        }
    }
}
