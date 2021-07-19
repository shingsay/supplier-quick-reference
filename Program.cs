using System;
using System.IO;

namespace supplier_quick_reference
{
    public class Program
    {
        
        static MainMenu MainMenu = new MainMenu();
        static void Main(string[] args)
        {
            try 
            {                
                //check log files 
                string path1 = @"data\errorlog.txt";
                if (!File.Exists(path1))
                {
                    using (var log = new StreamWriter(path1, true))
                    {
                        log.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": Log created");
                    }
                }
                
                //Menu Loop
                bool showMenu = true;
                while (showMenu)
                {
                showMenu = MainMenu.DisplayMenu();
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
            
        }  
    }
}

