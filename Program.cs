using System;

namespace MyDictionary_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, byte> myDictionary = new MyDictionary<string, byte>();
            myDictionary.Add("Ankara", 06);
            myDictionary.Add("Elazığ", 23);
            myDictionary.Add("Malatya", 44);

            myDictionary.Prints();
        }
    }

}