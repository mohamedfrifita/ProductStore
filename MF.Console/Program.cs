using System;
using MF.Domain;
using System.Collections.Generic;
using MF.Service;

namespace MF.Console
{
    class Program
    {
        static IList<Product> products = new List<Product>();
        public static IList<Product>Find( IList<Product> l ,string ch )
        {
            IList<Product> list = new List<Product>();
            foreach (Product p in l)
            {
                if (p.Name.StartsWith(ch))
                {
                    list.Add(p);
                }

            }
            return list;
        }
        public static IList<Product> Find2(string ch)
        {
         
            return null;
        }
        static void Main(string[] args)
        {  //Partie 1 Q5)c.
           //Provider P1 = new Provider();
           //P1.Password = "123466";
           //P1.ConfirmPassword = "123466";
           //Provider.SetIsApproved(P1);
           //System.Console.WriteLine("password : " +  P1.Password);
           //System.Console.WriteLine("Confiramtion de password : " + P1.ConfirmPassword);
           //System.Console.WriteLine(P1.IsApproved);

            //Partie 1 Q5)e.
            // bool isApproved = false;
            //Provider.SetIsApproved("12345", "12345", ref isApproved);
            //System.Console.WriteLine(isApproved);


            //Partie 1 Q7)

            //P1.UserName = "mohamed111";
            //P1.Email = "mohamed@gmail.com";
            //System.Console.WriteLine(P1.Login("mohamed111", "123466"));
            //System.Console.WriteLine(P1.Login("mohamed111", "123466", "mohamed@gmail.com"));

            //Partie 1 Q8)

            //Product prod = new Product();
            //System.Console.WriteLine(Product.Nb);
            //Product prod1 = new Product();
            //System.Console.WriteLine(Product.Nb);
            //Product prod2 = new Product();
            //System.Console.WriteLine(Product.Nb);
            //Product prod3 = new Product();
            //System.Console.WriteLine(Product.Nb);
            //prod.GetMyType();
            //Product ch = new Chimical();
            //ch.GetMyType();
            //Product bi = new Biological();
            //bi.GetMyType();

            //Partie 1 Q9)
            //var date1 = new DateTime(2019, 12, 12);
            //Product p1 = new Product() { Name = " prod1", DateProd = date1, Quantity = 12 };
            //Product p2 = new Chimical() { Name = "prod2", DateProd = DateTime.Now, Quantity = 15, City = "Ghazela", LabName = "Lab1" };
            //Product p3 = new Biological() { Name = "prod3", DateProd = DateTime.Now, Quantity = 20, Herbs = "Mint" };
            //p1.GetDetails();
            //System.Console.WriteLine("les type est :"  );
            //p1.GetMyType();
            //System.Console.WriteLine("***************");
            //p2.GetDetails();
            //System.Console.WriteLine("les type est :");
            //p2.GetMyType();
            //System.Console.WriteLine("***************");
            //p3.GetDetails();
            //System.Console.WriteLine("les type est :");
            //p3.GetMyType();

            //Provider prov1 = new Provider() { UserName = " moha11 ", DateCreated =  DateTime.Today };
            //Provider prov2 = new Provider() { UserName = " moha22 ", DateCreated = DateTime.Now };
            //Provider prov3 = new Provider() { UserName = " moha33 ", DateCreated = DateTime.Now };

            //prov1.Products = new List<Product>() { p1, p2, p3 };
            //p1.Providers = new List<Provider>() { prov1, prov2, prov3 };
            // prov1.GetDetails();


            //Partie 1/Q10
            Product p1 = new Product() { Name = "delece", DateProd = DateTime.Now, Quantity = 12 };
            Product p2 = new Chimical() { Name = "yab", DateProd = DateTime.Now, Quantity = 15, City = "Ghazela", LabName = "Lab1" };
            Product p3 = new Product() { Name = "prod3", DateProd = DateTime.Now, Quantity = 10 };
            Product p4 = new Product() { Name = "prod4", DateProd = DateTime.Now, Quantity = 111 };
            Product p5 = new Product() { Name = "prod5", DateProd = DateTime.Now, Quantity = 120 };
            Product p6 = new Product() { Name = "prod6", DateProd = DateTime.Now, Quantity = 123 };

            Category c1 = new Category() { Name = "cat1" };
            Category c2 = new Category() { Name = "cat2" };
            Category c3 = new Category() { Name = "cat3" };

            Provider prov1 = new Provider() { Password = "123456", ConfirmPassword = "123456", UserName = "moha44" };
            Provider prov2 = new Provider() { Password = "123456", ConfirmPassword = "123456", UserName = "hiba11" };
            Provider prov3 = new Provider() { Password = "123456", ConfirmPassword = "123456", UserName = "nabil22" };
            Provider prov4 = new Provider() { Password = "123456", ConfirmPassword = "123456", UserName = "ahmed33" };
            Provider prov5 = new Provider() { Password = "123456", ConfirmPassword = "123456", UserName = "ali44" };

            prov1.Products = new List<Product>() { p1, p2, p3 };
            prov2.Products = new List<Product>() { p1, p5 };
            prov3.Products = new List<Product>() { p1, p4 };
            prov4.Products = new List<Product>() { p4, p6 };
            prov5.Products = new List<Product>() { p4, p6 };

            p1.MyCategory = c1;
            p2.MyCategory = c1;
            p3.MyCategory = c3;
            p5.MyCategory = c2;
            p6.MyCategory = c3;

            p1.Providers = new List<Provider>() { prov1, prov2, prov3 };
            p2.Providers = new List<Provider>() { prov1 };
            p3.Providers = new List<Provider>() { prov1 };
            p4.Providers = new List<Provider>() { prov3, prov4, prov5 };
            p5.Providers = new List<Provider>() { prov2 };
            p6.Providers = new List<Provider>() { prov5, prov4 };

            c1.Products = new List<Product>() { p1, p2 };
            c2.Products = new List<Product>() { p5 };
            c3.Products = new List<Product>() { p6, p3 };
            prov1.GetDetails();
            c3.GetDetails();
            p3.GetDetails();
            System.Console.WriteLine("\n********************************");
            IList<Product> listProducts = new List<Product>()
            {
                new Product(){Name="delice",Price=1.2},
                new Product(){Name="dab",Price=1.1},
                new Product(){Name="vitalait",Price=3.2}
            };
           products = listProducts;
            ProductManage pm = new ProductManage(products);
            pm.FindProduct = Find;
            pm.FindProduct(products, "d");
            //pm.FindProduct = Find2;
            //pm.FindProduct("d");
            pm.FindProductMethode(Find, "d");




        }
    }
}
