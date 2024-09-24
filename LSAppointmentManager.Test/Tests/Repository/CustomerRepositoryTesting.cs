using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Test.Mocks.Repositories;
using Shouldly;

namespace LSAppointmentManager.Test.Tests.Repository
{
    public class CustomerRepositoryTesting
    {
        private readonly IAbstractRepository<Customer> _customerRepositoryMock;

        public CustomerRepositoryTesting()
        {
            _customerRepositoryMock = new AbstractRepositoryMock<Customer>(new List<Customer>()
            {
                new Customer()
                {
                    Name = "John",
                    Lastname = "Doe",
                    Email = "john.doe@gmail.com",
                    Birthdate = DateTime.Now,
                    Gender = 1,
                    Id = 1,
                    PhoneNumber = "875444521"
                },
                new Customer()
                {
                    Name = "Kate",
                    Lastname = "McGinn",
                    Email = "kate.ginn@gmail.com",
                    Birthdate = DateTime.Now,
                    Gender = 2,
                    Id = 2,
                    PhoneNumber = "875444521"
                },
            }).GetMock().Object;
        }

        [Fact(DisplayName = "GetAll")]
        public async void GetAllTest()
        {
            var entities = await _customerRepositoryMock.GetAllAsync();
            entities.ShouldBeOfType<List<Customer>>();
            entities.ShouldNotBeNull();
            entities.First().ShouldBeOfType<Customer>();
        }

        [Fact(DisplayName = "Get")]
        public async void GetTest()
        {
            var entity = await _customerRepositoryMock.GetByIdAsync(1);
            entity.ShouldBeOfType<Customer>();
            entity.ShouldNotBeNull();
        }

        [Fact(DisplayName = "Save")]
        public async void SaveTest()
        {
            var entity = await _customerRepositoryMock.SaveAsync(new Customer()
            {
                Name = "Jorge",
                Lastname = "Montoya",
                Birthdate = DateTime.Now,
                Email = "jorge.montoya@gmail.com",
                PhoneNumber = "875554521",
                Gender = 1
            });
            entity.ShouldBeOfType<Customer>();
            entity.ShouldNotBeNull();
            entity.Id.ShouldBeGreaterThan(0);
            entity.CreatedBy.ShouldNotBeNullOrEmpty();
        }
    }
}
