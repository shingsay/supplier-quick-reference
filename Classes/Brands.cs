using System;
public class Brands
{
    public void Display()
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