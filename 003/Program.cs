using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studenNo = { 1, 2, 3, 4, 5, };
            String[] studentName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] programScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };

            while(true)
            {
                Console.WriteLine("輸入座號(1 - 5)");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, intputstudentNo);

            }
        }

    }
}
