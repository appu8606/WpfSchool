using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSchool.Model;

namespace WpfSchool.ViewModel
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            LoadStudents();
        }
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

    

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
          

            Details JohnMark = new Details();
            JohnMark.Subcode = "cd323";
            JohnMark.TotMarks = 76;

            Details RichardMark = new Details();
            RichardMark.Subcode = "cd323";
            RichardMark.TotMarks = 76;


            Details SamMark = new Details();
            SamMark.Subcode = "cd323";
            SamMark.TotMarks = 76;


            //Marks JohnMark = new Marks();
            //JohnMark.English = 75;
            //JohnMark.Maths = 85;
            //JohnMark.Science = 95;

            //Marks RichardMark = new Marks();
            //RichardMark.English = 70;
            //RichardMark.Maths = 80;
            //RichardMark.Science = 90;

            //Marks SamMark = new Marks();
            //SamMark.English = 72;
            //SamMark.Maths = 82;
            //SamMark.Science = 92;

            students.Add(new Student { Name = "Mark", details = JohnMark });
            students.Add(new Student { Name = "Allen", details = RichardMark });
            students.Add(new Student { Name = "Linda", details = SamMark });

            Students = students;
        }
    }
}
