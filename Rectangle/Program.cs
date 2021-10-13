using System;
using Rectangle2;

namespace Rectangle
{
    class Program
    {
        public int width;
        public double length1;
        string space = " ";
        string oneColumn = "|";
        static void Main(string[] args)
        {
            string oneRow = "_";
            Program pr = new();
            Message message = new();
            message.Text();
            Console.WriteLine("Insert length of rectangle.");
            pr.PlayerChoseWidthOfRectangle();
            Console.WriteLine("Insert width of rectangle.");
            pr.PlayerChoseLendthOfRectangle();
            Console.Write(pr.space);

            for (int i = 0; i < pr.length1 * 0.505; i++)
            {

                Console.Write(oneRow);
            }
            Console.Write("\n");
            for (int p = 0; p < pr.width; p++)
            {
                Console.Write(pr.oneColumn);
                Console.Write(pr.Space());
                Console.WriteLine(pr.Column());

            }
            Console.Write(pr.Column());
            for (int i = 0; i < pr.length1 * 0.505; i++)
            {

                Console.Write(oneRow);
            }

            Console.Write(pr.oneColumn);
            
            Console.WriteLine($"\n\n\nResult of your rectangle on the screen is: width {pr.width}cm and length {pr.length1 / 4}cm.\nPress any button.");
            Console.ReadKey();
            message.Text2();
            Console.ReadKey();
        }
        public string Column()
        {
            return oneColumn;
        }
        public int PlayerChoseLendthOfRectangle()
        {
            width = Convert.ToInt32(Console.ReadLine().ToUpper());
            if (width==0)
            {
               oneColumn = "";
            }
            return width;
        }
        public double PlayerChoseWidthOfRectangle()
        {
            length1 = Convert.ToDouble(Console.ReadLine()) * 4;
            return length1;
        }
        public string Space()
        {
            for (int i = 0; i < length1 / 2; i++)
            {
                Console.Write(space);
            }
            return space;
        }
    }
}
