using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Entities.Abstract;
using LSAppointmentManager.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Persistance.Repositories
{
    public class AbstractRepository<T> : IAbstractRepository<T>
        where T : AuditableEntity
    {
        private readonly AppointmentManagerContext _context;

        public AbstractRepository(AppointmentManagerContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                throw new Exception("No existe la entidad en la base de datos");
            }
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> SaveAsync(T entity)
        {
            _context.Add(entity);
            entity.CreatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Entry(entity).Property(p => p.CreatedBy).IsModified = false;
            _context.Entry(entity).Property(p => p.CreatedDate).IsModified = false;
            entity.ModifiedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
