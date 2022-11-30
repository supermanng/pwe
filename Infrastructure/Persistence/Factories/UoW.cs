using Application.Common.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factories
{
    public class UoW : IUnitOfWork
    {
        private readonly ProfileDbContext _context;
        public UoW(ProfileDbContext context, IProfileRepository profileStore)
        {
            _context = context;
            ProfileStore = profileStore;

        }

        private bool _disposed;

        public IProfileRepository ProfileStore { get; private set; }
        


        public void Commit()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
