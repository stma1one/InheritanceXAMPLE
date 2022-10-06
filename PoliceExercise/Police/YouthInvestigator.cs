using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceExercise.Police
{
    public class YouthInvestigator : Investigator
    {
        private bool specialTraining;

        public bool GetSpecialTraining()
        {
            return specialTraining;
        }

        public override void SetSeniority()
        {
            base.SetSeniority();
            if (specialTraining)
                seniority++;
        }
    }
}
