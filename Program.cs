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
                //Check Log Files 
                string path1 = @"data\invalidentrylog.txt";
                if (!File.Exists(path1))
                {
                    using (var log = new StreamWriter(path1, true))
                    {
                        log.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": Log created");
                    }
                }
                
                
                Console.Clear();

                MainMenu.DisplayMenu();  
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
            
        }  
    }
}

