using System.Threading.Tasks;

List<string> Employeers = new List<string>();
while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить сотрудника:");
    Console.WriteLine("2. Удалить сотрудника:");
    Console.WriteLine("3. Просмотреть список сотрудников:");
    Console.WriteLine("4. Выйти");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            
            break;
        case "2":
            Console.WriteLine("Введите номер задачи, которую хотите               удалить:");
            int indexToRemove = int.Parse(Console.ReadLine());
            if (indexToRemove >= 0 && indexToRemove < tasks.Count)
            {
                tasks.RemoveAt(indexToRemove);
                Console.WriteLine("Задача удалена.");
            }
            else
            { Console.WriteLine("Неверный номер задачи."); }
            break;
        case "3":
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            { Console.WriteLine($"{i}. {tasks[i]}"); }
            break;
        case "4":
            Console.WriteLine("Программа завершена.");
            return;
        default:
            Console.WriteLine("Неверный выбор.");
            break;
    }
    Console.WriteLine();
}
}
}
 void EmployeesAdd()
{
    for (int i = 0; i < Employeers.Count; i++)
    {
        Console.WriteLine("Введите имя:");
        string[] = Console.ReadLine();
        Console.WriteLine("Введите фамилию:");
        string LastName = Console.ReadLine();
        Console.WriteLine("Введите должность:");
        string JobTitle = Console.ReadLine();
    }
}