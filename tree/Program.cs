using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementCollection = new BinarySearchTree();

            var array = new int[] { 25, 20, 30, 15, 45, 70, 80, 10, 65, 75, 35, 45, 20, 45 };

            foreach (var element in array)
            {
                elementCollection.AddElement(element);
            }

            int counter;
            bool numberAvailability;

            foreach (var element in array)
            {             
                numberAvailability = elementCollection.Check(element, out counter);

                Console.WriteLine($"Число: {element}| Наличие числа: {numberAvailability}| Кол-во вхождений:{counter}");
            }

            Console.ReadKey();
        }
    }
}
