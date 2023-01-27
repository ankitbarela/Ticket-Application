using Microsoft.EntityFrameworkCore;
using MovieTicketApi.Db;
using MovieTicketApi.Repository.Screen;
using MovieTicketApi.Repository.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository
{
    public class ScreenRepository : IScreenRepository
    {
        private readonly MovieContext dbContext;
        private readonly DbSet<Model.Screen> entities;

        public ScreenRepository(MovieContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<Model.Screen>();
        }
        public Model.Screen Create(Model.Screen entity)
        {
            throw new NotImplementedException();
        }

        public List<Model.Screen> GetAll()
        {
            return this.entities.AsQueryable().ToList();
        }

        public Model.Screen GetById(int id)
        {
            return entities.Find(id);
        }
    }
}
