using System;
using System.Collections.Generic;
using System.Text;

namespace MF.Domain
{
   public class Product:Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public static int Nb { get; set; } = 0;

        public Product()
        {
            Nb++;
        }


        //Partie 1 Q3/b.
        public List<Provider> Providers { get; set; }
        public Category MyCategory { get; set; }
        //Partie 1 Q8
        public virtual void GetMyType()
        {
            Console.WriteLine("UNKOWN");
        }
        //partie 1 Q9)b. 
        public override void GetDetails()
        {
            Console.WriteLine("Name: " + Name + "\n DateProduction: " + DateProd + "\n quantity: " + Quantity);
        }
    }
}
