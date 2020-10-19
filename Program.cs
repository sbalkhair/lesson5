using System;
using System.Security.Cryptography.X509Certificates;

namespace lesson5
{
    class MainClass
    {
        public static void Increment(int value)
        {
            value++;
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToInt32(Service.Cooking));
            //Console.ReadKey();


            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine($"a={a} , b={b}");

            //var a = 10;
            //Increment(a);
            //Console.WriteLine($"a:{a}");

            //var numbers = new int[] { 1, 2, 3 };

            //Console.WriteLine($"First element of array:{numbers[0]}");
            //numbers[0] = 0;
            //Console.WriteLine($"First element of array:{numbers[0]}");

            //var students = new string[] { "ruya", "mohamed", "ahmed" };
            //var goodStudents = students;
            //goodStudents[0] = "ruya";
            //Console.WriteLine($"Element form good student:{goodStudents[0]}");
            //Console.WriteLine($"Element form good student:{students[0]}");

            //var gender = "man";
            //if (gender == "man")
            //{
            //    Console.WriteLine("mr");
            //}
            //else
            //{
            //    Console.WriteLine("mis");
            //}


            //var studentDegree = 185;

            //if (studentDegree < 50)
            //{
            //    Console.WriteLine("fail");
            //}
            //else if (studentDegree >= 50 && studentDegree < 80)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (studentDegree >= 80 && studentDegree <= 100)
            //{
            //    Console.WriteLine("Exlant");
            //}
            //else
            //{
            //    Console.WriteLine("Falid value");
            //}
            //Console.ReadKey();

            //Console.Write("Enter your favorite color: ");
            //var color = Console.ReadLine();

            //switch (color)
            //{
            //    case "red":
            //        Console.WriteLine("apple");
            //        break;
            //    case "yello":
            //        Console.WriteLine("banan");
            //        break;
            //    case "blue":
            //        Console.WriteLine("Toot");
            //        break;
            //    default:
            //        Console.WriteLine("Not valid color");
            //        break;
            //}


            //Console.ReadKey();


            //var Ismarrid = true;
            //var message = "";


            //if (Ismarrid)
            //{
            //    message = "You are big";
            //}
            //else
            //{
            //    message = "You are litter";
            //}

            var Ismarrid = true;
            var message = "";

            message = Ismarrid ? "ok" : "bad";
            Console.WriteLine(message);
            Console.ReadKey();



        }


    }
}
