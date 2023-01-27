using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository.User
{
   public interface IUserRepository
    {
        Model.User GetById(int id);
        List<Model.User> GetAll();
        Model.User Create(Model.User city);
        Model.User Authenticate(string userName, string password);
    }
}
