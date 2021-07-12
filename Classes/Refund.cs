using System;
public class Refund 
{
    public void Display()
    {
        //Loop the Brand Menu
        bool displayBrands = true;
        while (displayBrands)
        {
            displayBrands = BrandsMenu();
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
        }
    }
}