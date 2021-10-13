using System;

namespace Rectangle2
{

    class Program
    {/*
        public int length;
        public double width;
        string space = " ";
        string oneColumn = "|";*/
        static void Main(string[] args)
        {/*
            string oneRow = "_";

            Program pr = new();

            Console.WriteLine("Insert length of rectangle.");
            pr.PlayerChoseWidthOfRectangle();
            Console.WriteLine("Insert width of rectangle.");
            pr.PlayerChoseLendthOfRectangle();
            Console.Write(pr.space);

            for (int i = 0; i < pr.width * 0.505; i++)
            {

                Console.Write(oneRow);
            }
            Console.Write("\n");
            for (int p = 0; p < pr.length; p++)
            {
                Console.Write(pr.oneColumn);
                Console.Write(pr.Space());
                Console.WriteLine(pr.Column());

            }
            Console.Write(pr.Column());
            for (int i = 0; i < pr.width*0.505; i++)
            {

                Console.Write(oneRow);
            }

            Console.Write(pr.oneColumn);

            Console.WriteLine($"\nResult of your rectangle width {pr.width/4} cm and length {pr.length} cm on the screen.\nPress any button.");
            Console.ReadKey();

        }
        public string Column()
        {
            return oneColumn;
        }
        public int PlayerChoseLendthOfRectangle()
        {
            length = Convert.ToInt32(Console.ReadLine().ToUpper());
            return length;
        }
        public double PlayerChoseWidthOfRectangle()
        {
            width = Convert.ToDouble(Console.ReadLine()) *4;
            return width;
        }
        public string Space()
        {
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write(space);
            }
            return space;*/ 
        }
    }
}