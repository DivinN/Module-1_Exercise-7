using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_7_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double cube_A = Convert.ToDouble(Console.ReadLine());

            double cubeVolume = 0;
            double cubeSurfaceArea = 0;
            GetVolumeAndSurfaceAreaOfCube(cube_A, ref cubeVolume, ref cubeSurfaceArea);

            Console.WriteLine("Объем куба равен: {0}, а его площадь: {1}.", cubeVolume, cubeSurfaceArea);
            Console.ReadKey();
        }

        static void GetVolumeAndSurfaceAreaOfCube(double ribLength, ref double volume, ref double surfaceArea)
        {
            volume = ribLength * ribLength * ribLength;
            surfaceArea = ribLength * ribLength * 6;
        }
    }
}
