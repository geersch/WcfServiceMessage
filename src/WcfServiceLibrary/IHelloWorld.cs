using System.ServiceModel;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHi(string name);
    }
}
