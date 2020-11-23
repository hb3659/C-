using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _093_Check
{
    /*class Student
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }        // readonly 와 같다
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }
        public Student()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }
        public void InputID()
        {
            Console.Write("학생 아이디를 입력하세요: ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요: ");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요: ");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요: ");
            this.eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {
            Console.WriteLine("학생 ID: {0}", this.id);
        }
        public int GetTotal()
        {
            return kor + eng + math;
        }
    }*/

    class Student
    {
        int id;
        int kor;
        int eng;
        int math;

        public int ID { get { return id; } set { } }
        public int KOR { get { return kor; } set { } }
        public int ENG { get { return eng; } set { } }
        public int MATH { get { return math; } set { } }

        public Student()
        {
            this.id = 0;
            this.kor = 0;
            this.eng = 0;
            this.math = 0;
        }
        public void InputID()
        {
            Console.Write("ID를 입력하세요: ");
            id = int.Parse(Console.ReadLine());
        }
        public void InputKOR()
        {
            Console.Write("국어 점수를 입력하세요: ");
            kor = int.Parse(Console.ReadLine());
        }
        public void InputENG()
        {
            Console.Write("영어 점수를 입력하세요: ");
            eng = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요: ");
            math = int.Parse(Console.ReadLine()); 
        }
        public void PrintID()
        {
            Console.WriteLine("학생 ID: {0}", this.id);
        }
        public int Total()
        {
            return kor + eng + math;
        }
    }

    class Program
    {
        /*static void PrintID(Student[] arrStudent)
        {
            foreach (Student data in arrStudent)
                data.PrintID();
        }
        static int CheckID(int id, Student[] arrStudent)
        {
            for(int i = 0; i < arrStudent.Length; i++)
            {
                if (id == arrStudent[i].ID)
                    return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            const int MAX = 3;
            int inputSel = 0;
            int selID = -1;

            Student[] arrStudent = new Student[MAX];

            for(int i = 0; i < MAX; i++)
            {
                arrStudent[i] = new Student();      // 각 배열을 인스턴스화
                arrStudent[i].InputID();
                arrStudent[i].InputKor();
                arrStudent[i].InputMath();
                arrStudent[i].InputEng();

                Console.WriteLine();
            }
            Console.Clear();

            while (true)
            {
                PrintID(arrStudent);
                Console.Write("학생 아이디를 입력하세요: ");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = CheckID(inputSel, arrStudent);

                if (selID >= 0)
                {
                    Console.WriteLine("국어 점수: {0}", arrStudent[selID].KOR);
                    Console.WriteLine("수학 점수: {0}", arrStudent[selID].MATH);
                    Console.WriteLine("영어 점수: {0}", arrStudent[selID].ENG);

                    int total = arrStudent[selID].GetTotal();

                    Console.WriteLine("총점: {0}", total);
                    Console.WriteLine("평균: {0}", total / (float)MAX);

                    Console.WriteLine();
                }
                else
                    Console.WriteLine("학생 아이디가 없습니다");
            }
        }*/

        static void Print(Student[] stu)
        {
            foreach(Student data in stu)
            {
                data.PrintID();
            }
        }
        static int CheckID(int id, Student[] arrStudent)
        {
            for (int i = 0; i < arrStudent.Length; i++)
            {
                if (id == arrStudent[i].ID)
                    return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            const int MAX = 3;
            int inputSel = 1;
            int selID = -1;

            Student[] stu = new Student[MAX];

            for(int i = 0; i < MAX; i++)
            {
                stu[i] = new Student();
                stu[i].InputID();
                stu[i].InputKOR();
                stu[i].InputENG();
                stu[i].InputMath();

                Console.WriteLine();
            }

            Console.Clear();

            while (true)
            {
                Print(stu);

                Console.Write("학생 아이디를 입력하세요: ");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = CheckID(inputSel, stu);

                if (selID >= 0)
                {
                    for (int i = 0; i < MAX; i++)
                    {
                        Console.WriteLine("국어 점수: {0}", stu[i].KOR);
                        Console.WriteLine("수학 점수: {0}", stu[i].MATH);
                        Console.WriteLine("영어 점수: {0}", stu[i].ENG);
                        Console.WriteLine("총점: {0}", stu[i].Total());
                        Console.WriteLine("평균: {0}", stu[i].Total() / MAX);

                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("아이디가 없습니다.");
            }
        }
    }
}
