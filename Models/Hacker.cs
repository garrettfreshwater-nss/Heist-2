using System.Collections.Generic;
namespace heist_part_two
{
    public class Hacker : IRobber // TODO take care of ALARMS 
    // TODO Take the Bank parameter and decrement its appropraite security score by the SkillLevel. 
    //! i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            throw new System.NotImplementedException();
        }
    }
}