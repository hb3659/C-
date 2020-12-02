using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * 093_Cehck를 입력 제한 없이 처리
 * - 저장했던 자료에서 참고하고 싶은 학생번호로 정보 보여주기
 * - ContainsKey() 함수 참고: Hashtable에 저장된 키 값이 있는지 체크
 * - Hashtable 사용
 * 
 * static int CheckID(int id, hashtable hashTable){
 *      if(hashTable.ContainsKey(id){
 *           return id;
 *      }
 *      ...
 */
namespace _101_Check
{
    class Student
    {
        int id;
        int kor;
        int eng;
        int math;
        public int ID { get { return id; } }
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
        public int Select()
        {
            int sel;
            Console.Write("(1) Input_id   (0) Exit : ");
            sel = int.Parse(Console.ReadLine());
            return sel;
        }
        public void inputID()
        {
            Console.Write("Please enter student id: ");
            id = int.Parse(Console.ReadLine());
        }
        public void inputKor()
        {
            Console.Write("Please enter korean grade: ");
            kor = int.Parse(Console.ReadLine());
        }
        public void inputMath()
        {
            Console.Write("Please enter Math grade: ");
            math = int.Parse(Console.ReadLine());
        }
        public void inputEng()
        {
            Console.Write("Please enter english grade: ");
            eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {
            Console.WriteLine("Student's ID: {0}", this.id);
        }
        public int getTotal()
        {
            return kor + eng + math;
        }
    }
    class Program
    {
        static void PrintID(Hashtable hashTable)
        {
            foreach(int key in hashTable.Keys)
            {
                Student castData = (Student)hashTable[key];
                castData.PrintID();
            }
        }
        static int checkID(int id, Hashtable hashTable)
        {
            if (hashTable.ContainsKey(id))
                return id;

            return -1;
        }
        static void Main(string[] args)
        {
            int inputSel = 0;
            int selID = -1;

            Hashtable hash = new Hashtable();

            while (true)
            {
                PrintID(hash);
                Console.Write("== Entering grade == (0)Exit: ");
                if (Console.ReadLine() == "0")
                    break;

                Student stu = new Student();
                stu.inputID();
                stu.inputKor();
                stu.inputEng();
                stu.inputMath();

                hash.Add(stu.ID, stu);
                // key == 입력한 id
                // value == stu 자체
                Console.WriteLine();
            }

            Console.Clear();

            while (true)
            {
                PrintID(hash);
                Console.Write("Please enter Student ID (if you want to exit enter 0): ");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = checkID(inputSel, hash);

                if (selID >= 0)
                {
                    Student selStu = (Student)hash[selID];
                    Console.WriteLine("Korean grade: {0}", selStu.KOR);
                    Console.WriteLine("English grade: {0}", selStu.ENG);
                    Console.WriteLine("Math grade: {0}", selStu.MATH);

                    int total = selStu.getTotal();

                    Console.WriteLine("Total: {0}", total);
                    Console.WriteLine("Average: {0}", total / 3);
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("\nThere is no ID\n");
            }
        }
    }
}
