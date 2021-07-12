using System;

public class Contacts 
{
    public void Display() //CAN I JUST CALL Brands();??
    {
        //Loop the Brand Menu
        bool displayBrands = true;
        while (displayBrands)
        {
            displayBrands = BrandsMenu();
        }

        //The Menu
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

        }
    }    
}