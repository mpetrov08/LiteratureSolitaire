using LiteratureSolitaire.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Repository
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(LiteratureSolitaireDbContext _context)
        {
            context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadОnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }
    }
}
