using System;
using System.Collections.Generic;
using System.Text;

namespace MF.Domain
{//Partie 1 Q3/b.
    public class Chimical:Product
    {
        public string LabName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        //Partie 1 Q8
        public override void GetMyType()
        {
            Console.WriteLine("CHIMICAL");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine(" labName: " + LabName + "\n city: " + City );
        }
    }
}
