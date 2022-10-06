using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceExercise.Police
{
    public class Sheriff : PolicePerson
    {
        private string rank;//דרגה

        public override void SetSeniority()
        {
            base.SetSeniority();
            seniority++;
        }
    }
}
