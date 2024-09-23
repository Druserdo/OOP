using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Order
    {
        public Passanger? Passanger { get; set; }
        public Trayn? Trayn { get; set; }
        public Cesher? Cesher {  get; set; }
        public Reciept? Reciept { get; set; }
        public DateTime? Created { get; set; }

        public Order(Passanger? passanger, Trayn? trayn, Cesher? cesher, Reciept? reciept, DateTime? created)
        {
            Passanger = passanger;
            Trayn = trayn;
            Cesher = cesher;
            Reciept = reciept;
            Created = created;
        }

        public override string? ToString()
        {
            return Passanger!.FIO + "\n" +
            Trayn!.Number + "\n" +
            Trayn.Destination + "\n" +
            Trayn.TimeDeparture + "\n" +
            Reciept!.Amount + "\n" +
            Cesher!.FIO;
        }
    }
}
