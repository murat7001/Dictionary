using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();
            AdYas.Add("Murat", 19);
            AdYas.Add("Çağrı",19);

            foreach (var item in AdYas.value)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
