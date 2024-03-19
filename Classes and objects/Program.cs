using System;
using System.Text;

namespace Classes_and_objects;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Worker worker1 = new Worker("Sergiy", "Rebrov", 1230.30, 16);

        Console.WriteLine("Дані JSON файлу:");

        Worker.SaveToJson(worker1, "worker1.json");

        Worker workerFromFile = Worker.LoadFromJson("worker1.json");

        Console.WriteLine($"Працівник: {workerFromFile.Firstname} {workerFromFile.Lastname}\nЗаробітна плата: {workerFromFile.Pay * workerFromFile.Days}");
        Console.ReadKey();
    }
}

