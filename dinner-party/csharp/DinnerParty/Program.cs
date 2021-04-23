using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        //defining a custom class Guest
        //this object will have 3 public properties -name, occupation, bio
        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }

        public class Table 
        {
            public List<Guest> Table1 { get; set ; } = new List<Guest> ();
            public List<Guest> Table2 { get; set ; } = new List<Guest> ();

        }

        //defining a method to GetAllGuests that will return a list of all the guest objects 
        static List<Guest> GetAllGuests()
        {
            List<Guest> allGuests = new List<Guest>() {
        new Guest() {
            Name = "Marilyn Monroe",
            Occupation = "entertainer",
            Bio = "(1926 - 1962) American actress, singer, model"
        },
        new Guest() {
            Name = "Abraham Lincoln",
            Occupation = "politician",
            Bio = "(1809 - 1865) US President during American civil war"
        },
        new Guest() {
            Name = "Martin Luther King",
            Occupation = "activist",
            Bio = "(1929 - 1968)  American civil rights campaigner"
        },
        new Guest() {
            Name = "Rosa Parks",
            Occupation = "activist",
            Bio = "(1913 - 2005)  American civil rights activist"
        },
        new Guest() {
            Name = "Peter Sellers",
            Occupation = "entertainer",
            Bio = "(1925 - 1980) British actor and comedian"
        },
        new Guest() {
            Name = "Alan Turing",
            Occupation = "computer scientist",
            Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new Guest() {
            Name = "Admiral Grace Hopper",
            Occupation = "computer scientist",
            Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new Guest() {
            Name = "Indira Gandhi",
            Occupation = "politician",
            Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
        }
        };

            return allGuests;
        }

        static void Main(string[] args)
        {

            //defining a list variable guestList to catch the return of the method GetAllGuest()
            List<Guest> guestList = GetAllGuests();

            // Table Tables = new Table();
            
            Console.WriteLine();

            
            List<Guest> guestAtTable1 = new List<Guest>();
            List<Guest> guestAtTable2 = new List<Guest>();

            

            foreach (Guest guest in guestList) {
                List<string> table1Occupations = guestAtTable1.Select(g => g.Occupation).ToList();
                if (table1Occupations.Contains(guest.Occupation))
                {
                    guestAtTable2.Add(guest);
                }
                else
                {
                    guestAtTable1.Add(guest);
                }
            
            }

            Console.WriteLine("Table 1");
                foreach (Guest guest in guestAtTable1)
                {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                }
            
            Console.WriteLine();
            Console.WriteLine("Table 2");
                foreach (Guest guest in guestList) 
                {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                }

        }
    }

}
