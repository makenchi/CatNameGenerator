using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chocolicia.src.models.errors
{
    public class SexCatExceptions : Exception
    {
        public SexCatExceptions()
        {                            
        }

        public SexCatExceptions(string message) : base(message)
        {            
        }
    }
}
