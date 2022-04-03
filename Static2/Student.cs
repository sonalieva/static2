using System;
using System.Collections.Generic;
using System.Text;

namespace Static2
{
    class Student
    {
        public Student(string fullname,string groupno,int age)
        {
            this.FullName = fullname;
            this.GroupNo = groupno;
            this.Age = age;
        }
        
        private string _fullname;
        private string _groupno;
        public int Age;
        public string FullName
        {
            get
            {
                return _fullname;

            }
            set
            {
                if (value.CheckFullname())
                    _fullname = value;
            }
        }
        public string GroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                if (value.CheckGroupNo())
                    _groupno = value;
            }
        }
    }
}
