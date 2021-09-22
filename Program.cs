// Thomas Lauer
// September 21, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210921
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shirt aShirt1 = new Shirt("t-shirt", "red", "XXXXS", 4.20);
            Shirt aShirt2 = new Shirt("v-neck", "purple", "M", 6.9);
            Shirt aShirt3 = new Shirt("turtle neck", "brown", "XXXXL", 69420);
            Shirt aShirt4 = new Shirt("croptop", "tie-dye", "U", 0);
            Shirt aShirt5 = new Shirt("berriesandcream", "burgundy", "XL", 666);

            aShirt3.ApplyDiscount(0.69);

            List<Shirt> listOfShirts = new List<Shirt>();
            listOfShirts.Add(aShirt1);
            listOfShirts.Add(aShirt2);
            listOfShirts.Add(aShirt3);
            listOfShirts.Add(aShirt4);
            listOfShirts.Add(aShirt5);

            foreach(Shirt s in listOfShirts)
            {
                Console.WriteLine(s.ToString());
            }

            Console.ReadLine();
        }
    }
}
