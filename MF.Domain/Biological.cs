using System;

namespace MF.Domain
{//Partie 1 Q3/b.
    public class Biological:Product
    {
        public string Herbs { get; set; }
        //Partie 1 Q8
        public override void GetMyType()
        {
            Console.WriteLine("BIOLOGICAL");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine(" herbs: " + Herbs );
        }
    }
}
