using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int free;
            int tickets;
            int kidTickets = 0;
            int studentsTickets = 0;
            int standardTickets = 0;
            string type;

            while (input != "Finish")
            {
                free = int.Parse(Console.ReadLine());
                tickets = 0;
                type = Console.ReadLine();

                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentsTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }

                    tickets++;

                    if (tickets >= free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                Console.WriteLine($"{input} - {tickets * 100.0 / free:F2}% full.");
                input = Console.ReadLine();
            }

            int totalTickets = standardTickets + studentsTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsTickets * 100.0 / totalTickets:F2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:F2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:F2}% kids tickets.");
        }
    }
}