using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    class LineComparison
    {
        public double x1, x2, y1, y2, length;
        public void LineLength()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of a line :");
            Console.WriteLine("Please Enter values of x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine("Length of the line is : " +length);
        }
    }
}
