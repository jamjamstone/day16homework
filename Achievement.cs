using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16homework
{
    internal class Achievement
    {
        string Name;
        string Description;
        int Goal;
        int Progress = 0;
        bool isCompleted = false;
        static int TotalAchievements;
        static int CompletedAchievemets;
        public Achievement()
        {

        }
        public Achievement(string name, string description, int goal)
        {
            Name = name;
            Description = description;
            Goal = goal;
            TotalAchievements++;
        }
        public void AddProgress(int value)
        {
            Progress += value;
            if (Progress >= Goal)
            {
                isCompleted = true;
                CompletedAchievemets++;
                Console.WriteLine($"업적 {Name} 달성!");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine(Description);
            Console.Write(Goal);
            Console.Write("/");
            Console.WriteLine(Progress);
            if (isCompleted)
            {
                Console.WriteLine("업적 달성!");
            }
            else
            {
                Console.WriteLine("업적 미달성!");
            }
        } 


        public static void DisplaySummary()
        {
            Console.WriteLine($"총 업적수/달성한 업적수{TotalAchievements}/{CompletedAchievemets}");
        }



    }
}
