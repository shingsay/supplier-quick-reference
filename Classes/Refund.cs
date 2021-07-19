using System;
using System.Collections.Generic;
public class Refund
{
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
        static bool BrandsMenu() //CAN I CALL THIS FROM CONTACTS.CS OR DO I HAVE TO RE-WRITE IT HERE? 
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
                    Console.WriteLine("Please enter a value from 0 - 3");
                    return true;

            }




        }
        
    }


}