using MVVM_Sample.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVM_Sample.MVVM.View_Model
{
    public class student_view_model
    {
        public ObservableCollection <student_model> register student{ get; set; }

        public student_view_model()
        {
            register student = new ObservableCollection<student_model>()
            {
            new student_model { Name = "john", Age = 20 }
             new student_model { Name = "mike", Age = 19 }
             new student_model { Name = "stark", Age = 24 }
             };
        }

    }
}
