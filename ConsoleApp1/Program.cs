using System;
using System.Collections;

namespace InterIEnumerable
{
    class Program
    {
        static void Main()
        {
            UserCollection myCollection = new UserCollection();

            foreach (Collection element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }


            Console.Write(new string('-', 29) + "\n");

            foreach (Collection element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n");


            UserCollection myElementsCollection = new UserCollection();


            IEnumerable enumerable = myElementsCollection as IEnumerable;
       
            IEnumerator enumerator = enumerable.GetEnumerator();


            while (enumerator.MoveNext())
            {
                Collection element = enumerator.Current as Collection;

                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }


            enumerator.Reset();

            Console.ReadKey();
        }
    }
}
