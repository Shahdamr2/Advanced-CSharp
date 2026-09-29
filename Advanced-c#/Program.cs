using Advanced_c_.Models;
using Advanced_c_.Repository;
using Advanced_c_.Interface;
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
            //NumberContainer<Product> container =
            //new NumberContainer<Product>();

            //container.Value.Name = "Laptop";

            //Console.WriteLine(container.Value.Name);
            #endregion
            #region Question 10
            //var printer =new Advanced_c_.Interface.GenericPrinter<Advanced_c_.Repository.Product>();

            //var product = new Advanced_c_.Repository.Product
            //{
            //    Name = "Laptop"
            //};

            //printer.PrintItem(product);
            #endregion
            #region Question 11

            //AnimalContainer<Dog> container = new AnimalContainer<Dog>();

            //container.Value = new Dog
            //{
            //    Name = "Max"
            //};

            //Console.WriteLine(container.Value.Name);

            #endregion
            #region Question 12

            //var container = new ComparableContainer<Book>();

            //Book book = container.Create();
            //book.Title = "C# Advanced";

            //Console.WriteLine(book.Title);
            #endregion
            #region Question 13
            //var intContainer = new DefaultContainer<int>();
            //Console.WriteLine(intContainer.GetDefault());

            #endregion
            #region Question 14
            //SafeList<int> numbers = new SafeList<int>();

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //Console.WriteLine(numbers.Get(1));
            //Console.WriteLine(numbers.Get(5));

            #endregion
            #region Question 15
            //Pair<int> numbers = new Pair<int>(10, 20);
            //numbers.Display();

            //Pair<string> names = new Pair<string>("Ali", "Sara");
            //names.Display(); 
            #endregion
            #region Question 16
            //IPrinter<Dog> printer = new AnimalPrinter();

            //Dog dog = new Dog { Name = "Max" };

            //printer.Print(dog);

            #endregion
            #region Question 17
            //    // Covariance (out)
            //    IEnumerable<Dog> dogs = new List<Dog>
            //{
            //    new Dog { Name = "Max" }
            //};

            //    IEnumerable<Animal> animals = dogs;

            //    foreach (Animal animal in animals)
            //    {
            //        Console.WriteLine("Covariance: " + animal.Name);
            //    }

            //    // Contravariance (in)
            //    Action<Animal> printAnimal = animal =>
            //        Console.WriteLine("Contravariance: " + animal.Name);

            //    Action<Dog> printDog = printAnimal;

            //    printDog(new Dog { Name = "Rocky" });
            #endregion
            #region Question 18

            //Counter<int> c1 = new Counter<int>();
            //Counter<int> c2 = new Counter<int>();
            //Counter<int> c3 = new Counter<int>();

            //Counter<string> c4 = new Counter<string>();

            //Console.WriteLine("Int Count: " + Counter<int>.Count);
            //Console.WriteLine("String Count: " + Counter<string>.Count);

            #endregion
            #region Question 19
            MyContainer<string> c1 = new MyContainer<string>();
            c1.Value = "Hello";
            c1.Display();

            MyContainer<int> c2 = new MyContainer<int>();
            c2.Value = 100;
            c2.Display();
            #endregion
        }
    }

}

    

