using System;
using System.IO;
public class MainMenu
{
    static Contacts Cont = new Contacts();
    static Refund Ref = new Refund();
  
    private static string logLocation = "data\\invalidentrylog.txt";
        
        //Main Menu
        public static void DisplayMenu()
        {   
            
            //Display days left until event
            string x = DateTime.Now.ToShortDateString();
            Console.WriteLine("Today's Date: " + x);

            DateTime dt30 = (DateTime.Now).AddDays(30);
            TimeSpan timeLeft = dt30 - DateTime.Now; 
            Console.WriteLine($"*** ATTENTION {timeLeft.Days} days left until new product launch from brand ARMOR ***");

           
            
            //Intro

            Console.WriteLine(@"
               - - - - - - - - - - - - - -
               | Supplier Quick Reference |
               - - - - - - - - - - - - - -
             ");

            //Main Menu Loop
            
            bool showMenu = true;
             while (showMenu)
            {
            showMenu = MainMenu();
            }

            static bool MainMenu()
            {

            //Menu Prompt
            
            Console.WriteLine(@"
               ******************************       

                     \\\MAIN MENU\\\
                    Select an option:
                
                    1) - Contacts
                    2) - Refund Policy
                    0) - Exit
            
               ******************************");

            var menuInput = Console.ReadLine();

            switch (menuInput)
            {
                case "1":
                    Console.Clear();
                    Cont.Display();
                    return false;

                case "2":
                    Console.Clear();
                    Ref.Display();
                    return false;

                case "0":
                    Console.Clear();
                    Console.WriteLine("Thank you for using Supplier Quick Reference! Goodbye!");
                    return false;

                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter a character between 0 - 2\n\nPress any character to return to the previous menu.");
                    Console.ReadKey();
                    Console.Clear();
                    return true;
            }
            }
    }
}