using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace Wcf_LoginRegistration
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]

        [WebInvoke(Method = "*",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "loginCheck")]
        bool loginCheck(User user);

        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "addUser")]
        string addUser(User user);

        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "delUser/{id}")]
        string delUser(string id);

        [WebInvoke(Method = "*",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "modUser")]
        string modUser(User user);
    }

   
}
