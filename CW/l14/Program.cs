
//double Add(double x, double y) => x+ y;
//double Sub(double x, double y) => x - y;
//double Mult(double x, double y) => x * y;
//double Div(double x, double y) => x / y;

//Operation[] delMas = new Operation[4];
//delMas[0] = Add; delMas[1]= Sub; delMas[2]= Mult; delMas[3]= Div;
//Console.WriteLine("Введите первое число:");
//double x= double.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите второе число:");
//double y= double.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите операцию:");
//char op = char.Parse(Console.ReadLine()!);
//switch(op)
//{
//    case '+':Console.WriteLine(delMas[0](x,y));break;
//    case '-':Console.WriteLine(delMas[1](x, y));break;
//    case '*':Console.WriteLine(delMas[2](x, y));break;
//    case '/':Console.WriteLine(delMas[3](x, y));break;
//}

//public delegate double Operation(double x, double y);

UserInfo[] userInfos =
{
    new UserInfo("Sam","Brown",150000),
    new UserInfo("Jorn","Riwal",120000),
    new UserInfo("Garry","Tovn",180000),
    new UserInfo("Hirly","Brwser",110000)
};
ArrSort.Sort(userInfos, UserInfo.UserSalary);
foreach(UserInfo i in userInfos) Console.WriteLine(i);

class ArrSort
{
    public static void Sort<T>(IList<T> sortArray,Func<T,T,bool> res)
    {
        bool mySort = true;
        do 
        { 
            mySort = false; 
            for (int i=0;i<sortArray.Count-1;i++)
            {
                if (res(sortArray[i + 1], sortArray[i]))
                {
                    T j = sortArray[i];
                    sortArray[i] = sortArray[i + 1];
                    sortArray[i+1] = j;
                    mySort= true;
                }
            }
        } while (mySort);
    }
}


class UserInfo
{
    public string Name { get; set; }
    public string Family { get; set; }
    public decimal Salary { get; set; }

    public UserInfo(string name, string family, decimal salary)
    {
        Name = name;
        Family = family;
        Salary = salary;
    }
    public override string ToString()
    {
        return Name+" "+Family+" "+Salary;
    }
    public static bool UserSalary(UserInfo userInfo1,UserInfo userInfo2)
    {
        return userInfo1.Salary < userInfo2.Salary;
    }
}