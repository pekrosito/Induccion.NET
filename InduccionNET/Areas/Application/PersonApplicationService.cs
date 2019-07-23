using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InduccionNET.Areas.Api.DTOs;
using InduccionNET.Areas.Persistence;
using Assembler = InduccionNET.Areas.Application.DTOAssembler.DTOAssembler;

namespace InduccionNET.Areas.Application
{
    public class PersonApplicationService : IPersonApplicationService
    {
        private IPersonRepository _personRepository;

        public PersonDTO GetPerson()
        {
            PersonRepository repository = new PersonRepository();
            return Assembler.CreatePerson(repository.GetPerson());
        }
    }
}