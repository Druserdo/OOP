using System;
using System.Threading.Tasks;
class Program
{
   static void Main(string[] args)
{
       List<string> tasks = new List<string>();
       
 while (true)
             {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Просмотреть список задач");
            Console.WriteLine("4. Выйти");
            
             string choice = Console.ReadLine();
            
             switch (choice)
             { 
                case "1":Console.WriteLine("Введите новую задачу:");
                         string newTask = Console.ReadLine();
                         tasks.Add(newTask);
                         Console.WriteLine("Задача добавлена.");
                break;
                case "2":Console.WriteLine("Введите номер задачи, которую хотите               удалить:");
                         int indexToRemove = int.Parse(Console.ReadLine());
                         if (indexToRemove >= 0 && indexToRemove < tasks.Count)
                         {
                            tasks.RemoveAt(indexToRemove);
                            Console.WriteLine("Задача удалена.");
                         }
                         else
                         {Console.WriteLine("Неверный номер задачи.");}
                break;
                case "3":Console.WriteLine("Список задач:");
                         for (int i = 0; i < tasks.Count; i++)
                         {Console.WriteLine($"{i}. {tasks[i]}");}
                break;
                case "4":Console.WriteLine("Программа завершена.");
                         return;
                default: Console.WriteLine("Неверный выбор.");
                break;
             }
            Console.WriteLine();
             }
}
}