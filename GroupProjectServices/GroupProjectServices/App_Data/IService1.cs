using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupProjectServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        SysUser Login(string username, string password);

        [OperationContract]
        int UserReg(SysUser u);

        [OperationContract]
        List<Product> getDOTW();

        [OperationContract]
        List<Product> getProducts();
    }




    }


   