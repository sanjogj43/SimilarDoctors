using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarDoctors
{
    // Define a singleton class for List of Doctors. This way the list could not be altered from outside and
    // we can have just one instance of this class.
    public class ListOfDoctorsViewModel
    {
        // private static object of itself
        private static ListOfDoctorsViewModel ListClassObj;
        
        public List<DoctorViewModel> ListOfDoctors { get; set; }
        
        public static ListOfDoctorsViewModel GetInstance()
        {
            if (ListClassObj == null)
            {
                ListClassObj = new ListOfDoctorsViewModel();
                return ListClassObj;
            }
            else
            {
                return ListClassObj;
            }
        }

        // Private constructor
        private ListOfDoctorsViewModel()
        {
            ListOfDoctors = new List<DoctorViewModel>
            {
                new DoctorViewModel{ Id = 1,Name = "Mark Smith",Speciality="Pediatrics",AreaCode="90034",Organisation="Pacific Alliance",ReviewScore=4.5,NumberOfReviews=18,Degree="MD"},
                new DoctorViewModel{ Id = 2,Name = "John Cooper",Speciality="Internal",AreaCode="90030",Organisation="Pacific Alliance",ReviewScore=3.5,NumberOfReviews=50,Degree="DO"},
                new DoctorViewModel{ Id = 3,Name = "Jill Anderson",Speciality="Pediatrics",AreaCode="90029",Organisation="White Memorial",ReviewScore=5,NumberOfReviews=20,Degree="MD"},
                new DoctorViewModel{ Id = 4,Name = "Phil Triu",Speciality="Internal",AreaCode="90013",Organisation="White Memorial",ReviewScore=2.9,NumberOfReviews=15,Degree="MD"},
                new DoctorViewModel{ Id = 5,Name = "Rakesh Mehta",Speciality="Pediatrics",AreaCode="90034",Organisation="Pacific Alliance",ReviewScore=4,NumberOfReviews=32,Degree="DO"},
                new DoctorViewModel{ Id = 6,Name = "Jim Summers",Speciality="Pediatrics",AreaCode="90034",Organisation="Silver Lake",ReviewScore=3.2,NumberOfReviews=22,Degree="MD"},
                new DoctorViewModel{ Id = 7,Name = "James Harris",Speciality="Internal",AreaCode="90013",Organisation="White Memorial",ReviewScore=3.9,NumberOfReviews=7,Degree="MD"},
                new DoctorViewModel{ Id = 8,Name = "Eric Mellum",Speciality="Geriatric",AreaCode="90029",Organisation="Pacific Alliance",ReviewScore=2.7,NumberOfReviews=9,Degree="MD"},
                new DoctorViewModel{ Id = 9,Name = "Bill Clinton",Speciality="Pediatrics",AreaCode="90030",Organisation="White Memorial",ReviewScore=4.7,NumberOfReviews=20,Degree="PHD"},
                new DoctorViewModel{ Id = 10,Name = "Jeff Sully",Speciality="Family",AreaCode="90013",Organisation="Pacific Alliance",ReviewScore=3.4,NumberOfReviews=23,Degree="PHD"},
                new DoctorViewModel{ Id = 11,Name = "Nathan Drake",Speciality="Family",AreaCode="90013",Organisation="Silver Lake",ReviewScore=4.1,NumberOfReviews=18,Degree="DO"}
            };
        }

        // Display list of doctors to the user
        public static void DisplayListOfdoctors()
        {
            Console.WriteLine("Please select the id from following list of Doctors:");
            Console.WriteLine("    1 : Mark Smith\n    2 : John Cooper\n    3 : Jill Anderson\n    4 : Phil Triu\n    5 : Rakesh Mehta");
            Console.WriteLine("    6 : Jim Summers\n    7 : James Harris\n    8 : Eric Mellum\n    9 : Bill Clinton\n    10 : Jeff Sully\n    11 : Nathan Drake\n");
        }
    }
}
