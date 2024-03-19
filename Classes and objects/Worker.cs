using System;
using System.IO;
using System.Text.Json;

namespace Classes_and_objects
{
    class Worker
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Pay { get; set; }
        public int Days { get; set; }
        public Worker() { }

        public Worker(string _Firstname, string _Lastname, double _Pay, int _Days) 
        {
            Firstname = _Firstname;
            Lastname = _Lastname;
            Pay = _Pay;
            Days = _Days;
            Console.WriteLine($"Дані про працівника: \n Ім'я: {Firstname} \n Прізвище: {Lastname} \n Добова ставка: {Pay} \n Відпрацьовані дні: {Days}");
            salary();
        }
        
        public void salary()
        {
            double salary = Pay * Days;
            Console.WriteLine("Заробітна плата складає: " + salary);
        }

        public static void SaveToJson(Worker worker, string filePath)
        {
            var options = new JsonSerializerOptions();
            string jsonString = JsonSerializer.Serialize(worker, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static Worker LoadFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            Worker worker = JsonSerializer.Deserialize<Worker>(jsonString);
            return worker;
        }
    }
}
