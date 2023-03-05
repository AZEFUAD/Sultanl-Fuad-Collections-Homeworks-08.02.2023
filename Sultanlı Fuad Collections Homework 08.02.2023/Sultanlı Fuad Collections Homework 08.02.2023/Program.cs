using System;
namespace Sultanlı_Fuad_Collections_Homework_08._02._2023
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Group> team = new List<Group>();

            var group = new Group
            {
                Name = "P331"
            };

            Checker(team, group);

            var group2 = new Group
            {
                Name = "P228"
            };
            Checker(team, group2);

            foreach (var item in team)
            {
                Console.WriteLine(item.GetDetails());
            }
        }

        public static void Checker(List<Group> team, Group group)
        {
            var isDublicatedId = team.Any(p => p.Name == group.Name);
            if (!isDublicatedId)
            {
                team.Add(group);
            }
        }
    }
}