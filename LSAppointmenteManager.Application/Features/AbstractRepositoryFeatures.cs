using AutoMapper;
using FluentResults;
using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Application.Contracts.Features;
using LSAppointmentManager.Application.Contracts.Models;
using LSAppointmentManager.Entities.Abstract;

namespace LSAppointmentManager.Application.Features
{
    public class AbstractRepositoryFeatures<TEntity> : IAbstractRepositoryFeatures<TEntity> where TEntity : AuditableEntity
    {
        private readonly IAbstractRepository<TEntity> _abstractRepository;
        private readonly IMapper _mapper;

        public AbstractRepositoryFeatures(IAbstractRepository<TEntity> abstractRepository, IMapper mapper)
        {
            _abstractRepository = abstractRepository;
            _mapper = mapper;
        }


        public async Task<Result<List<TDto>>> GetAllAndMapAsync<TDto>() where TDto : IGetAllEntityDto
        {
            var entities = await _abstractRepository.GetAllAsync();
            return entities.Select(_mapper.Map<TDto>).ToList();
        }

        public async Task<Result<TDto?>> GetByIdAndMapAsync<TDto>(int id) where TDto : IGetEntityDto
        {
            var entity = await _abstractRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return Result.Ok();
            }
            return _mapper.Map<TDto>(entity);
        }

        public async Task<Result> DeleteAndMapAsync(int id)
        {
            await _abstractRepository.DeleteByIdAsync(id);
            return Result.Ok();
        }

        public async Task<Result<TDto>> CreateAndMapAsync<TDto, TCommand>(TCommand command)
            where TDto : ICreateEntityDto
            where TCommand : class
        {
            var entity = _mapper.Map<TEntity>(command);

            await _abstractRepository.SaveAsync(entity);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<Result<TDto>> UpdateAndMapAsync<TDto, TCommand>(TCommand command)
            where TDto : IUpdateEntityDto
            where TCommand : IUpdateEntityCommand
        {
            var entity = _mapper.Map<TEntity>(command);
            await _abstractRepository.UpdateAsync(entity);
            return _mapper.Map<TDto>(entity);
        }
    }
}
