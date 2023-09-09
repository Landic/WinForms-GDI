using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarrierInformationDLL;
using Log;
using Serialize;

namespace Volkov_HW_1
{
    internal class PriceList
    {
        List<CarrierInformation> list;
        List<ILog> log;
        ISerialize saveLoad;

        public PriceList()
        {
            list = new List<CarrierInformation>();
            log = new List<ILog>() { new FileLog(), new ConsoleLog(), new XMLLog() }; // 0 индекс сохраняет логи в текстовом формате, 1 индекс выводит логи в консоль, 2 индекс сохраняет логи в XML формате
            saveLoad = new XMLSerialize();
        }

        public void Add(CarrierInformation information) // метод добавления накопителя
        {
            log[0].Print("Тew drive added");
            log[1].Print("Тew drive added");
            log[2].Print("Тew drive added");
            list.Add(information);
        }

        public void Remove(string model)  // метод удаления накопителя
        {
            var dellist = list.RemoveAll(a => a.Model == model);
            if(dellist > 0)
            {
                log[0].Print($"Removed model {model}");
                log[1].Print($"Removed model {model}");
                log[2].Print($"Removed model {model}");
            }
            else
            {
                log[0].Print($"media with model {model} not found");
                log[1].Print($"media with model {model} not found");
                log[2].Print($"media with model {model} not found");
            }
        }

        public void Edit(string modelfind, string modelEdit, string nameEdit, float mediaCapacityEdit, int countEdit) // метод редактирования
        {
            var foundlist = list.Find(a => a.Model == modelfind);
            if (foundlist != null)
            {
                foundlist.Model = modelEdit;
                foundlist.count = countEdit;
                foundlist.mediaCapacity = mediaCapacityEdit;
                foundlist.name = nameEdit;
                log[0].Print($"Edited {modelfind}");
                log[1].Print($"Edited {modelfind}");
                log[2].Print($"Edited {modelfind}");
            }
            else
            {
                log[0].Print($"Not found this model {modelfind}");
                log[1].Print($"Not found this model {modelfind}");
                log[2].Print($"Not found this model {modelfind}");
            }
        }

        public void Find(string model)  // метод поиска
        {
            var foundlist = list.Find(a => a.Model == model);
            if (foundlist != null)
            {
                foundlist.Print();
            }
            else
            {
                log[0].Print($"Not found this model {model}");
                log[1].Print($"Not found this model {model}");
                log[2].Print($"Not found this model {model}");
            }
        }

        public void Save() // метод сохранения
        {
            saveLoad.Save(list);
            log[0].Print("Save");
            log[1].Print("Save");
            log[2].Print("Save");
        }
        public void Load() // метод загрузки
        {
            list = saveLoad.Load();
            log[0].Print("Load");
            log[1].Print("Load");
            log[2].Print("Load");
        }
    }
}
