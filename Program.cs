using System;

namespace fixme
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents;
            int numTeachers;
            double averageGPA;

            string n;
            string cityInWhichTheSchoolResides;
            bool isPublic;

            numStudents = 403;
            cityInWhichTheSchoolResides = "Atlanta, GA";
            numTeachers = 62;
            averageGPA = 2.98;
            string name = "Grady High School";
            isPublic = true;

            Console.WriteLine("School: " + name);
            Console.WriteLine("Teachers: " + numTeachers);

            int var;

            if (numStudents >= 10)
            {
                Console.WriteLine("We have at least 10 students");
            }

            if (numTeachers >= 5)
            {
                Console.WriteLine("We have at least 5 teachers");
            }
            function(averageGPA, name);
            function(numStudents, averageGPA);
        }
        public static double function(double x, double y)
        {
            return x + y;
        }

        public static void function(double averageGPA, string name) => Console.WriteLine($"The average GPA of students at {name} was {averageGPA}.");
    }
}


