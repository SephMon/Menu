using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    class Program
    {
        private static string[] NAME = {"kevin","conor","david"};
        private static string[] PASS = {"cat","dog","mouse" };
        private static int MAX_LOGINS_ATTEMPTS = 3;
        private Boolean exit;
        static void Main(string[] args)
        {
            Program program = new Program();

            program.welcome();
            program.checkPassword();
        }
        private void welcome() {
            Console.WriteLine("====================");
            Console.WriteLine("*     WELCOME      *");
            Console.WriteLine("*===================");
       }
        private void checkPassword() {
            int nTries = 0;
            Boolean keepGoing = true;

            while (keepGoing) {

                Console.WriteLine("Please enter the correct login information.");
                Console.WriteLine();
                Console.WriteLine("Please enter your UserName: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Please enter your PassWord: ");
                string passWord = Console.ReadLine();

                if (isValidLogin(userName, passWord))
                {
                    accessMessage();
                    runMenu();
                    break;
                }
                else
                {
                    nTries++;
                }
                if(nTries >= MAX_LOGINS_ATTEMPTS)
                {
                   Console.WriteLine("All attempts failed! ");
                    keepGoing = false;
                }

            }
        }
        private Boolean isValidLogin(String userName, String passWord)
        {
            if (userName.Equals(NAME[0], StringComparison.OrdinalIgnoreCase) && passWord.Equals(PASS[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void accessMessage()
        {
            Console.WriteLine("====================");
            Console.WriteLine("*     ACCESS       *");
            Console.WriteLine("*     GIVEN        *");
            Console.WriteLine("====================");
        }
        private void runMenu()
        {
            printMenu();
            while (!exit) {
                optionSelection();
                int choice = getInput();
                menuOption(choice);
            }

        }
        private void printMenu() 
        {
            Console.WriteLine("====================");
            Console.WriteLine("*       MAIN       *");
            Console.WriteLine("*       MENU       *");
            Console.WriteLine("====================");
        }
        private void optionSelection()
        {
            Console.WriteLine("1.) OPTION 1.");
            Console.WriteLine("2.) OPTION 2.");
            Console.WriteLine("3.) OPTION 3.");
            Console.WriteLine("4.) OPTION 4.");
            Console.WriteLine("0.) EXIT.");
        }
        private int getInput()
        {
            int choice = -1;
            while (choice < 0 || choice > 4) {
                try
                {
                    Console.Write("Please make a selection or 0 to exit: ");
                    String str = Console.ReadLine();
                    choice = int.Parse(str);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("INVALID SELECTION,PLEASE SELECT OPTION 1-4 OR 0 TO EXIT: ");  
                }
            }
            return choice;
        }
        private void menuOption(int choice)
        {
            switch (choice) {
                case 1: getOption();
                        break;
                case 2: getOption2();
                        break;
                case 3: getOption3();
                        break;
                case 4: getOption4();
                        break;
                case 0: exit = true;
                        Exit();
                        break;
                default:
                        Console.WriteLine("INVALID SELECTION");
                        break;
              
            }
        }
        private void getOption()
        {
            Console.WriteLine("HEEYY");
        }
        private void getOption2()
        {
            Console.WriteLine("Hiiiiiiii");
        }
        private void getOption3()
        {
            Console.WriteLine("HEllloooo");
        }
        private void getOption4()
        {
            Console.WriteLine("HEEYY HOOOO");
        }
        private void Exit()
        {
            Console.WriteLine("Exiting.......");
        }


    }
}
