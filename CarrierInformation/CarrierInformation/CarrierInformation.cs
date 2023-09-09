using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace CarrierInformationDLL
{
    [Serializable]
    public abstract class CarrierInformation
    {
        public string Model { get; set; }
        public string name { get; set; }
        public float mediaCapacity { get; set; }
        public int count { get; set; }

        public ILog log { get; set; }

        public abstract void Print();
    }
}
