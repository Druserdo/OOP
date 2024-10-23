//using System.Collections;

////string[] people = { "Tom", "Sam", "Bob" };
////IEnumerator peopleEnumerator = people.GetEnumerator();
////while (peopleEnumerator.MoveNext())
////{
////    string item = (string)peopleEnumerator.Current;
////    Console.WriteLine(item);
////}
////peopleEnumerator.Reset();
//Week week = new Week();
//foreach (var day in week)
//{
//    Console.WriteLine(day);
//}
//class WeekEnumerator : IEnumerator
//{
//    private string[] days;
//    int index = -1;
//    public WeekEnumerator(string[] days)
//    {
//        this.days = days;
//    }

//    public object Current
//    {
//        get
//        {
//            if (index == -1 || index >= days.Length)
//                throw new ArgumentException();
//            return days[index];
//        }
//    }

//    public bool MoveNext()
//    {
//        if (index < days.Length - 1)
//        {
//            index++;
//            return true;
//        }
//        return false;
//    }

//    public void Reset() => index = -1;
//}
//class Week : IEnumerable
//{
//    string[] days ={ "Monday",
//    "Tuesday","Wednesday","Thirthday","Friday","Satarday","Sanday"};
//    //public IEnumerator GetEnumerator() => days.GetEnumerator();
//    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
//}

//class Person
//{
//    public Person(string name)
//    {
//        Name = name;
//    }

//    public string Name { get; set; }
//}
//class Company
//{
//    private Person[] personal;
//    public Company(Person[])
//    {
//        this}
//}

void SendMassage(Message message)
{
    Console.WriteLine("отправляется сообщение:" + message.Text);
}


class Message
{
    public string? Text { get; }

    public Message(string? text)
    {
        Text = text;
    }
}

