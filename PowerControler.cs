using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class PowerControler : IPowerOn
    {
        public bool isOn { get; private set; }

        protected void TurOn()
        {
            isOn = true;
        }

        protected void TurOff()
        {
            isOn = false;
        }

        public virtual void TogglePower()
        {
            if (isOn)
            {
                TurOff();
            }
            else
            {
                TurOn();
            }
        }

    }
}
