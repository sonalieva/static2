using System;

namespace Static2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            bool check = true;
            while (fullname.CheckFullname() == false)
            {
                if (check)
                {
                    Console.WriteLine("Zehmet olmasa FullNamenizi daxil edin");
                    check = false;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa FullName nizi duzgun daxil edin");
                }
                fullname = Console.ReadLine();

            }
            string groupno = "";
            bool check2 = true;
            while (groupno.CheckGroupNo() == false)
            {
                if (check)
                {
                    Console.WriteLine("Zehmet olmasa GroupNo nu daxil edin");
                    check2 = false;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa  GroupNo nu duzgun daxil edin");
                }
                groupno = Console.ReadLine();

            }
            Console.WriteLine("Zehmet olmasa yasinizi daxil edin");
            int age = Convert.ToInt32(Console.ReadLine());


            Student student1 = new Student(fullname, groupno, age);
            student1.FullName = fullname;
            student1.Age = age;
            student1.GroupNo = groupno;
            Console.WriteLine(student1.FullName);
            Console.WriteLine(student1.GroupNo);
            Console.WriteLine(student1.Age);

        }
    }
}