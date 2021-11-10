using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface ILandingPage
    {
        [OperationContract(Action="*", ReplyAction="*")]
        Message Index();
    }
}