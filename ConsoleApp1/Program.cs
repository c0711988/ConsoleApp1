using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0711988
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {

            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else { Console.WriteLine("Promoted to Level 2"); }
        }
        public int CalculateRating()
        {
            return 0;
        }
        class Program
        {
            static void Main(string[] args)
            {
                //var dog_and_cat = new Car();
                // var bowling = new Car();
                //Console.WriteLine("how many cars : {0}", Vehicle.howManyCars);

                Book myBook = new Book();
                myBook.SetTitle(" A Separate Peace");
                Console.WriteLine(myBook.GetTitle());
                Console.ReadLine();

            }

            class Vehicle
            {
                public static int howManyCars = 0;
            }
            class Car : Vehicle
            {
                public String Color = "Red";
                public Car()
                {
                    Console.WriteLine("my color is " + Color);
                    Console.ReadLine();
                }
            }

            class BookCollection
            {

            }
            class Book : BookCollection
            {
                private string Title;
                private void SetTitle(String aTitle) { this.Title = aTitle; }
                public String GetTitle() { return this.Title; }
            }
        }
    }
}