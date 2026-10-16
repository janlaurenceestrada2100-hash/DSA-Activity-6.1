using System;
using System.Collections.Generic;

namespace DSA_Activity_53_Estrada_JanLaurence
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * DSA ACTIVITY 6.1 - ESTRADA JAN LAURENCE
             * PROGRAM DESCRIPTION
             * 
             */
            try
            {

                Console.WriteLine("WELCOME TO MY JOB SCHEDULING");
                Queue<string> jobs = new Queue<string>();
                int counter = 1;
                int i = 0;
                while (i != 7)
                {
                    Console.WriteLine();

                    Console.WriteLine("Choose what you want to do?");

                    Console.WriteLine();

                    Console.WriteLine("1 - NEW JOB");
                    Console.WriteLine("2 - FINISH JOB");
                    Console.WriteLine("3 - SEARCH JOB");
                    Console.WriteLine("4 - CURRENT JOB");
                    Console.WriteLine("5 - DISPLAY ALL JOBS");
                    Console.WriteLine("6 - COUNT JOBS ");
                    Console.WriteLine("7 - EXIT ");
                    Console.Write("Enter Code: ");

                    i = Convert.ToInt32(Console.ReadLine());

                    switch (i)

                    {
                        case 1:
                            Console.WriteLine();
                            Console.Write("Enter New Job: ");
                            jobs.Enqueue(Console.ReadLine());
                            Console.WriteLine("New job has been added! ");
                            Console.WriteLine();

                            break;
                        case 2:
                            if (jobs.Count == 0)
                            {
                                Console.WriteLine("There are NO JOBS in the list.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                jobs.Dequeue();
                                Console.WriteLine("The current job has been marked FINISHED! ");
                                Console.WriteLine($"Total number of finished jobs: {counter++}");
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.Write("Job to be searched: ");

                            Console.WriteLine();

                            if (jobs.Contains(Console.ReadLine()) == false) { Console.WriteLine("NO Job Named THAT was FOUND!"); }
                            else { Console.WriteLine("Job Found!"); }
                            Console.WriteLine();
                            break;
                        case 4:

                            Console.WriteLine();

                            if (jobs.Count == 0)
                            {
                                Console.WriteLine("There are no current JOB in the list.");
                                Console.WriteLine();
                            }
                            else { Console.WriteLine($"The CURRENT Job is {jobs.Peek()}"); }
                            Console.WriteLine();

                            break;
                        case 5:

                            Console.WriteLine();

                            if (jobs.Count == 0) { Console.WriteLine("There are NO JOBS in the list."); }
                            else
                            {
                                foreach (var item in jobs)
                                {
                                    Console.Write(item + ", ");
                                }
                            }
                            Console.WriteLine();

                            break;
                        case 6:

                            Console.WriteLine($"The Total Number of Jobs in the Queue is {jobs.Count}");

                            break;
                        case 7:
                            Console.WriteLine("You Have Left The Jobs Program...");
                            return;
                        default:
                            return;    
                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


        }

    }

}

