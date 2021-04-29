using System;
//using System.Linq;

namespace LabAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumGrade = 0;
            double cgpa = 0;
            double cgpaPercentage;
            Console.WriteLine("Welcome, please enter your name");
            string studentName = Console.ReadLine().ToUpper();
            Console.WriteLine("it's good to have you here " + studentName + " calculating your cgpa just got easier");
            int[] grades = new int[5]; // 5 size array
            Console.WriteLine("Please enter your first score");
            int firstScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second score");
            int secondScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your third score");
            int thirdScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your fourth score");
            int fourthScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your fifth score");
            int fifthScore = int.Parse(Console.ReadLine());
            grades[0] = firstScore /10;
            grades[1] = secondScore /10;
            grades[2] = thirdScore /10;
            grades[3] = fourthScore /10;
            grades[4] = fifthScore /10;
            foreach (var grade in grades)
            {
                sumGrade += grade;
                cgpa = sumGrade/(grades.Length);
                
            }
            cgpaPercentage = (cgpa * 9.5);
            Console.WriteLine("Hello " + studentName + " your cgpa is " + cgpa);
            Console.WriteLine(studentName + " your percentage cgpa is " + cgpaPercentage.ToString("0.00") + " %");
        }
    }
}

