using System;
using System.Collections.Generic;
using System.Text;

using StudentManagementApp.Models;

namespace StudentManagementApp.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        // ── Backing fields ──────────────────────────────────────────────
        private List<Student> _students;
        private Student _selectedStudent;

        // ── Properties ──────────────────────────────────────────────────
        public List<Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }

        public StudentViewModel()
        {
            LoadSampleData();
            SelectedStudent = Students[0]; // default selection
        }

        // ── Load dummy data (replace with DB or API later) ──────────────
        private void LoadSampleData()
        {
            Students = new List<Student>
            {
                new Student
                {
                    RollNumber  = "3160011",
                    Name        = "Raman Kumar",
                    FatherName  = "Sohan Kumar",
                    MotherName  = "Babita Kumari",
                    DateOfBirth = "01 Jan 2002",
                    School      = "Delhi Public School",
                    Marks = new List<StudentMark>
                    {
                        new() { Subject="Statistics", ObtainedMarks=55, PracticalMarks=22 },
                        new() { Subject="Physics",    ObtainedMarks=61, PracticalMarks=23 },
                        new() { Subject="Chemistry",  ObtainedMarks=45, PracticalMarks=25 },
                        new() { Subject="Biology",    ObtainedMarks=65, PracticalMarks=20 },
                        new() { Subject="Soc. Sci.",  ObtainedMarks=67, PracticalMarks=19 },
                    }
                },
                new Student
                {
                    RollNumber  = "3160012",
                    Name        = "Priya Singh",
                    FatherName  = "Ramesh Singh",
                    MotherName  = "Sunita Singh",
                    DateOfBirth = "15 Mar 2002",
                    School      = "St. Mary's School",
                    Marks = new List<StudentMark>
                    {
                        new() { Subject="Statistics", ObtainedMarks=72, PracticalMarks=25 },
                        new() { Subject="Physics",    ObtainedMarks=68, PracticalMarks=24 },
                        new() { Subject="Chemistry",  ObtainedMarks=75, PracticalMarks=23 },
                        new() { Subject="Biology",    ObtainedMarks=80, PracticalMarks=22 },
                        new() { Subject="Soc. Sci.",  ObtainedMarks=78, PracticalMarks=20 },
                    }
                }
            };
        }
    }
}
