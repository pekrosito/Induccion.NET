using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InduccionNET.Models;

namespace InduccionNET.Areas.Persistence
{
    public interface IPersonRepository
    {
        person GetPerson();
    }
}
