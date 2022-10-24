using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbooksystem
{
    internal class multiple
    {
        private readonly object addresses;

        public void list(Action<multipleaddress> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            addresses.Count == 0;
        }
    }
}
