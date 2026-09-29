using Advanced_c_.Models;
using System.ComponentModel;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_c_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Question 01
            //A Generic Class is a class that uses a type parameter(T) instead of specifying a data type in advance.
            //We use generics to avoid code duplication, improve code reusability, and provide type safety.
            #endregion
            #region Question 02
            //#region Number
            //Container<int> container = new();
            //container.Add(100);
            //Console.WriteLine(container.Get());
            //#endregion
            //////////
            //#region String
            //Container<string> container1 = new();
            //container1.Add("Shahd");
            //Console.WriteLine(container1.Get()); 
            //#endregion

            #endregion
            #region Question 03
            //Pair<int,string> employee = new(1, "Shahd");
            //Console.WriteLine(employee.First);
            //Console.WriteLine(employee.Second);
            #endregion
            #region Question 04
            //int a = 5;
            //int b = 10;
            //Utility<int>.Swap(ref a, ref b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            #endregion
            #region Question 05
            //int max = Utility<int>.FindMax(10, 20);
            //Console.WriteLine(max);
            //double maxDouble = Utility<double>.FindMax(10.5, 7.5);
            //Console.WriteLine(maxDouble); 
            #endregion
            #region Question 07
            //NumberContainer<int> n1 = new NumberContainer<int>();
            //n1.Value = 10;
            //Console.WriteLine(n1.Value);

            //NumberContainer<double> n2 = new NumberContainer<double>();
            //n2.Value = 5.5;
            //Console.WriteLine(n2.Value);

            //NumberContainer<bool> n3 = new NumberContainer<bool>();
            //n3.Value = true;
            //Console.WriteLine(n3.Value);
            #endregion
            #region Question 08
            //NumberContainer<string> c1 = new NumberContainer<string>();
            //c1.Value = "shahd";

            //Console.WriteLine(c1.Value);
            #endregion
            #region Question 09
            NumberContainer<Product> container =
            new NumberContainer<Product>();

            container.Value.Name = "Laptop";

            Console.WriteLine(container.Value.Name);
            #endregion

        }

    }
}
