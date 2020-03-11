//! Each type of robber will have a special skill that will come in handy while knocking over banks. Start by creating an interface called IRobber. The interface should include:
//! A string property for Name
//! An integer property for SkillLevel
//! An integer property for PercentageCut
//TODO A method called PerformSkill that takes in a Bank parameter and doesn't return anything.

namespace heist_part_two
{
    public interface IRobber // Inhertance apply rules
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill(Bank bank);

    }

}