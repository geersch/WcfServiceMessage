using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;

namespace WcfServiceLibrary
{
    public class HelloWorld : IHelloWorld, ILandingPage
    {
        public string SayHi(string name)
        {
            return String.Format("Hello, {0}.", name);
        }

        public Message Index()
        {
            var context = WebOperationContext.Current;
            context.OutgoingResponse.ContentType = "text/html";
            return new LandingPageMessage();
        }
    }
}
