using System;

namespace MyListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Zonguldak");
            sehirler.Add("Kastamonu");
            sehirler.Add("Antalya");

            Console.WriteLine(sehirler.Count);
            
        }

        


        
    }
}
