namespace LineComparison_p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            

            double length_1st_line = line.LengthOfLine(20, 30, 40, 50); 
            double length_2nd_line = line.LengthOfLine(30, 40, 30, 50);


            if (length_1st_line > length_2nd_line)
            {
                Console.WriteLine("1st Line: {0} is greater then 2nd line: {1}", length_1st_line, length_2nd_line);
            }
            else if (length_1st_line < length_2nd_line)
            {
                Console.WriteLine("2nd Line: {1} is greater then 1st line: {0}", length_1st_line, length_2nd_line);
            }
            else
            {
                Console.WriteLine("1st Line: {0} & 2nd line: {1} is equal", length_1st_line, length_2nd_line);
            }

        }
    }
}