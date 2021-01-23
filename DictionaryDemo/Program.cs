using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> books = new MyDictionary<int, string>();

            books.Add(1, "Beyaz Zambaklar Ülkesinde");
            books.Add(2, "Sefiller");
            books.Add(3, "Dönüşüm");

            books.GetList();

            Console.Read();
        }
    }
}
