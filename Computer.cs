using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    abstract class Computer
    {

        protected string _name = "Unknow";
        public bool isOn { get; private set;  }

        public virtual string name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public Computer(String name)
        {
            this.name = name;
        }

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
            } else
            {
                TurOn();
            }
        }

    }
}
