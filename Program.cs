namespace LineComparison_p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            

            double length_1st_line = line.LengthOfLine(20, 30, 40, 50); 
            double length_2nd_line = line.LengthOfLine(30, 40, 30, 50);


            if (length_1st_line == length_2nd_line)
            {
                Console.WriteLine("1st Line: {0} and 2nd line: {1} is equal in length ", length_1st_line, length_2nd_line);
            }
            else
            {
                Console.WriteLine("1st Line: {0} and 2nd line: {1} is not equal in length ", length_1st_line, length_2nd_line);
            }

        }
    }
}