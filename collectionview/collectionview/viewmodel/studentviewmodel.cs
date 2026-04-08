using collectionview.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace collectionview.viewmodel
{
    public class studentviewmodel
    {
        public ObservableCollection<student> students { get; set; }
        public studentviewmodel()
        {
            students = new ObservableCollection<student>
            {
                new student { Name = "sanjay", Age = 18 },
                new student { Name = "bala", Age = 24 }
            };
        }
    };
}
