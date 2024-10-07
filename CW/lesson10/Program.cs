//List<string> people=new List<string> ()
//{
//    "First","Second","Ten","Nine"
//};
//LinkedList<string> list=new LinkedList<string> (people);
//Console.WriteLine(list.Count);
//Console.WriteLine(list.First!.Next!.Value);
//Console.WriteLine(list.Last!.Previous.Value);
//Console.WriteLine();
//var current=list.First;
//while(current!= null)
//{
//    Console.WriteLine(current.Value);
//    current=current.Next;
//}
//Console.WriteLine();
//current = list.Last;
//while(current!= null)
//{
//    Console.WriteLine(current.Value);
//    current=current.Previous;
//}
//Console.WriteLine();
//list.AddLast("Seven");
//list.AddFirst("Eight");
//if (list.First != null) list.AddAfter(list.First, "six");
//if (list.Last != null) list.AddBefore(list.Last, "twelve");
//current = list.Last;
//while(current != null)
//{
//    Console.WriteLine(current.Value);
//    current=current.Previous;
//}
//if(list.Contains("seven")) list.Remove(list.Find("seven")!);

//SortedSet<int> ints=new SortedSet<int>();
//ints.Add(6);
//ints.Add(3);
//ints.Add(6);
//foreach(int i in ints)
//{ Console.WriteLine(i+" "); }
//Console.WriteLine();
//HashSet<double> doubles=new HashSet<double>();
//doubles.Add(3);
//doubles.Add(6);
//doubles.Add(3);
//foreach(double d in doubles)
//{ Console.WriteLine(d+" "); }


//1
//List<string> listTask=new List<string>();
//listTask.Add("first");
//listTask.Add("second");
//foreach (string item in listTask) Console.Write(item+" ");
//Console.WriteLine();
//listTask.Remove("first");
//listTask.RemoveAt(0);
//Console.WriteLine(listTask.Count);

//2
//Dictionary<string,int> shoping=new Dictionary<string,int>();
//string enterString = "";
//do
//{
//    Console.WriteLine("Введите имя клиента:");
//    enterString = Console.ReadLine()!;
//    if (enterString == "exit") break;
//    if (shoping.ContainsKey(enterString))
//    { shoping[enterString]++; }
//    else
//    {
//        shoping.Add(enterString, 1);
//    }

//}
//while (true);
//foreach (var item in shoping)
//{
//    Console.WriteLine(item.Key+" "+item.Value);
//}

//3
bool IsUnique(int[] mas)
{
    HashSet<int> result = new HashSet<int>();
    foreach(int ma in mas) result.Add(ma);
    return result.Count==mas.Length;
}
int[] m1 = { 1, 2, 3, 5 };
int[] m2 = { 2, 3, 4, 5, 5 };
