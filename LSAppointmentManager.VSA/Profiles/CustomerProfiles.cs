using AutoMapper;
using LSAppointmentManager.Entities;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.VSA.Profiles
{
    public class CustomerProfiles : Profile
    {
        public class CreateCustomerDto
        {
            [DisplayName("CreateCustomerRequest")]
            public class Request
            {
                [VNotEmpty("Nombre",ErrorMessage ="Favor de agregar un nombre valido")]
                public string Name { get; set; }

                [VNotEmpty("Apellido Paterno", ErrorMessage = "Favor de agregar un apellido paterno valido")]
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                [VEmail("Correo", ErrorMessage = "Favor de agregar un correo electronico")]
                public string Email { get; set; }
                [VPhone("Telefono", ErrorMessage = "Favor de agregar un numero telefonico")]
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public DateTime? Birthdate { get; set; }
            }
            [DisplayName("CreateCustomerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public DateTime? Birthdate { get; set; }
                public DateTime CreatedDate { get; set; }
            }
        }

        public class UpdateCustomerDto
        {
            [DisplayName("UpdateCustomerRequest")]
            public class Request : IUpdateRequest
            {
                public int Id { get; set; }
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre valido")]
                public string Name { get; set; }

                [VNotEmpty("Apellido Paterno", ErrorMessage = "Favor de agregar un apellido paterno valido")]
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                [VEmail("Correo", ErrorMessage = "Favor de agregar un correo electronico")]
                public string Email { get; set; }
                [VPhone("Telefono", ErrorMessage = "Favor de agregar un numero telefonico")]
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public DateTime? Birthdate { get; set; }
            }
            [DisplayName("UpdateCustomerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public DateTime? Birthdate { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }

        public class GetCustomerDto
        {
            [DisplayName("GetCustomerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public DateTime? Birthdate { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }

        public CustomerProfiles()
        {
            CreateMap<CreateCustomerDto.Request, Customer>();
            CreateMap<Customer, CreateCustomerDto.Response>();
            CreateMap<UpdateCustomerDto.Request, Customer>();
            CreateMap<Customer, UpdateCustomerDto.Response>();
            CreateMap<Customer, GetCustomerDto.Response>();
        }
    }
}
