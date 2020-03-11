using System.Collections.Generic;
namespace heist_part_two
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        //TODO If all the scores are less than or equal to 0, this should be false.If any of the scores are above 0, this should be true
        public bool IsSecure
        {
            get
            {
                if (CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public override string ToString()
        {
            return $"Bank has ${CashOnHand}. Bank Security level is ${SecurityGuardScore}!";
        }

    }
}