using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrierInformationDLL;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialize
{
    public interface ISerialize
    {
        void Save(List<CarrierInformation> list);
        List<CarrierInformation> Load();
    }

    public class XMLSerialize : ISerialize
    {
        public List<CarrierInformation> Load()
        {
            SoapFormatter soap = new SoapFormatter();
            using (FileStream file = new FileStream("Data.soap", FileMode.OpenOrCreate))
            {
                List<CarrierInformation> list = (List<CarrierInformation>)soap.Deserialize(file);
                return list;
            }
        }

        public void Save(List<CarrierInformation> list)
        {
            SoapFormatter soap = new SoapFormatter();
            using (FileStream file = new FileStream("Data.soap", FileMode.OpenOrCreate)) // soap сохранение
            {
                foreach (CarrierInformation i in list)
                {
                    soap.Serialize(file, i.Model);
                    soap.Serialize(file, i.name);
                    soap.Serialize(file, i.count);
                    soap.Serialize(file, i.mediaCapacity);
                }

            }
        }
    }
}
