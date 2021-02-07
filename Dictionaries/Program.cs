using System;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> sozluk = new MyDictionary<string, string>();
            sozluk.Add("elma","apple");
            sozluk.Add("fare","mouse");
            sozluk.Add("su","water");
            sozluk.ToList();
        }
    }
}
