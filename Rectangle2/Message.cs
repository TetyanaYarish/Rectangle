using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle2
{
    public class Message
    {
        public void Text()
        {

            Console.Title = "Rectangle program";
            string title = @"  ******* YarCoSoft  ******* ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n"+title);
            Console.ResetColor();
        } 
        public void Text2()
        {
            string title = @"  ******* Fantastic effort, Tanya!  ******* ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n"+title);
            Console.ResetColor();
        }
    }
}
