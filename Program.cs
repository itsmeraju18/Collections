using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class index
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            {
                if (numbers[index] % 2 == 1)
                {
                    //Remove the element by spwcifing 
                    // the zero-based index in the list.
                    numbers.RemoveAt(index);
                }
            }
            // Iterate through the list
            // A lambda expression is placed in the ForEach method of the List(T)object.
            numbers.ForEach(
                number => Console.WriteLine(number + ""));
            
        }
    }
}
