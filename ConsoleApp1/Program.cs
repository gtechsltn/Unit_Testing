using log4net;
using MyCompany.MyLib;
using System;
using System.Configuration;
using System.Reflection;

namespace MyCompany.MyApp.MyConsole
{
    class Program
    {
        static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            Console.Write($"Connection String: {_connString}");

            var arr = new int[] { 1, 2, 3 };
            IMyClass myClass = new MyClass();
            myClass.HasDuplicate(arr);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
