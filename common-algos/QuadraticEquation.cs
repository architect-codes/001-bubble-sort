using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar.codes.common_algos
{
    public class QuadraticEquation
    {
        public static (double? x1, double? x2) Solve(double a, double b, double c)
        {
            // validate A != 0
            // and check if we have solution: 4ac > b*b
            if(a == 0 || b * b < 4 * a * c)
                return (null, null);

            var discriminant = Math.Sqrt(b * b - 4 * a * c);

            double? x1;
            double? x2 = null;

            // find first root
            x1 = (-b - discriminant) / (2 * a);

            // check for second root and calculate it
            if(discriminant != 0)
                x2 = (-b + discriminant) / (2 * a);

            return (x1, x2);
        }
    }
}
