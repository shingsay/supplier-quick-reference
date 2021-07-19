using System;

public class Contacts 
{
    public void Display() //CAN I JUST CALL Brands();??
    {
        //Loop the Brand Menu
        bool showBrands = true;
        while (showBrands)
        {
            showBrands = BrandsMenu();
        }

        //Brand Menu
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
                //INPUTS FOR BRANDS MENU TO DISPLAY SALES REP FOR PARTICULAR BRAND
                case "1": 
                Console.Clear();
                ArmorRep();
                return false;
                 //DISPLAY SALES REP FROM ARMOR

                case "2": 
                Console.Clear();
                Tree360Rep();
                return false;//DISPLAY SALES REP FROM TREE 360

                case "3": 
                Console.Clear();
                AeroRep();
                return false;//DISPLAY SALES REP FROM AERO

                case "0":
                Console.Clear();
                MainMenu.DisplayMenu();
                return false;
                
                default:
                    Console.WriteLine("Please enter a value from 0 - 3");
                    return true;

            }

            
        }
        // DISPLAY ARMOR REP
        static void ArmorRep()
        {
            //loop contact list
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ArmorRep();
            }

            //Contacts Menu - HAVE THE CONTACT FOR SELECTED SUPPLIER DISPLAY ON APP
            static bool ArmorRep()
            {
                Console.WriteLine(@"
                ******************************       

                     \\\ARMOR\\\
                    Sale Representative:
                
                    BEN SMITH
                    PHONE: (888) 888-8888
                    EMAIL: bsmith@armor.com

                    0) - Go back

               ******************************");

               

               string menuInput;
            menuInput = Console.ReadLine();
            switch (menuInput)
            {
                //INPUTS FOR BRANDS MENU TO DISPLAY SALES REP FOR PARTICULAR BRAND
                case "0": 
                Console.Clear();
                BrandsMenu();
                return false;
                
                default:
                    Console.WriteLine("Please enter 0 to go back");
                    return true;

            }
            
            }
        }
            // DISPLAY TREE 360 REP
        static void Tree360Rep()
        {
            //loop contact list
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Tree360Rep();
            }

            //Contacts Menu - HAVE THE CONTACT FOR SELECTED SUPPLIER DISPLAY ON APP
            static bool Tree360Rep()
            {
                Console.WriteLine(@"
                ******************************       

                     \\\TREE360\\\
                    Sale Representative:
                
                    JENNY LAND
                    PHONE: (888) 888-8888
                    EMAIL: jland@tree360.com

                    0) - Go back

               ******************************");

               

               string menuInput;
            menuInput = Console.ReadLine();
            switch (menuInput)
            {
                //INPUTS FOR BRANDS MENU TO DISPLAY SALES REP FOR PARTICULAR BRAND
                case "0": 
                Console.Clear();
                BrandsMenu();
                return false;
                
                default:
                    Console.WriteLine("Please enter 0 to go back");
                    return true;

            }
            
            }
        }
        //DISPLAY AERO REP
        static void AeroRep()
        {
            //loop contact list
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = AeroRep();
            }

            //Contacts Menu - HAVE THE CONTACT FOR SELECTED SUPPLIER DISPLAY ON APP
            static bool AeroRep()
            {
                Console.WriteLine(@"
                ******************************       

                     \\\AERO\\\
                    Sale Representative:
                
                    BOB TELL
                    PHONE: (888) 888-8888
                    EMAIL: btell@aero.com

                    0) - Go back

               ******************************");

               

               string menuInput;
            menuInput = Console.ReadLine();
            switch (menuInput)
            {
                //INPUTS FOR BRANDS MENU TO DISPLAY SALES REP FOR PARTICULAR BRAND
                case "0": 
                Console.Clear();
                BrandsMenu();
                return false;
                
                default:
                    Console.WriteLine("Please enter 0 to go back");
                    return true;

            }
            
            }
        }

    }    
}