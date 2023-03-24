using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213034
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData_1302213034(T dataBaru)
        {
            storedData.Add(dataBaru);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i]
                    + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }
}