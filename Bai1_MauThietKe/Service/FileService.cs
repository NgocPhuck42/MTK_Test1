using MauThietKe.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.service
{
    public class FileService : IService
    {
        public List<ThongTin> docThongTin()
        {
            List<ThongTin> list = new List<ThongTin>();
            try
            {
                FileStream f = new FileStream("input1.txt", FileMode.Open);
                StreamReader r = new StreamReader(f, Encoding.ASCII);

                while (true)
                {
                    String rs = r.ReadLine();
                    if (rs == null || rs == "") break;
                    String[] line = rs.Split(';');

                    if (line[0] == "0")
                    {

                        XeDap xd = new XeDap(Int32.Parse(line[2]), Convert.ToDateTime(line[3]), Convert.ToDateTime(line[4]));

                        list.Add(xd);

                    }
                }

                r.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;

        }
    }


}
