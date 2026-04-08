using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth { get; set; }
        public string School { get; set; }
        public List<StudentMark> Marks { get; set; } = new();

        // Computed property
        public int GrandTotal => Marks.Sum(m => m.Total);
        public double Percentage => Marks.Count > 0
            ? Math.Round((double)GrandTotal / (Marks.Count * 100) * 100, 1)
            : 0;
        public string Result => Percentage >= 35 ? "Passed" : "Failed";
    }
}