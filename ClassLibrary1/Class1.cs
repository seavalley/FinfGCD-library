using System;

namespace ClassLibrary1
{
    using System;

    namespace GcdTask
    {
        public static class IntegerExtensions
        {
            public static int FindGcd(int a, int b)
            {
                if (a == 0 && b == 0)
                {
                    throw new ArgumentException($"{nameof(a)} and {nameof(b)} are 0");
                }
                else if (a == int.MinValue || b == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException($"{a} or {b} are int.MinValue");
                }

                a = Math.Abs(a);
                b = Math.Abs(b);

                while (true)
                {
                    if (a == 0)
                    {
                        return b;
                    }
                    else if (b == 0)
                    {
                        return a;
                    }

                    int temp = a % b;
                    if (temp == 0)
                    {
                        return b;
                    }

                    a = b;
                    b = temp;
                }
            }
        }
    }
}
