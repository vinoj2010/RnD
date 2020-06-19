using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLibrary
{
    public class Class1
    {
        const string saltKey = "werterytrutr";
        void Function1(string args1)
        {
            Console.WriteLine("This is Function1");    
        }

        void Function2(string args1)
        {
            Console.WriteLine("This is Function2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }            
        }
    }
}
