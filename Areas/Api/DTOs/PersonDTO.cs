using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InduccionNET.Areas.Api.DTOs
{
    public class PersonDTO
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public GenderDTO genero { get; set; }
    }
}