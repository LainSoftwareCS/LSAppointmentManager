using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class AppointmentRepository : AbstractRepository<Appointment>
    {
        public AppointmentRepository(LSAppointmentManagerContext context) : base(context)
        {
            
        }

        public async Task<bool> ExistsByDateRangeAndWorker(DateTime startDate, DateTime endDate, int? workerId)
        {
            Expression<Func<Appointment, bool>> predicate = appointment =>
                        appointment.AppointmentDate >= startDate
                        && endDate >= appointment.AppointmentDate
                        && appointment.IsCancelled == false;

            if (workerId != null)
            {
                predicate = appointment =>
                        appointment.AppointmentDate >= startDate
                        && endDate >= appointment.AppointmentDate
                        && appointment.WorkerId == workerId
                        && appointment.IsCancelled == false;
            }

            return await context.Appointments.AsQueryable().AnyAsync(predicate);
        }
        public async Task<List<Appointment>> GetAllByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await context.Appointments.Where(appointment => appointment.AppointmentDate >= startDate
                        && endDate >= appointment.AppointmentDate
                        && appointment.IsCancelled == false).ToListAsync();
        }


    }
}
