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
            */
            #endregion

            #region Q3 - Find the oldest person
            /*
            Console.WriteLine("--- Question 3: Find The Oldest Person ---");
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                Console.Write("Name: ");
                persons[i].Name = Console.ReadLine();
                Console.Write("Age: ");
                persons[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            Person oldestPerson = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldestPerson.Age)
                {
                    oldestPerson = persons[i];
                }
            }

            Console.WriteLine("\nDetails of the oldest person:");
            oldestPerson.Display();
            */
            #endregion

            #region Q4 - Rectangle struct demonstration
            /*
            Console.WriteLine("--- Question 4: Rectangle Struct Demo ---");
            Rectangle rect = new Rectangle();

            Console.WriteLine("Setting valid dimensions...");
            rect.Width = 10.5;
            rect.Height = 5.2;
            rect.DisplayInfo();

            Console.WriteLine("\nTrying to set negative width...");
            rect.Width = -4.0; // This will print an error message
            rect.DisplayInfo(); // Dimensions should remain unchanged

            Console.WriteLine("\nTrying to set negative height...");
            rect.Height = -2.3; // This will print an error message
            rect.DisplayInfo(); // Dimensions should remain unchanged

            Console.WriteLine("\nSetting new valid height...");
            rect.Height = 7.0;
            rect.DisplayInfo(); // Area should be updated

            */
            #endregion
        }
    }
}
