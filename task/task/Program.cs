using System;
using System.Collections;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine(myStack.Contains(2));
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            while (myStack.Count > 0)
                Console.Write(myStack.Pop());
            Console.WriteLine(myStack.Peek());


            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(6, "six");
            numberNames.Add(7, "seven");
            numberNames.Add(5, "five");
            numberNames.Remove(5);
            numberNames.RemoveAt(0);
            if (numberNames.ContainsKey(4))
            {
                numberNames[4] = "four";
            }
            Console.WriteLine(numberNames[0]);
            Console.WriteLine(numberNames[1]);

            ArrayList arrList = new ArrayList();
            arrList.Add(4);
            arrList.Add(7);
            arrList.Add(5);
            var arrList2 = new ArrayList()
            {
                2,"Zabrat"
            };
            Queue queue = new Queue();
            queue.Enqueue("Hello");

            arrList.AddRange(arrList2);
            int firstEmelent = (int)arrList[0];
            arrList[0] = 67;
            arrList.Insert(0, 55);
            arrList.Remove(null);

            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Queue<string> name = new Queue<string>();
            name.Enqueue("Z");
            name.Enqueue("A");
            name.Enqueue("B");
            name.Enqueue("R");
            name.Enqueue("A");
            name.Enqueue("T");
            Console.WriteLine(name.Count);
            while (name.Count > 0)
            {
                Console.WriteLine(name.Dequeue());
            }
            if (name.Count > 0)
            {
                Console.WriteLine(name.Peek());
            }

            IDictionary<int, string> numberNamez = new Dictionary<int, string>();
            numberNamez.Add(4, "four");
            numberNames.Add(8, "eight");
            numberNames.Add(0, "zero");

            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
            };
            Console.WriteLine(cities["UK"]);
            if (cities.ContainsKey("UK"))
            {
                Console.WriteLine(cities["UK"]);
            }
            string result;
            if (cities.TryGetValue("UK", out result))
            {
                Console.WriteLine(result);
            }
            cities["UK"] = "Liverpool, Bristol";
            cities.Remove("UK");
            if (cities.ContainsKey("UK"))
            {
                cities.Remove("UK");
            }
            Hashtable newNames2 = new Hashtable();
            newNames2.Add(1, "one");
            newNames2.Add(3, "three");
            newNames2.Add(5, "five");
            newNames2.Add(7, "seven");
            foreach (DictionaryEntry de in newNames2)
            {
                Console.WriteLine("Key: { 0}, Value: { 1}", de.Key, de.Value);
            }
            var cities3 = new Hashtable()
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
            };
            foreach (DictionaryEntry de in cities3)
            {
                Console.WriteLine("Key:{0}, Value:{1}", de.Key, de.Value);
            }
            string CitiesOfUk = (string)cities["UK"];

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
            cities.Remove("UK");
            cities.Clear();
        }
    }
}