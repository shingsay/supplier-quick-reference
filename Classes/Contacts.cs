using System;
using System.IO;

public class Contacts 
{
    private static string logLocation = "data\\invalidentrylog.txt";
    public void Display()
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
                 

                case "2": 
                Console.Clear();
                Tree360Rep();
                return false;

                case "3": 
                Console.Clear();
                AeroRep();
                return false;

                case "0":
                Console.Clear();
                MainMenu.DisplayMenu();
                return false;
                
                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter a value between 0 - 3\n\nPress any key to go back");
                    Console.ReadKey();
                    Console.Clear();
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
                //INPUT TO RETURN TO BRANDS MENU
                case "0": 
                Console.Clear();
                Contacts Cont = new Contacts();
                Cont.Display();
                return false;
                
                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter any key to go back to the previous screen.");
                    Console.ReadKey();
                    Console.Clear();
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
                //INPUT TO RETURN TO BRANDS MENU
                case "0": 
                Console.Clear();
                Contacts Cont = new Contacts();
                Cont.Display();
                return false;
                
                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter any key to go back to the previous screen.");
                    Console.ReadKey();
                    Console.Clear();
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
                //INPUTS TO RETURN TO BRANDS MENU
                case "0": 
                Console.Clear();
                Contacts Cont = new Contacts();
                Cont.Display();
                return false;
                
                default:
                    File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID INPUT: " + menuInput);
                    Console.Clear();
                    Console.WriteLine("Invalid character entered. Please enter any key to go back to the previous screen.");
                    Console.ReadKey();
                    Console.Clear();
                    return true;

            }
            
            }
        }

    }    
}