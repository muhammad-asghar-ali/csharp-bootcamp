using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Threads
{
    public class Program
    {
        // With threads you can execute multiple pieces of code that share resources and data without corrupting it
        // You can't guarantee when a thread executes. You also must lock resources  until a thread is done with them
        // or you could corrupt them
        static void Main(string[] args)
        {
            // We will randomly print 1 or 0. Create a thread and start it
            Thread t = new(Print1);
            t.Start();

            for (int i = 0; i < 1000; i++) Console.Write(0);

            PrintNumbersWithSleep();

            // Create a BankAcct object with an initial balance of 10
            BankAcct acct = new(10);

            // Call the function to handle thread execution
            HandleThreadExecution(acct);

            Thread t1 = new(() => CountTo(10));
            t1.Start();

            // You can use multiline lambdas
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadLine();

            Console.ReadLine();
        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++) Console.Write(1);
        }

        static void PrintNumbersWithSleep()
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);

                // Pause for 1 second
                Thread.Sleep(1000);

                num++;
            }

            Console.WriteLine("Thread Ends");
        }

        // Define the function to handle thread creation and execution
        static void HandleThreadExecution(BankAcct acct)
        {
            // Create an array to hold 15 threads
            Thread[] threads = new Thread[15];

            // Set the current thread's name
            Thread.CurrentThread.Name = "main";

            // Create 15 threads that will call IssueWithdraw
            for (int i = 0; i < 15; i++)
            {
                // Create a new thread pointing to IssueWithdraw
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            // Start each thread and check if it's alive
            for (int i = 0; i < 15; i++)
            {
                // Check if thread has started
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);

                // Start the thread
                threads[i].Start();

                // Check again if thread is alive after starting
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
            }

            // Print the priority of the current thread
            Console.WriteLine("Current Priority: {0}", Thread.CurrentThread.Priority);

            // Indicate that the main thread is ending
            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}