using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedDay14
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please choose the option below:");
                Console.WriteLine("1: UC1:Simple Linked List");
                int choice =Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Linked linked = new Linked();
                        linked.Add(56);
                        linked.Add(30);
                        linked.Add(70);
                        linked.Display();
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
