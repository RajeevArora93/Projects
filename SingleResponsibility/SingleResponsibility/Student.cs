using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int studentNumber { get; set; }
        public double studentDebt { get; set; }


        //No relevant information for student class
        //Does not follow SRP because the student shouldn't
        //be respobsible for this data
        //This is closely linked to encapsulation

        /*
        public int studentUnionPhoneNumber { get; set; }
        public DateTime studentUnionHappyHour { get; set; }
        public string lecturer { get; set; }
        */

        //The following methods are related to student however the,
        //class do not define it - They manipulate it and therefore
        //should be moved to a different class
        //e.g StudentController.cs

        /*
        public void GoToLecture() 
        { 
            
        }

        public void RegisterForNewCourse()
        { 
        
        }
        */
    }
}
