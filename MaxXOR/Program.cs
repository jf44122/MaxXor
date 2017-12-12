using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int maxXor(int l, int r)
    {
        int result = 0;
        for(int ccc=l; ccc<=r; ccc++)
        {
            for (int ddd = ccc + 1; ddd <= r; ddd++)
            {
                result = result < (ccc ^ ddd) ? ccc ^ ddd : result;
            }
        }

        return result;
    }
    static void Main(String[] args)
    {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());

        int _r;
        _r = Convert.ToInt32(Console.ReadLine());

        res = maxXor(_l, _r);
        Console.WriteLine(res);

    }
}
