using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.service
{
    public class ServiceFactory
    {
        public static IService getService()
        {
            IService svc = new FileService();

            svc = new WebService();

            return svc;
        }


    }
}
