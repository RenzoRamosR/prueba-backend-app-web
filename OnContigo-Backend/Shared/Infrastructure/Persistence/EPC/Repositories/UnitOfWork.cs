using OnContigo_Backend.Shared.Domain.Repositories;
using OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Configuration;
using System;

namespace OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}