using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace CarrierInformationDLL
{
    [Serializable]
    public class DVD : CarrierInformation
    {
        float writeSpeed;

        public DVD(float writeSpeed, string Model, string name, float mediaCapacity, int count)
        {
            this.writeSpeed = writeSpeed;
            this.Model = Model;
            this.name = name;
            this.mediaCapacity = mediaCapacity;
            this.count = count;
            log = new ConsoleLog();
        }

        public override void Print()
        {
            log.Print($"Spindle speed: {writeSpeed}\nModel: {Model}\nName: {name}\nMedia Capacity: {mediaCapacity}\nCount: {count}");
        }
    }
}
