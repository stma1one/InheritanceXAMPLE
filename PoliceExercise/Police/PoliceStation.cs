using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceExercise.Police
{
    /// <summary>
    /// police Station class
    /// </summary>
    public class PoliceStation
    {
        private const int PERSONAL = 100;//כמות שוטרים מקסימלית
        private PolicePerson[] persons;//מערך של שוטרים

        public PoliceStation()
        {
            persons = new PolicePerson[PERSONAL];
        }

        public int SpecialYouthInvestigator()
        {
            int counter = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                //מכיוון שתחנת משטרה יכולה להכיל עד 100 שוטרים.
                //יכול להיות או שהתחנה ריקה משוטרים (כל התאים נאל) או שיש פחות מ-100 
                //ואז לפחות תא אחד עשוי להיות ריק
                //ולכן כדי שהתוכנית לא תעוף -צריך לוודא שקיים אובייקט בתא במערך
                if (persons[i] != null && persons[i] is YouthInvestigator)
                {
                    YouthInvestigator p= (YouthInvestigator)persons[i];
                    if(p.GetSpecialTraining())
                    //if (((YouthInvestigator)persons[i]).GetSpecialTraining())
                        counter++;
                }
                    
                       
            }
            return counter;

        }
        public void SetSeniorty()
        {
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    PolicePerson person = persons[i];
            //}
            foreach(PolicePerson person in persons )
            {
                person.SetSeniority();
            }
        }

    }
}
