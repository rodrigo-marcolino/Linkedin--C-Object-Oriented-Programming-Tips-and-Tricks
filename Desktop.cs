using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Desktop : Computer
    {
        public enum CaseType 
        { 
            Tower,
            MiniTower
        }

        public bool isSleeping { get; private set; }

        public CaseType caseType { get; private set; }

        public override string name { get 
            {
                return base.name + " of Type " + caseType;
            }
        }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
        }

        public void ToggleSleep()
        {
            if(!isOn)
            {
                return;
            }

            isSleeping = !isSleeping;
        }

        public override void TogglePower()
        {
            if (isSleeping)
            {
                return;
            }
            base.TogglePower();
        }
    }
}
