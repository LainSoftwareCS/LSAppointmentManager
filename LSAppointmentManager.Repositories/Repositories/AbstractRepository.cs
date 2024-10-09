using LSAppointmentManager.Entities.Abstract;
using LSAppointmentManager.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;


namespace LSAppointmentManager.Repositories.Repositories
{
    public class AbstractRepository<T>  where T : AuditableEntity
    {
        public readonly LSAppointmentManagerContext context;

        public AbstractRepository(LSAppointmentManagerContext context)
        {
            this.context = context;
        }
        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                throw new Exception("No existe la entidad en la base de datos");
            }
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> SaveAsync(T entity)
        {
            context.Add(entity);
            entity.CreatedDate = DateTime.Now;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.Entry(entity).Property(p => p.CreatedBy).IsModified = false;
            context.Entry(entity).Property(p => p.CreatedDate).IsModified = false;
            entity.ModifiedDate = DateTime.Now;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> ExistsAny(int id)
        {
            return await context.Set<T>().AnyAsync(x => x.Id == id); 
        }
    }
}
