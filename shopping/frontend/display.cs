using Datebase.backend;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace view.frontend
{ 
    public class BonusesOnScreen
    {// just wanted to make display file. it's also helps  to grasp the general idea of methods. simple but clear example
        public static void HorizontalLine()
        { 
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
        }
        public static void HorizontalEmptySpace()
        {
            Console.WriteLine();
        }
        public static void ClearScreenAfterTenSecond()
        {
            Thread.Sleep(10000);
            Console.Clear();
        }




    }


}
