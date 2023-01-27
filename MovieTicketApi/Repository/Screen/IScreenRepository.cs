using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository.Screen
{
   public interface IScreenRepository
    {
        Model.Screen GetById(int id);
        List<Model.Screen> GetAll();
        Model.Screen Create(Model.Screen screen);
    }
}
