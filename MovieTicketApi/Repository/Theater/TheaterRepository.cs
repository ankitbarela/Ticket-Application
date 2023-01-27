using Microsoft.EntityFrameworkCore;
using MovieTicketApi.Db;
using MovieTicketApi.Repository.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository
{
    public class TheaterRepository : ITheaterRepository
    {
        private readonly MovieContext dbContext;
        private readonly DbSet<Model.Theater> entities;

        public TheaterRepository(MovieContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<Model.Theater>();
        }
        public Model.Theater Create(Model.Theater entity)
        {
            throw new NotImplementedException();
        }

        public List<Model.Theater> GetAll()
        {
            return this.entities.AsQueryable().ToList();
        }

        public Model.Theater GetById(int id)
        {
            return entities.Find(id);
        }
    }
}
