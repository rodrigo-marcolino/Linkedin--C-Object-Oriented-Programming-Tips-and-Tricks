using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class SleepControler : ISleep
    {
        public bool isSleeping { get; private set; }

        public void Togglesleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
