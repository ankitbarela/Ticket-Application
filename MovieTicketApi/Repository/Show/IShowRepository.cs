using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository.Show
{
   public interface IShowRepository
    {
        Model.Show GetById(int id);
        List<Model.Show> GetAll();
        Model.Show Create(Model.Show show);
    }
}
