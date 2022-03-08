using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace GenericSortedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool breakFlag = false;
            SortedIdNamesList<int, string> idNames = new SortedIdNamesList<int, string>();
            while (!breakFlag)
            {
                try
                {
                    Console.WriteLine("\nWhat action would you like to take in Studends List?\na - Add\nd - Remove\ne - Enumerate\nb - Contains\nc - Clear\nq - Quit");
                    string userActionListiner = Console.ReadLine().ToLower();
                    // -->
                    switch (userActionListiner)
                    {
                        case "a":
                            Console.WriteLine("Set the number id please - number:");
                            int keyInput = int.Parse(Console.ReadLine());
                            Console.WriteLine("Set the Value please:");
                            string valueInput = Console.ReadLine();
                            idNames.Add(keyInput, valueInput);
                            idNames.GetList();
                            break;
                        //
                        case "d":
                            if (idNames.Count > 0)
                            {
                                Console.WriteLine("Which ID To Remove?");
                                int idNumber = int.Parse(Console.ReadLine());
                                idNames.Remove(idNumber);
                                idNames.GetList();
                            }
                            else
                                Console.WriteLine("There is no record in students list");
                            break;
                        //
                        case "e":
                            if (idNames.Count > 0)
                                idNames.GetList();
                            else
                                Console.WriteLine("There is no record in students list");
                            break;
                        //
                        case "b":
                            Console.WriteLine("Please set the search input:");
                            string studentNameSearch = Console.ReadLine();
                            if (idNames.Contains(studentNameSearch) == true)
                                Console.WriteLine("The Object is exist in Key Value List");
                            else
                                Console.WriteLine("The Object is not exist in Key Value List");
                            break;
                        //
                        case "c":
                            idNames.Clear();
                            break;
                        //
                        case "q":
                            breakFlag = true;
                            break;
                        //
                        default:
                            Console.WriteLine("Wrong Chiose, please try again!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The operation is failure!");
                    idNames.GetList();
                }

            }
        }
    }
}