using DemoLibrary.DVD;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Interface Segregation Principle: A client should not be forced to depend upon interfaces it does not use.
             * 
             * We will break down ILibraryItem into smaller pieces.
             * 
             * We created the empty IBorrowableDVD interface to allow access to all properties/methods in IDVD and
             * IBorrowable. 
             */
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
