using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp.Models
{
    public class StudentMark
    {
        public string Subject { get; set; }
        public int ObtainedMarks { get; set; }
        public int PracticalMarks { get; set; }
        public int Total => ObtainedMarks + PracticalMarks;

        public string Grade => Total switch
        {
            >= 90 => "A1",
            >= 80 => "A2",
            >= 70 => "B1",
            >= 60 => "B2",
            >= 50 => "C1",
            >= 40 => "C2",
            >= 35 => "D",
            _ => "F"
        };
    }
}