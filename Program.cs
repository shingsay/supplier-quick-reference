using System;

namespace supplier_quick_reference
{
    class Program
    {
        static Contacts Cont = new Contacts();
        static Refund Ref = new Refund();
        static Brands Brands = new Brands();
        static void Main(string[] args)
        {
            //Menu Loop
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }  
        }
            
            //Main Menu
        private static bool MainMenu()
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


            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Cont.Display();
                    return true;

                case "2":
                    Console.Clear();
                    Ref.Display();
                    return true;

                case "0":
                    Console.Clear();
                    Console.WriteLine("Thank you for using Supplier Quick Reference! Goodbye!");
                    return false;

                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a valid character of 1, 2, or 0");
                    Console.ReadKey();
                    return true;
            }

            // bool mainInput; //SHOULD THIS BE A STRING??? INT??
            // mainInput = Console.ReadLine();
            
            // switch (mainInput)
            // {
            //     //DISPLAY CONTACTS
            //     case "1":
            //         Console.Clear();
            //         Cont.Display();
            //         return true;
                    
            //         //DISPLAY REFUND POLICY MENU
            //         else if (mainInput = 2)
            //             Console.Clear();
            //             Ref.Display();
            //             return true;
                    
            //         //EXIT
            //         else (menuInput = 0)
            //             Console.Clear();
            //             Console.WriteLine("Thank you for using Supplier Quick Reference! Goodbye!");
            //             return false;
            // }
        }
    }
}
