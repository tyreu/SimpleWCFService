using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        int Sum(int first, int second);
    }
}
