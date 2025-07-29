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

            
        }
    }
}
