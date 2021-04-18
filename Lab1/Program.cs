using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsCalculate
{
    class Vector
    {
        public double x, y, z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void ShowVector(string vecName)
        {
            Console.WriteLine(vecName + "(" + this.x + ", " + this.y + ", " + this.z + ");");
        }
    };
    class Calculate
    {
        public double vNorm;
        public double vAngle;
        public double vDistance;
        public Calculate()
        {
            vNorm = 0.0;
        }
        public void VectorNorm(Vector V, string vecName)
        {
            // vNorm = Math.Round(Math.Sqrt(Math.Pow(V.x, 2) + Math.Pow(V.y, 2) + Math.Pow(V.z, 2)), 2);
            vNorm = Math.Pow(V.x, 2) + Math.Pow(V.y, 2) + Math.Pow(V.z, 2);
            Console.WriteLine("Vector {4} norm: √({0}^2+{1}^2+{2}^2) = √{3};", V.x, V.y, V.z, vNorm, vecName);
        }
        public void VectorsAngle(Vector V1, Vector V2)
        {
            vAngle = Math.Round((Math.Acos((V1.x*V2.x+V1.y*V2.y+V1.z*V2.z)/Math.Sqrt((V1.x*V1.x+V1.y*V1.y+V1.z*V1.z)*(V2.x * V2.x + V2.y * V2.y + V2.z * V2.z))))*(180/Math.PI), 2);
            Console.WriteLine("Vectors angle: " + vAngle + "°");
        }
        public void VectorsDistance(Vector V1, Vector V2)
        {
            double v1n = Math.Pow(V1.x, 2) + Math.Pow(V1.y, 2) + Math.Pow(V1.z, 2);
            double v2n = Math.Pow(V2.x, 2) + Math.Pow(V2.y, 2) + Math.Pow(V2.z, 2);
            double va = (V1.x * V2.x + V1.y * V2.y + V1.z * V2.z) / Math.Sqrt((V1.x * V1.x + V1.y * V1.y + V1.z * V1.z) * (V2.x * V2.x + V2.y * V2.y + V2.z * V2.z));
            vDistance = v1n + v2n - 2 * Math.Sqrt(v1n)*Math.Sqrt(v2n)*va;
            Console.WriteLine("Vectors distance: √" + Math.Round(vDistance, 2));
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put 1st vector values:");
            int[] vec1Mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Put 2nd vector values:");
            int[] vec2Mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Vector v1 = new Vector(vec1Mas[0], vec1Mas[1], vec1Mas[2]);
            Vector v2 = new Vector(vec2Mas[0], vec2Mas[1], vec2Mas[2]);
            Console.WriteLine();
            v1.ShowVector("V1");
            v2.ShowVector("V2");
            Calculate calculate = new Calculate();
            calculate.VectorNorm(v1, "V1");
            calculate.VectorNorm(v2, "V2");
            calculate.VectorsAngle(v1, v2);
            calculate.VectorsDistance(v1, v2);
            Console.ReadKey();
        }
    }
}
