using AutoMapper;
using AutoMapper.Internal;
using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmenteManager.Application.Features.AbstractFeatures.Commands;
using LSAppointmenteManager.Application.Mapping;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Entities.Abstract;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Test.Mocks.Repositories
{
    public class AbstractRepositoryMock<TEntity> 
        where TEntity : AuditableEntity
    {
        private List<TEntity> entities { get; set; }
        public AbstractRepositoryMock(List<TEntity> entities)
        {
            this.entities = entities;
        }

        public Mock<IAbstractRepository<TEntity>> GetMock()
        {
            var mock = new Mock<IAbstractRepository<TEntity>>();

            mock.Setup(r => r.GetAllAsync())
                .ReturnsAsync(entities.ToList());

            mock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((int id) =>
                {
                    return entities.FirstOrDefault(x => x.Id == id);
                });

            mock.Setup(r => r.SaveAsync(It.IsAny<TEntity>()))
                .ReturnsAsync((TEntity entity) =>
                {
                    entity.Id = entities.Max(x => x.Id) + 1;
                    entity.CreatedBy = "UNIT_TESTING";
                    entity.CreatedDate = DateTime.Now;
                    entities.Add(entity);
                    return entity;
                });

            mock.Setup(r => r.UpdateAsync(It.IsAny<TEntity>()))
                .ReturnsAsync((TEntity entity) =>
                {
                    entity.ModifiedBy = "UNIT_TESTING";
                    entity.ModifiedDate = DateTime.Now;
                    var actualEntity = entities.First(x => x.Id == entity.Id);
                    var index = entities.IndexOf(actualEntity);
                    entities[index] = entity;
                    return entity;
                });

            mock.Setup(r => r.DeleteAsync(It.IsAny<TEntity>()))
                .Returns((TEntity entity) =>
                {
                    entities.Remove(entity);
                    return Task.CompletedTask;
                });

            mock.Setup(r => r.DeleteByIdAsync(It.IsAny<int>()))
                .Returns((int id) =>
                {
                    var entity = entities.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        entities.Remove(entity);
                    }
                    else
                    {
                        throw new Exception("No entity found in database");
                    }
                    return Task.CompletedTask;
                });

            return mock;
        }

    }
}
