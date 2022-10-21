using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MathematicsOperations
    {
        public int Add(int a, int b)
        {
            int c = a + b;

            return c;
        }

        public int Add(int a, int b, int[] nums)
        {
            int c = a + b;

            for (int i = 0; i < nums.Length; i++)
            {
                c += nums[i];
            }

            return c;
        }
    }
}
