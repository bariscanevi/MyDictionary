using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> myDict = new MyDict<int, string>();
            myDict.Add(1, "Ahmet");
            myDict.Add(2, "Mehmet");
            myDict.Add(3, "Barış");

            myDict.View();
        }
    }
}
