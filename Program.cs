namespace day16homework
{
    /*
    class StaticTest
    {
        static int _staticNum;
        int _staticNum2;
        public void IncreaseStaticNum()
        {
            _staticNum++;
        }
        public void PrintStaticNum()
        {
            Console.WriteLine(_staticNum);
        }

       static public int staticnum //프로퍼티로 접근가능,static형도 사용 가능
        {
            get {  return _staticNum; }
            set { _staticNum = value; }
        }
        /*
        static public int staticnum2// static프로퍼티로 일반정수형 접근 안됨
        {
           
        }


    }*/
    internal class Program
    {




        static void Main(string[] args)
        {
            /*
            StaticTest test1 = new StaticTest();
            StaticTest test2 = new StaticTest();
            StaticTest test3 = new StaticTest();

            test1.PrintStaticNum();
            test2.PrintStaticNum();
            test3.PrintStaticNum();

            test1.IncreaseStaticNum();
            test1.PrintStaticNum();
            test2.PrintStaticNum();
            test3.PrintStaticNum();
           // StaticTest._staticNum = 5;//error없음
            //test2.PrintStaticNum();
            StaticTest.staticnum = 2;
            test1.PrintStaticNum();
            */
            /*
            int[] ints = {5,6,3,1,2};
            Console.WriteLine(MyHelper.FindMinimum(ints));
            */
            Achievement achievement1 = new Achievement("초급 도전자","점수 100점 달성",100);
            Achievement achievement2 = new Achievement("중급 도전자", "점수 500점 달성", 500);
            Achievement achievement3 = new Achievement("고급 도전자", "점수 1000점 달성", 1000);
            achievement1.AddProgress(100);
            achievement2.AddProgress(600);
            achievement3.AddProgress(800);

            achievement1.DisplayInfo();
            achievement2.DisplayInfo();
            achievement3.DisplayInfo();
            Achievement.DisplaySummary();



        }
    }
}
