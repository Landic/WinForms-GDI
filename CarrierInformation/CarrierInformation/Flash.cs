using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace CarrierInformationDLL
{
    [Serializable]
    public class FlashMemory : CarrierInformation
    {
        float speedUSB;

        public FlashMemory(float speedUSB, string Model, string name, float mediaCapacity, int count)
        {
            this.speedUSB = speedUSB;
            this.Model = Model;
            this.name = name;
            this.mediaCapacity = mediaCapacity;
            this.count = count;
            log = new ConsoleLog();
        }

        public override void Print()
        {
            log.Print($"Spindle speed: {speedUSB}\nModel: {Model}\nName: {name}\nMedia Capacity: {mediaCapacity}\nCount: {count}");
        }
    }
}
