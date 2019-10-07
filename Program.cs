using System;
using BurgerShack.Controllers;

namespace BurgerShack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MenuController mc = new MenuController();
            System.Console.WriteLine(@"

    _    _   __      __  __               _          
   (_)  / | / /___ _/ /_/ /_  ____ _____ ( )_____    
  / /  /  |/ / __ `/ __/ __ \/ __ `/ __ \|// ___/    
 / /  / /|  / /_/ / /_/ / / / /_/ / / / / (__  )     
/_/  /_/ |_/\__,_/\__/_/ /_/\__,_/_/ /_/ /____/      
          ____                                
         / __ )__  ___________ ____  _____                 
        / __  / / / / ___/ __ `/ _ \/ ___/                 
       / /_/ / /_/ / /  / /_/ /  __/ /                     
      /_____/\__,_/_/   \__, /\___/_/                      
                       /____/   
         _____ __               __      __                 
        / ___// /_  ____ ______/ /__   / /                 
        \__ \/ __ \/ __ `/ ___/ //_/  / /                  
       ___/ / / / / /_/ / /__/ ,<    /_/                   
      /____/_/ /_/\__,_/\___/_/|_|  (_)        

                                                     
Exit with Q.  Otherwise, press any key to continue.
            ");
            bool running = false;
            if (Console.ReadLine().ToLower() == "q")
            {
                running = false;
            }
            else
            {
                running = true;
                Console.Clear();

            }

            while (running)
            {
                running = mc.GetUserInput();
            }
            Environment.Exit(1);
        }
    }
}
