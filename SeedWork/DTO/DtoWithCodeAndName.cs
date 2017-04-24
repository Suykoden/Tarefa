using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedWork.DTO
{
    public class DtoWithCodeAndName : DtoWithCode
    {
        public string Name { get; set; }
    }
}
