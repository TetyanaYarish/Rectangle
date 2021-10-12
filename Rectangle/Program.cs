using System;

namespace Rectangle
{
    class Program
    {
        public string oneColumn;
        public int wwidth;
        int length;
        static void Main(string[] args)
        {
            string oneRow = "_";
            string space = " ";
            int l = 1;
            Program pr = new();
           
            Console.WriteLine("Insert length of rectangle.");
            int width=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Insert width of rectangle.");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < width; i++)
            {
               // space = oneRow;
            //Console.Write(oneRow);
            //} 
            //for (int p = 0; p < length; p++)
            //{
            Console.WriteLine(pr.Column());
               
            }
            for (int i = 1; i < width; i++)
                {
                   
                    Console.Write(oneRow);
                }
        }
        public string Column()
        {

            string oneColumn = "|";
            for (int p =1; p < length; p++)
            {
                Console.WriteLine(oneColumn);

            }
            return oneColumn;

        }
    }
}
