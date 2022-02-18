using System;
using System.Collections.Generic;
using System.Text;

namespace MF.Domain
{
    public class Provider:Concept
    {   //Partie 1 Q3)a.
        
         string confirmPassword;
         string password;
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int id { get; set; }
        public bool IsApproved { get; set; }
        public string UserName { get; set; }
        //Partie 1 Q6)a.
        public string Password { 
            get { return password; } 
            set { if (value.Length >= 5 && value.Length <= 20)
                {
                    password = value;
                }
                else Console.WriteLine("le mot de passe doit etre de taille entre 5 et 20"); 
                    }
        }
        //Partie 1 Q6.b
        public string ConfirmPassword {
            get { return confirmPassword; }
            set { if (value == password)
                {
                    confirmPassword = value;
                }
                else
                {
                    Console.WriteLine("vous devez vérifier votre  mot de passe"); 
                }
                    }
            }
        //Partie 1 Q3)b.
        public List<Product> Products { get; set; }
        //Partie 1 Q4)a.
        public static void SetIsApproved(Provider P)
        {
            if (P.Password == P.ConfirmPassword)
            {
                P.IsApproved = true;
            }
            else
            {
                P.IsApproved = false;
                    
            }
        }
        //Partie 1 Q4)b.
        public static void SetIsApproved(string password,string confirmPassword,bool isApproved)
        {
            if (password == confirmPassword)
            {
                isApproved = true;
            }
            else
            { 
                isApproved = false;
            }
        }
        //Partie 1 Q5)e.
        public static void SetIsApproved(string password, string confirmPassword,ref bool isApproved)
        {
            if (password == confirmPassword)
            {
                isApproved = true;
            }
            else
            {
                isApproved = false;
            }
        }
        //Partie 1 Q7)a.
        public bool Login(string name, string password)
        {
            if (name == UserName && password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ////Partie 1 Q7)b.
        //public bool Login(string name, string password, string email)
        //{
        //    if (name == UserName && password == Password && email==Email)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //Partie 1 Q7)c.
        public bool Login(string name, string password, string email = null)
        {
            if (email == null)
            {
                return name == UserName && password == Password;


            }
            else
            {
                return name == UserName && password == Password && email == Email;            }
        }
       //partie 1 Q9)a. 
        public override void GetDetails()
        {
            Console.WriteLine("userName :" + UserName +"\n date created : " + DateCreated);
            if (Products != null)
            {
                foreach (Product p in Products)
                {
                    p.GetDetails();
                }
            }
        }
        //partie 1 Q9)b.
        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "DateProd":
                    foreach (Product p in Products)
                    {
                        if (p.DateProd == DateTime.Parse(filterValue))
                        {
                            p.GetDetails();
                        }
                    }
                    break;
                case "Description":
                    foreach (Product p in Products)
                    {
                        if (p.Description == filterValue)
                        {
                            p.GetDetails();
                        }
                    }
                    break;
            }

        }
        
    }
}
