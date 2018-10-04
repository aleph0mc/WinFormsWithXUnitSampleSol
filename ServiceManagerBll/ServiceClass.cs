using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class ServiceClass
    {
        public int SumIntNumbers(int A, int B)
        {
            return A + B;
        }

        public int Add(int A, int B)
        {
            return A + B;
        }

        public int Subtract(int A, int B)
        {
            return B > A ? 0 : A - B;
        }

        public int Multiply(int A, int B)
        {
            return A * B;
        }

        public int Divide(int A, int B)
        {
            return A / B;
        }
    }
}
