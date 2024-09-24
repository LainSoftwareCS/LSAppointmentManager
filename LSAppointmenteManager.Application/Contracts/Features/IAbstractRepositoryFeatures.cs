using FluentResults;
using LSAppointmentManager.Application.Contracts.Models;
using LSAppointmentManager.Entities.Abstract;

namespace LSAppointmentManager.Application.Contracts.Features
{
    public interface IAbstractRepositoryFeatures<TEntity> where TEntity : AuditableEntity
    {
        Task<Result<TDto>> CreateAndMapAsync<TDto, TCommand>(TCommand command)
            where TCommand : class
            where TDto : ICreateEntityDto;
        Task<Result> DeleteAndMapAsync(int id);
        Task<Result<List<TDto>>> GetAllAndMapAsync<TDto>() where TDto : IGetAllEntityDto;
        Task<Result<TDto?>> GetByIdAndMapAsync<TDto>(int id) where TDto : IGetEntityDto;
        Task<Result<TDto>> UpdateAndMapAsync<TDto, TCommand>(TCommand command) 
            where TCommand : IUpdateEntityCommand
            where TDto : IUpdateEntityDto;
    }
}