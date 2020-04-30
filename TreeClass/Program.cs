using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Tree tree = new Tree();
            tree.name = "Дуб";
            tree.price = 45;
            tree.age = 30;
            tree.place = "Лесная зона";

            tree.GetTreeInfo();

            Tree1 tree1 = new Tree1();
            tree1.type = "Берёзовые";
            tree1.name = "Берёза";
            tree1.place = "Северное полушарие";
            tree1.price = 100;
            tree1.age = 20;


            tree1.GetTree1Info();

            Console.ReadLine();
        }
    }
}
