using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            var service = new ServiceHost(typeof (HelloWorld));
            service.Description.Behaviors.Remove<ServiceDebugBehavior>();
            service.Open();

            Console.WriteLine("Service started.");
            Console.ReadKey();
        }
    }
}
