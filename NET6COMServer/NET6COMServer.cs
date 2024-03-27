using System;
using System.Runtime.InteropServices;

namespace NET6COMServer
{

    [ComVisible(true)]
    [Guid("2231CB75-2BD5-40A6-907F-75F2116AF699")]
    public class NET6COMServer
    {
        public string str_add(string a, string b)
        {
            return a + b;
        }

        public int int_add(int a, int b)
        {
            return a + b;
        }
    }
}
