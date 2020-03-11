using System;
using System.Collections.Generic;
namespace heist_part_two
{
    public class LockSpecialist : IRobber //TODO crack the vaults.
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            Console.WriteLine();
        }
    }
}