using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Movie
    {

        // We're first defining the class
        public double boxOffice { get; set; }
        public double homeMedia { get; set; }
        public string overallRating { get; set; }

        // We'll make it simple to where you can use just movie names and box office info.
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        // Star Wars will win this round, but a couple of other interesting-looking movies will also be noted
        public Movie()
        {
            this.boxOffice = 2100000000;
            this.homeMedia = 100000000;
            this.name = "Star Wars";
            this.overallRating = "Box office Smash";

            numOfMovies++;
        }

        // You can create custom constructors as well
        public Movie(double boxOffice, double homeMedia, string name, string overallRating)
        {
            this.boxOffice = boxOffice;
            this.homeMedia = homeMedia;
            this.name = name;
            this.overallRating = overallRating;

            numOfMovies++;
        }

        // In this case, I'm just making a constructor to hold the number of episodes in Star Wars
        static int numOfMovies = 7;

        // A static method cannot access non-static class members
        public static int getNumOfMovies()
        {
            return numOfMovies;
        }

        // Declare a method
        public string toString()
        {
            return String.Format("{0} made approximately ${1} at screenings, ${2} for home audiences, " + 
                "and has been called a {3}", name, boxOffice, homeMedia, overallRating);
        }

        // Overloading methods works if you have methods with different attribute data types
        // You can give attributes default values
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            // Create a new movie
            Movie The_Ravenant = new Movie(3000000, 20000, "The Ravenant", "Box office Smash");

            // Get object values with the dot operator
            Console.WriteLine("{0} says {1}", The_Ravenant.name, The_Ravenant.overallRating);

            // Calling a static method
            Console.WriteLine("Number of Movies " + Movie.getNumOfMovies());

            // Calling an object method
            Console.WriteLine(numOfMovies.toString());

            Console.WriteLine("3 + 4 = " + The_Ravenant.getSum(3, 4));

            // You can assign attributes by name
            Console.WriteLine("3.4 + 4.5 = " + numOfMovies.getSum(num2: 3.4, num1: 4.5));

            // You can create objects with an object initializer
            Movie The_Forest = new Movie
            {
                name = "The Forest",
                boxOffice = 160000,
                homeMedia = 18500,
                overallRating = "Very well made"
            };

            Console.WriteLine(The_Forest.toString());

            // Create a subclass Dog object
            Movie spike = new Movie();

            Console.WriteLine(spike.toString());

            spike = new Movie(200000, 17500, "Love American Style", "Oldie");

            Console.WriteLine(spike.toString());

            //------------------------------------------------------------------

            // Now we get into polymorphism of object-oriented programming
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);
            Console.WriteLine("Rect Area " + rect.area());
            Console.WriteLine("Trit Area " + tri.area());

            // Using the overloaded + on 2 Rectangles
            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect Area = " + combRect.area());

            // ---------- GENERICS ----------
            // With Generics you don't have to specify the data type of an element in a class or method
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";
            superman.showData();

            // Now use completely different types
            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");
            samsungTV.key = 123456;
            samsungTV.value = "a 50in Samsung TV";
            samsungTV.showData();

            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();

        }
    }

    class Thriller : Movie
    {
        public string countryOfOrigin { get; set; }

        // Set the favFood default and then call the Animal super class constructor
        public Thriller() : base()
        {
            this.countryOfOrigin = "United States";
        }

        public Thriller(double boxOfficeCash, double homeAudienceCash, string name, string rating, Boolean choose) :
            base(boxOfficeCash, homeAudienceCash, name, name)
        {
            this.name = name;
        }

        // Override methods with the keyword new
        new public string toString()
        {
            return String.Format("{0} was a smash hit making ${1}, at home it made ${2} and audience thought it was a{3}", name, boxOffice, homeMedia, overallRating);
        }

    }

       //Here are some other uses:
    abstract class Shape
    {
        public abstract double area();

        // An abstract class can contain complete or default code for methods
        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    // A class can have many interfaces
    // An interface can't have concrete code
    public interface ShapeItem
    {
        double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        // You can redefine many built in operators so that you can define what happens when you 
        // add to Rectangles
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);

        }

    }

    class Triangle : Shape
    {
        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }

    // ---------- GENERIC CLASS ----------

    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }

    }

}

