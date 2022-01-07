using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_20190140072;

namespace ServerChatApp_20190140072_AnisaNurfadila
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(ServiceCallBack));
                hostObj.Open();
                Console.WriteLine("Server dah siap!!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
