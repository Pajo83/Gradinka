using System;
using System.Collections.Generic;
namespace Gradinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kindergarden kindergarden = new Kindergarden();
            Group group = new Group("Jasli", 20);
            kindergarden.AddGroup(group);
            group = new Group("Mala", 25);
            kindergarden.AddGroup(group);
            group = new Group("Sredna", 25);
            kindergarden.AddGroup(group);
            group = new Group("Golema", 25);
            kindergarden.AddGroup(group);
            group = new Group("Prazna", 0);
            kindergarden.AddGroup(group);

            string answer = "y";
            while (answer == "y")
            {
                Console.WriteLine($"Odberete grupa");
                Console.WriteLine($"1.Jasli");
                Console.WriteLine($"2.Mala");
                Console.WriteLine($"3.Sredna");
                Console.WriteLine($"4.Golema");
                Console.WriteLine($"5.Prazna");
                int izbor = int.Parse(Console.ReadLine());

                Group groupF = null;
                switch (izbor)
                {
                    case 1:
                        groupF = kindergarden.FindByGroupType("Jasli");
                        break;

                    case 2:
                        groupF = kindergarden.FindByGroupType("Mala");
                        break;

                    case 3:
                        groupF = kindergarden.FindByGroupType("Sredna");
                        break;
                    case 4:
                        groupF = kindergarden.FindByGroupType("Golema");
                        break;
                    case 5:
                        groupF = kindergarden.FindByGroupType("Prazna");
                        break;
                }

                if (groupF == null)
                {
                    Console.WriteLine($"Izbranata grupa ne postoi");
                } 
                else if (groupF.IsLimitReached())
                {
                    Console.WriteLine($"Grupata e polna");
                }
                else
                {
                    Console.WriteLine($"Dodadete dete:");
                    Console.WriteLine($"Vnesete ime: ");
                    var ime = Console.ReadLine();
                    Console.WriteLine($"Vnesete godini: ");
                    var god = double.Parse(Console.ReadLine());

                    Kid kid = new Kid(ime, god);
                    groupF.AddKid(kid);
                    kindergarden.UpdateGroup(groupF);
                }

                Console.WriteLine($"Za da se dodade uste edno dete vnesete: y, so drug karakter se izleguva od programot");
                answer = Console.ReadLine();
            }
        }
    }
}
