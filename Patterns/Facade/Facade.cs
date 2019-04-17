using System;

namespace Facade
{
    public class FacadeMain
    {
        public static string msg1 = "Method1";
        public static string msg2 = "Method2";
        public static string msg3 = "Method3";
        public static string msg4 = "Method4";

        SubSystem1 _ss1;
        SubSystem2 _ss2;
        SubSystem3 _ss3;
        SubSystem4 _ss4;

        public FacadeMain()
        {
            _ss1 = new SubSystem1();
            _ss2 = new SubSystem2();
            _ss3 = new SubSystem3();
            _ss4 = new SubSystem4();
        }

        public string MethodA()
        {
            Console.WriteLine("executing method 1,2,3");
            return _ss1.Method1() + _ss2.Method2() + _ss3.Method3();
        }

        public string MethodB()
        {
            Console.WriteLine("executing method 3,4");
            return _ss3.Method3() + _ss4.Method4();
        }
    }
}
