using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C44_G02_OOP02
{
    // Struct for Questions 1 and 3
    struct Person
    {
        public string Name;
        public int Age;

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Struct for Question 2
    struct Point
    {
        public double X;
        public double Y;
    }

    // Struct for Question 4
    struct Rectangle
    {
        private double width;
        private double height;

        // Public property for width with validation
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }
                else
                {
                    width = value;
                }
            }
        }

        // Public property for height with validation
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Height cannot be negative.");
                }
                else
                {
                    height = value;
                }
            }
        }

        // Read-only property to calculate the area
        public double Area
        {
            get { return width * height; }
        }

        // Method to display rectangle's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Display details of three persons
            /*
            Console.WriteLine("--- Question 1: Person Details ---");
            Person[] people = new Person[3];

            people[0] = new Person { Name = "Alice", Age = 30 };
            people[1] = new Person { Name = "Bob", Age = 25 };
            people[2] = new Person { Name = "Charlie", Age = 35 };

            Console.WriteLine("Details of all persons:");
            foreach (var person in people)
            {
                person.Display();
            }
            Console.WriteLine("---------------------------------\n");
            */
            #endregion

            #region Q2 - Calculate distance between two points
            /*
            Console.WriteLine("--- Question 2: Distance Between Two Points ---");
            Point p1, p2;

            Console.Write("Enter X for Point 1: ");
            p1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y for Point 1: ");
            p1.Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter X for Point 2: ");
            p2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y for Point 2: ");
            p2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            Console.WriteLine($"The distance between the two points is: {distance:F2}");
            Console.WriteLine("-------------------------------------------\n");
            */
            #endregion

            
        }
    }
}
