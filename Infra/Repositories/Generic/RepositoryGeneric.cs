using Domain.Interfaces.Generic;
using Infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Generic
{
    public class RepositoryGeneric<T> : IInterfaceGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptionsBuilder<ContextBase> _dbContextOptionsBuilder;

        public RepositoryGeneric()
        {
            _dbContextOptionsBuilder = new DbContextOptionsBuilder<ContextBase>();
        }

        public void Add(T Entity)
        {
            using(var banco = new ContextBase(_dbContextOptionsBuilder.Options))
            {
                banco.Set<T>().Add(Entity);
                banco.SaveChanges();
            }
        }

        public void Delete(T Entity)
        {
            using (var banco = new ContextBase(_dbContextOptionsBuilder.Options))
            {
                banco.Set<T>().Remove(Entity);
                banco.SaveChanges();
            }
        }

        public T GetEntity(int Id)
        {
            using (var banco = new ContextBase(_dbContextOptionsBuilder.Options))
            {
                var result = banco.Set<T>().Find(Id);
                if (result == null)
                    throw new Exception("Entity is null");
                return result;
            }
        }

        public List<T> List()
        {
            using (var banco = new ContextBase(_dbContextOptionsBuilder.Options))
            {
                return banco.Set<T>().AsNoTracking<T>().ToList();
            }
        }

        public void Update(T Entity)
        {
            using (var banco = new ContextBase(_dbContextOptionsBuilder.Options))
            {
                banco.Set<T>().Update(Entity);
                banco.SaveChanges();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        private void Dispose(bool isDisposed)
        {
            if (!isDisposed) return;

        }

        ~RepositoryGeneric()
        {
            Dispose(false);
        }
    }
}
