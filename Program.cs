using System;

namespace Lab4_1_ClassAndObjectPractice
{
    class Parallelogram
    {
        public double length;
        public double height;

        public void Resize(double newLength, double newHeight)
        {
            if (newLength < 0 || newHeight < 0) return;
            else
            {
                length = newLength;
                height = newHeight;
            }
        }

        public double GetArea()
        {
            return length * height;
        }

        public double GetPerimeter()
        {
            return 2 * (length + height);
        }

        public void Print()
        {
            Console.WriteLine("\nHere's your parallelogram:");
            Console.WriteLine($"Base: {length}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }
    }
    class Book
    {
        public string authorFirstName;
        public string authorLastName;
        public string ISBN;
        public string publisher;
        public int numCopiesSold;

        public void Sell(int numSold)
        {
            numCopiesSold += numSold;  // Altervatively: this.numCopiesSold += numSold;
        }
        public void Print()
        {
            Console.WriteLine("\nHere's your book:");
            Console.WriteLine($"Author: {authorFirstName} {authorLastName}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publisher: {publisher}");
            Console.WriteLine($"Copies sold: {numCopiesSold}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram p1 = new Parallelogram() { length = 2, height = 3 };
            Parallelogram p2 = new Parallelogram() { length = 5, height = 7 };

            p1.Print();
            p2.Print();

            p1.Resize(-11, 13);
            p2.Resize(17, -19);

            p1.Print();
            p2.Print();

            p1.Resize(0, 23);
            p2.Resize(29, 0);

            p1.Print();
            p2.Print();

            Book b1 = new Book() { authorLastName = "Stinks", authorFirstName = "R.L.", ISBN = "ABBA123", publisher = "Pelican", numCopiesSold = 5};
            Book b2 = new Book() { authorLastName = "Suess", authorFirstName = "Nurse", ISBN = "666", publisher = "In the Hat", numCopiesSold = 100000};
            Book b3 = new Book() { authorLastName = "Pawston", authorFirstName = "Shave", ISBN = "4455CC", publisher = "J & R Publishing House", numCopiesSold = 12};

            b1.Print();
            b2.Print();
            b3.Print();

            b1.Sell(1);
            b2.Sell(100);
            b3.Sell(101);

            b1.Print();
            b2.Print();
            b3.Print();
        }
    }
}
