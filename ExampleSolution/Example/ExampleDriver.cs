using Example.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ExampleDriver
    {
        static void Main()
        {

            /*for (int i = 0; i < 15; i++) {
                Console.WriteLine(MyMethods.FibRecurssion(i));
            }
            Console.Read();*/
            ArrayList arr = new ArrayList();

            for (int i = 0; i < 15; i++)
            {
                arr.Add(i);

            }
            arr.RemoveAt(4);
            try
            {
                object o = arr[arr.Count-1];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                // Set IndexOutOfRangeException to the new exception's InnerException.
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
                
            }

            Person person = new Person();


            //Console.WriteLine(person.Age);
            //Console.Read();
            double total = 0;
            double output = MyMethods.PennyShade(12.000134);
            double output1 = MyMethods.PennyShade(12.000134);
            double output2 = MyMethods.PennyShade(12.000134);

            total += output;
            total += output1;
            total += output2;

            Console.WriteLine(total);
            Console.Read();
        }
    }
}
