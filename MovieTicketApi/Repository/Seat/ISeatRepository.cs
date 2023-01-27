using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository.Seat
{
   public interface ISeatRepository
    {
        Model.Seat GetById(int id);
        List<Model.Seat> GetAll();
        Model.Seat Create(Model.Seat seat);
    }
}
