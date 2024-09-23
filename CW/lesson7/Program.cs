using lesson7;
using System.ComponentModel;

Passanger passanger = new Passanger()
{
    FIO = "Иванов Иван Иванович",
    Passport = "12334 32"
};

Trayn trayn = new Trayn()
{
    Number = 1,
    Destination = "Кузьминки",
    TimeArived = TimeOnly.Parse("10:12:12"),
    TimeDeparture = TimeOnly.Parse("10:11:11")
};
Cesher cesher = new Cesher()
{
    FIO = "Djon"
};
Reciept reciept = new Reciept()
{
    Number = 2324324324,
    Amount = 345
};
Order order = new Order(passanger, trayn, cesher, reciept,DateTime.Parse("2000.03.03"));
Console.WriteLine(order);