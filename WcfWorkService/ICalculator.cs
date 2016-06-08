using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfWorkService
{
    [ServiceContract(Namespace = "www.wcf.com")]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int x, int y);
        [OperationContract]
        int Sub(int x, int y);
        [OperationContract]
        int Mul(int x, int y);
        [OperationContract]
        int Div(int x, int y);
    }
}