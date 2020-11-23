using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint_04
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run()
        {
            Console.WriteLine("{0}의 속도로 ", _Speed);
        }
        public virtual void Attack()
        {
            Console.WriteLine();

            if (this is Healer)
            {
                Console.WriteLine("[마법 공격력 - {0}]으로 ", _Attack * _MP);
            }
            else
            {
                Console.WriteLine("[공격력 -{0}]으로 ", _Attack);
            }
        }
    }
    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;

            Console.WriteLine("Barbarian 생성 되었습니다 ");
        }
        public override void Run()
        {
            base.Run();

            Console.WriteLine("Barbarian 달려갑니다 ");
        }
        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Barbarian이 칼로 공격!! ");
        }
    }
    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;

            Console.WriteLine("Giant 생성 되었습니다 ");
        }
        public override void Run()
        {
            base.Run();

            Console.WriteLine("Giant 달려갑니다 ");
        }
        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Giant 공격!! ");
        }
    }
    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;

            Console.WriteLine("Healer 생성 되었습니다 ");
        }
        public override void Run()
        {
            base.Run();

            Console.WriteLine("Healer 날아갑니다 ");
        }
        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Healer 마법 공격!! ");
        }
    }
    class UnitControl
    {
        // enun == 열거형
        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER
        }
        const int MAX = 10;
        Army[] arrArmys;
        int indexCount;

        public UnitControl()
        {
            indexCount = 0;
            arrArmys = new Army[MAX];
        }
        public string Menu()
        {
            Console.WriteLine(" ++ 유닛 관리 시스템 ++ ");
            Console.WriteLine(" (1) 생성  (2) 달리기  (3) 공격  (0) 나가기");

            return Console.ReadLine();
        }
        public void CreateUnitMenu()
        {
            Console.WriteLine(" ++ 유닛 생성 시스템 ++ ");
            Console.WriteLine(" (1) Barbarian  (2) Giant  (3) Healer  (0) 뒤로 가기");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if(indexCount >= MAX)
            {
                Console.WriteLine(" ++ 유닛 생성 불가 ++ ({0} / {1}) ", indexCount, MAX);
                return;
            }

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
            }
            else
                selUnit = UNIT.NONE;

            switch (selUnit)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BARBARIAN:
                    arrArmys[indexCount] = new Barbarian();
                    break;
                case UNIT.GIANT:
                    arrArmys[indexCount] = new Giant();
                    break;
                case UNIT.HEALER:
                    arrArmys[indexCount] = new Healer();
                    break;
                default:
                    break;
            }

            indexCount++;
        }
        public void UnitRunMenu()
        {
            Console.WriteLine(" ======> 유닛 달리기 ");
            Console.WriteLine(" (1) Barbarian  (2) Giant  (3) Healer  (0) All");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);

                UnitRun(selUnit);
            }
            else if (inputStr.Equals("4"))
            {
                UnitRun();
            }
            else
            {
                Console.Clear();
            }
        }
        private void UnitRun()
        {
            for (int i = 0; i < indexCount; i++)
            {
                arrArmys[i].Run();
            }
        }
        private void UnitRun(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.NONE:
                    break;
                case UNIT.BARBARIAN:
                    for(int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Run();
                    }
                    break;
            }
        }
        public void UnitAttackMenu()
        {
            Console.WriteLine(" ======> 유닛 공격 ==> ==> ==> ");
            Console.WriteLine(" (1) Barbarian  (2) Giant  (3) Healer  (0) All");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);

                UnitRun(selUnit);
            }
            else if (inputStr.Equals("4"))
            {
                UnitRun();
            }
            else
            {
                Console.Clear();
            }
        }
        private void UnitAttack()
        {
            for(int i = 0; i < indexCount; i++)
            {
                arrArmys[i].Attack();
            }
        }
        private void unitAttack(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.NONE:
                    break;
                case UNIT.BARBARIAN:
                    for(int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Attack();
                    }
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UnitControl control = new UnitControl();
            string selNumStr;

            bool isLoop = true;

            while (isLoop)
            {
                selNumStr = control.Menu();

                switch (selNumStr)
                {
                    case "1":           // 생성
                        control.CreateUnitMenu();
                        break;
                    case "2":           // 달리기
                        control.UnitRunMenu();
                        break;
                    case "3":           // 공격
                        control.UnitAttackMenu();
                        break;
                    default:
                        isLoop = false;     // 나가기
                        break;
                }
            }
        }
    }
}
