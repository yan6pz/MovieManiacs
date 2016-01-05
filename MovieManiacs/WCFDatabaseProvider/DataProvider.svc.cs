using Core;
using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDatabaseProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DataProvider : IDataProvider
    {
        public IUserRepository UserRepository { get; set; }
        public IMovieRepository MovieRepository { get; set; }

        public DataProvider()
        {
            this.UserRepository = new UserRepository(new MovieManiacsContext());
            this.MovieRepository = new MovieRepository(new MovieManiacsContext());
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region User

        public User GetUserByUserName(string username)
        {
            var user = this.UserRepository.FindByUsername(username);

            return user;
        }

        #endregion

        #region Movie

        public Movie FindByMovieName(string movieName)
        {
            var movie = this.MovieRepository.FindByMovieName(movieName);

            return movie;
        }
        #endregion
    }
}
