using view.frontend;
using System;

namespace questions.backend
{
    public class Work
    {
        private bool first_launch = true;

        private bool IsItFirstLaunch()
        {// I made it to have at least one private method.
            if (first_launch)
            {
                first_launch = false;
                return true;
            }
            else { return false; }
        }
        public bool DoYouWantToEndWork()
        {
            if (IsItFirstLaunch())
            {
                return true;
            }
            else
            {
                ;
                Console.WriteLine("Is it end Of work? if not, press n,no or nie and enter");
                string continue_question = Console.ReadLine().ToLower(); //posibilty of null reference for now i don't know how to fix this. 
                BonusesOnScreen.HorizontalEmptySpace();
                switch (continue_question)
                {
                    case "no":
                    case "n":
                    case "nie":
                        BonusesOnScreen.HorizontalEmptySpace();
                        Console.WriteLine("Wait 10 seconds");
                        BonusesOnScreen.ClearScreenAfterTenSecond();
                        return true;
                    default:
                        return false;
                }
            }
        }

    }
}