using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = LoadTeams();
            var people = LoadPeople();

            Console.WriteLine("Choose from the following commands: Teams, TeamAdd, PersonAdd, AddPersonToTeam, Quit");
            string command = "";

            while (command.ToLower() != "quit")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "teams":
                        {
                            Command.ListTeams(teams);
                        }
                        break;
                    case "teamadd":
                        {
                            Console.WriteLine("Please enter a new team name.");
                            string teamName = Console.ReadLine();

                            Command.AddTeam(teamName, teams);
                            Console.WriteLine("Team successfuly added.");
                        }
                        break;
                    case "personadd":
                        {
                            Console.WriteLine("Please enter a first name.");
                            string firstName = Console.ReadLine();

                            Console.WriteLine("Please enter a first name.");
                            string lastName = Console.ReadLine();

                            Command.AddPerson(firstName, lastName, people);

                            Console.WriteLine("Team successfuly added.");
                        }
                        break;
                    case "quit":
                        break;
                    default:
                        {
                            Console.WriteLine("Please enter a valid command");
                        }
                        break;
                }
            }
        }

        private static List<Team> LoadTeams()
        {
            List<Team> teams = new List<Team>() { new Team("Red"), new Team("Blue"), new Team("Green"), new Team("Yellow") };
            return teams;
        }

        private static List<Person> LoadPeople()
        {
            List<Person> persons = new List<Person>() { new Person("Joe", "Smith"), new Person("Jane", "Miller"), new Person("Bob", "Williams"), new Person("Ellen", "Peterson") };
            return persons;
        }
    }
}
