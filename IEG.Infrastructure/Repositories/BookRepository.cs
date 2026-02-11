using IEG.Domain.Entities;
using IEG.Domain.Interfaces;
using IEG.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEG.Infrastructure.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
