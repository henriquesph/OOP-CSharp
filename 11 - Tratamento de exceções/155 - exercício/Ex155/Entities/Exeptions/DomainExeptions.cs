using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex155.Entities.Exeptions
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {

        }
    }
}
