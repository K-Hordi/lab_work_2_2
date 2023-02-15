using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab_work_2_2
{
    internal class Program
    {
        static void Main()
        {

            //відображення даних однієї таблиці
            ApplicationContext db = new ApplicationContext();

            var manufacturers = db.Manufacturers.ToList();
            Console.WriteLine("Manufacturers list");

            foreach (Manufacturer m in manufacturers)
            {
                Console.WriteLine($"{m.ManufacturerId}. {m.ManufacturerName}");
            }



        }
    }
}
