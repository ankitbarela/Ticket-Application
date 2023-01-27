using Microsoft.EntityFrameworkCore;
using MovieTicketApi.Db;
using MovieTicketApi.Repository.Show;
using MovieTicketApi.Repository.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository
{
    public class ShowRepository : IShowRepository
    {
        private readonly MovieContext dbContext;
        private readonly DbSet<Model.Show> entities;

        public ShowRepository(MovieContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<Model.Show>();
        }
        public Model.Show Create(Model.Show entity)
        {
            throw new NotImplementedException();
        }

        public List<Model.Show> GetAll()
        {
            return this.entities.AsQueryable().ToList();
        }

        public Model.Show GetById(int id)
        {
            return entities.Find(id);
        }
    }
}
