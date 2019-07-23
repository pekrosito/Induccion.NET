using InduccionNET.Areas.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InduccionNET.Areas.Application
{
    public interface IPersonApplicationService
    {
        PersonDTO GetPerson();
    }
}
