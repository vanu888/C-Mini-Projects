using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chat_App
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine();
            Console.WriteLine(" Welcome To Chat App");
            Console.WriteLine();
            Console.WriteLine("Hi, I'm a simple chat app ,powered by C#");
            Console.WriteLine("You can start a simple chat with me :) ");
            Console.WriteLine();
            

            while(true)
            {
                Console.Write("> You: ");
                String user_input = Console.ReadLine().ToLower();
                if (user_input == "hi" || user_input =="hello")
                {
                    Console.WriteLine("> Bot:"+" Hi");
                    
                }
               
                else if (user_input == "exit" || user_input== "bye")
                {
                    Console.WriteLine("> Bot:"+" Goodbye! Have a great day!");
                    break;
                    
                }
                else {
                    Console.WriteLine("> Bot:"+" Sorry, I didn't understand that ;(");
                    
                }
            }
            Console.ReadLine();

        }
        
        
    }
}
