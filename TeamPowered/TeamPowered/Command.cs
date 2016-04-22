using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    public class Command
    {
        internal static void ListTeams(List<Team> teams)
        {
            foreach (var team in teams)
            {
                Console.WriteLine(team.Name);
            }
        }

        internal static void AddTeam(string teamName, List<Team> teams)
        {
            teams.Add(new Team(teamName));
        }

        internal static void AddPerson(string firstName, string lastName, List<Person> people)
        {
            people.Add(new Person(firstName, lastName));
        }
    }
}
