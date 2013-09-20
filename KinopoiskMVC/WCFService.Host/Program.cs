using System;
using System.Linq;
using System.ServiceProcess;

namespace WCFService.Host
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var service = new Service1();
            if (args.Any(arg => string.Equals(arg, "/d", StringComparison.InvariantCultureIgnoreCase)))
            {
                service.StartWCFService();
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                service.StopWCFService();
            }
            else
            {
                ServiceBase.Run(service);
            }
        }
    }
}
