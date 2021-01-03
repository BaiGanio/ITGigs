using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var arrFirst = new double[,] 
            { 
                { 1, 3 }, 
                { 5, 7 } 
            };
            var arrFirst = new double[,] 
            { 
                { 4, 2 }, 
                { 1, 5 } 
            };
            var arrCommon = Calculate(arrFirst, arrFirst);

            for (int i = 0; i < arrCommon.GetLength(0); i++)
            {
                for (int j = 0; j < r.GetLength(1); j++)
                {
                    Console.Write(r[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] Calculate(double[,] multiDimensionArray1, double[,] multiDimensionArray2)
        {
            if (_.GetLength(1) != __.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var _______ = _.GetLength(1);
            var ___ = new double[_.GetLength(0), __.GetLength(1)];
            for (int ____ = 0; ____ < ___.GetLength(0); ____++)
                for (int _____ = 0; _____ < ___.GetLength(1); _____++)
                    for (int ______ = 0; ______ < _______; ______++)
                        ___[____, _____] += _[____, ______] * __[______, _____];
            return ___;
        }
    }
}