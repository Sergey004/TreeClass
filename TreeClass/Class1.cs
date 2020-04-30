using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClass
{
    class Tree
    {
        public double price { get; set; }
        public int age { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetTreeInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Место: {place}|");
        }
    }


    class Tree1 : Tree
    {
        public string type { get; set; }

        public virtual void GetTree1Info()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Место: {place}| |Цена саженца: {price}| |Тип: {type}");
        }
    }
}