using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class testsss<T>
    {
        public int Cal(List<T> ts)
        {
            int res = 0;
            foreach (var item in ts)
            {
                res += Convert.ToInt32(item);
            }
            return res;
        }
        public int IsC(List<T> ts,T t)
        {
            if (ts.Contains(t))
            {
                return ts.IndexOf(t);
            }
            return -1;
        }
    }
}
