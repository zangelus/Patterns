using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqByExample
{
    public class Main
    {

        public void CalculateEven()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            var result1 = Library.MyWhere(nums, n => n%2==0);
            var result2 = nums.MyWhere(n => n % 2 == 0);

            var a = result1.Intersect(result2).Any();

        }
    }
}
