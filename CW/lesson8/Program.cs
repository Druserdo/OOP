using lesson9;

string email = "resstail.ru";
if (email.IsValiedEmail()) Console.WriteLine("Это мыло");
else Console.WriteLine("Не мыло");


Console.WriteLine("Введите строку:");
string str = Console.ReadLine();
Console.WriteLine("Введите символ:");
char ch = char.Parse(Console.ReadLine());
Console.WriteLine(str.CountChar(ch));