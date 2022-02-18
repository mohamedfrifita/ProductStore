using System;
using System.Collections.Generic;
using System.Text;

namespace MF.Domain
{
   public class Category:Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //Partie 1 Q3/b.
        public List<Product> Products { get; set; }
        //partie 1 Q9) 
        public override void GetDetails()
        {
            Console.WriteLine("name:" + Name);
        }
    }
}
