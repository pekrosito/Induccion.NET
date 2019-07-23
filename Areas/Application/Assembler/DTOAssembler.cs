using InduccionNET.Areas.Api.DTOs;
using InduccionNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InduccionNET.Areas.Application.DTOAssembler
{
    public class DTOAssembler
    {
        public static PersonDTO CreatePerson(person person)
        {
            return new PersonDTO()
            {
                nombre = person.name,
                apellido = person.surname,
                edad = person.age,
                genero = new GenderDTO
                {
                    id = person.gender.id,
                    name = person.gender.name
                }
            };
        }
    }
}