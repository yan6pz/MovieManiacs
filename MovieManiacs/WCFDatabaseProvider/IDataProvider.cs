using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDatabaseProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDataProvider
    {
        #region Users

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        User GetUserByUserName(string username);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        #endregion

        #region Movies

        [OperationContract]
        Movie FindByMovieName(string movieName);

        [OperationContract]
        List<Movie> GetAllMovies();


        #endregion

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
