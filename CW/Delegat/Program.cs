using Delegat;
using System.Threading.Channels;

//Message mes;
//mes = Hello;
//mes();
//mes = MyMessage;
//mes();
//mes.Invoke();
//Message message1 = Welcome.Print;
//message1();
//Message message2 = new Hello().Display;
//message2();

//MyClass.Main();

//void Hello() => Console.WriteLine("Hello!");
//void MyMessage() => Console.WriteLine($"{2 + 3}={5}");
//delegate void Message();

//class Welcome
//{
//    public static void Print() => Console.WriteLine("Welcome");
//}
//class Hello
//{
//    public void Display() => Console.WriteLine("Привет!");
//}
//Operation operation = Add;
//Console.WriteLine(operation(4,7));

//Messege mes = Hello;
//mes += World;
//mes();

//Delegate[] delegats =operation.GetInvocationList();
//foreach(Operation d in operation.GetInvocationList())
//{
//    Console.WriteLine(d(4,6));
//}
Operation operation=Add;
Console.WriteLine("Введите первую переменную:");
int x=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую переменную:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите операцию:");
char op=char.Parse(Console.ReadLine()!);
switch (op)
{
    case '+':operation=Add; break;
    case '-':operation = Sub; break;
    case '*':operation=Mult; break;
    case '/':operation=Div; break;
    default:
        Console.WriteLine("Такой операции нет!");break;
}
Console.WriteLine($"Result={operation(x,y)}");



int Add(int x, int y) => x + y;
int Sub(int x, int y) => x - y;
int Mult(int x, int y) => x * y;
int Div (int x, int y) => x / y;

void Hello() => Console.WriteLine("Hello");
void World() => Console.WriteLine("World");

delegate void Messege();
delegate int Operation(int x, int y);