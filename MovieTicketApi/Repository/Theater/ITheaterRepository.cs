using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository.Theater
{
   public interface ITheaterRepository
    {
        Model.Theater GetById(int id);
        List<Model.Theater> GetAll();
        Model.Theater Create(Model.Theater theater);
    }
}
