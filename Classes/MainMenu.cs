using System;
using System.IO;
public class MainMenu
{
    static Contacts Cont = new Contacts();
    static Refund Ref = new Refund();
  
    
        
        //Main Menu
        public static bool DisplayMenu()
        {            

            

            //Menu Prompt
            Console.Clear();
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
                    Console.Clear();
                    Console.WriteLine("Please enter a valid character of 1, 2, or 0\n\nPress any character to return to previous menu.");
                    Console.ReadKey();
                    return true;
            }

    }
}