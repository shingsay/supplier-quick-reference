using System;
using System.IO;
using System.Collections.Generic;
public class Refund
{
    private static string logLocation = "data\\invalidentrylog.txt";

    //REFUND POLICY DICTIONARY
    static Dictionary<string, string> Brands = new Dictionary<string, string>()
    {
        {"1", "Armor Refund Policy\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.\n\nTo go back press 0"},
        {"2", "Tree 360 Refund Policy\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.\n\nTo go back press 0"},
        {"3", "Aero Refund Policy\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.\n\nTo go back press 0"}
    };

    public void Display()
    {
        //Loop the Brand Menu
        bool showBrands = true;
        while (showBrands)
        {
            showBrands = BrandsMenu();
        }

        //BRAND MENU
        static bool BrandsMenu() 
        {
            Console.WriteLine(@"
               ******************************       

                     \\\BRAND MENU\\\
                    Select a brand:
                
                    1) - ARMOR
                    2) - TREE 360
                    3) - AERO
                    0) - Go Back
            
               ******************************");

            string menuInput;
            menuInput = Console.ReadLine();
            switch (menuInput)
            {
                //INPUTS FOR BRANDS MENU TO DISPLAY REFUND POLICY
                //DISPLAY REFUND POLICY FOR ARMOR
                //DISPLAY REFUND POLICY FOR TREE 360
                //DISPLAY REFUND POLICY FOR AERO
                case "1":
                case "2":
                case "3":
                    Console.Clear();
                    Console.WriteLine(Brands[menuInput]);
                    RefPolicyReturn();

                    return false;

                case "0":
                    Console.Clear();
                    MainMenu.DisplayMenu();
                    return false;

                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter a value from 0 - 3\n\nPress any key to go back to the previous screen."); //IF INVALID CHARCTER USED THEN APP QUITS AFTER DISPLAYING THIS - HOW TO KEEP APP OPEN //OTHERWISE IF THEY FOLLOW THE DIRECTIONS THE APP WORKS
                    Console.ReadKey();
                    Console.Clear();
                    return true;

            }




        }
        static void RefPolicyReturn()
        {
            
            bool showMenu = true;
            while (showMenu)

            {

                showMenu = ReturnPolicy();

            }
            static bool ReturnPolicy()
            {
                string menuInput;
                menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    //INPUTS TO RETURN TO BRANDS MENU FROM RETURN POLICY
                    case "0":
                        Console.Clear();
                        Refund Ref = new Refund();
                        Ref.Display();
                        return false;

                    default:
                        File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                        Console.Clear();
                        Console.WriteLine("Invalid character entered.\n\nPlease enter 0 to go back");
                        return true;

                }
            }
        }
        
    }


}