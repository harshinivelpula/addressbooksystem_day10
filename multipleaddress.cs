using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbooksystem
{
    internal class multipleaddress
    {
        public address find(string name, object addresses)
        {
            address addr = addresses.Find( name);
            return addr;
        }
    }
}
