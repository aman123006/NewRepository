using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        long AddCustomer(Customer Customer);

        [OperationContract]
        long UpdateCustomer(Customer Customer);

        [OperationContract]
        long DeleteCustomer(int id);

        [OperationContract]
        long GetCustomer(int id);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public partial class Customer
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long SSNID { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string AddressLine1  { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
     }
}
