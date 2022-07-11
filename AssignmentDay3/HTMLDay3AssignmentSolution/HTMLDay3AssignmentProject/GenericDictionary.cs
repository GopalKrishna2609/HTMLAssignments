using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDay3AssignmentProject
{
    internal class GenericDictionary
    {
        public static void Dictionary()
        {
            Dictionary<string, string> CricketTeam = new Dictionary<string, string>();
            CricketTeam.Add("Captain", "Rohit Sharma");
            CricketTeam.Add("WicketKeeper", "Rishabh Pant ");
            CricketTeam.Add("BatsMan1", "Virat Kohli");
            CricketTeam.Add("BatsMan2", "Suryakumar Yadav");
            CricketTeam.Add("BatsMan3", "Shreyas Iyer");
            CricketTeam.Add("BatsMan4", "Dinesh Karthik");
            CricketTeam.Add("AllRounder", "Ravindra Jadeja");
            CricketTeam.Add("Baller1", "Harshal Patel");
            CricketTeam.Add("Baller2", "Avesh Khan");
            CricketTeam.Add("Baller3", "Umran Malik");
            CricketTeam.Add("Baller4", "Ravi Bishnoi");
            Console.WriteLine("Indian Cricket Team :-\n");
            foreach (KeyValuePair<string,string> CT in CricketTeam)
            {
                Console.WriteLine("{0} - {1}", CT.Key, CT.Value);
            }
        }
    }
}
