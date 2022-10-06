using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceExercise.Police
{
    /// <summary>
    /// base class for a police station
    /// </summary>
    public class PolicePerson
    {
        protected string name;//שם
        protected string id;//ת.ז
        protected int seniority;//ותק

        public virtual void SetSeniority()
        {
            seniority++;
        }
    }

}

