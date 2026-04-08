using student_login_app.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using System.Collections.ObjectModel;

public class StudentViewModel
{
    public ObservableCollection<student> Students { get; set; }

    public StudentViewModel()
    {
        Students = new ObservableCollection<student>
        {
            new student { RollNumber="1234", Name="Raman Kumar", Mathematics=77, Physics=84, Chemistry=70, Biology=85, SocialScience=86 },
            new student { RollNumber="1233", Name="sanjay Kumar", Mathematics=77, Physics=84, Chemistry=70, Biology=85, SocialScience=86 }
        };
    }
}
