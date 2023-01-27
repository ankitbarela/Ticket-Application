using Microsoft.EntityFrameworkCore;
using MovieTicketApi.Db;
using MovieTicketApi.Repository.Seat;
using MovieTicketApi.Repository.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository
{
    public class SeatRepository : ISeatRepository
    {
        private readonly MovieContext dbContext;
        private readonly DbSet<Model.Seat> entities;

        public SeatRepository(MovieContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<Model.Seat>();
        }
        public Model.Seat Create(Model.Seat entity)
        {
            throw new NotImplementedException();
        }

        public List<Model.Seat> GetAll()
        {
            return this.entities.AsQueryable().ToList();
        }

        public Model.Seat GetById(int id)
        {
            return entities.Find(id);
        }
    }
}
