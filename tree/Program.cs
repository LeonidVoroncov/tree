using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementCollection = new ElementCollection();

            int[] array = new int[] { 25, 20, 30, 15, 45, 70, 80, 10, 65, 75, 35, 45, 20, 45 };

            foreach (var element in array)
            {
                elementCollection.AddElement(element);
            }

            int counte;
            var checkedElements = false;

            foreach (var element in array)
            {
                elementCollection.Get(out counte, element,out checkedElements);

                Console.WriteLine($"Число: {element}| Наличие числа: {checkedElements}| Кол-во вхождений:{counte}");
            }

            Console.ReadKey();
        }
    }
}
