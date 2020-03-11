using System.Collections.Generic;
namespace heist_part_two
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public bool IsSecure { get; set; }
        //TODO If all the scores are less than or equal to 0, this should be false.If any of the scores are above 0, this should be true

        public override string ToString()
        {
            return $"Bank has ${CashOnHand}. Bank Security level is ${SecurityGuardScore}!";
        }

        // The collection of exercises that the student is currently working on
        // public List<Exercise> Exercises = new List<Exercise>();

        // public Rose(string color, string name, string type, int cost, string waterschedule, bool thorny, bool fragrant)
        // {
        //     Color = color;
        //     Name = name;
        //     Type = type;
        //     Cost = cost;
        //     WaterSchedule = waterschedule;
        //     Thorny = thorny;
        //     Fragrant = fragrant;
        // }

    }
}