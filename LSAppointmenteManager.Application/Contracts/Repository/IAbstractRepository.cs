using LSAppointmentManager.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmenteManager.Application.Contracts.Repository
{
    public interface IAbstractRepository<T> where T : AuditableEntity
    {
        public Task<T?> GetByIdAsync(int id);
        public Task<List<T>> GetAllAsync();
        public Task<T> SaveAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteByIdAsync(int id);
        public Task DeleteAsync(T entity);
    }
}
