using System;

namespace MentorMateDevCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            var rectangle = new Rectagle();
            Console.Write("Insert N :");
            var N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert M :");
            var M = Convert.ToInt32(Console.ReadLine());
            rectangle.BrickWall(N, M);
        }
    }
}
