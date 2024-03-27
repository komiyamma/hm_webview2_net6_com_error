using System;
using System.Runtime.InteropServices;

namespace NET6COMServer
{
    [ComVisible(true)]
    [Guid("2231CB75-2BD5-40A6-907F-75F2116AF699")]
    public class NET6COMServer
    {
        public int this[int x, int y]
        {
            get
            {
                return 3;
            }
            set
            {

            }
        }
        public string str_add(string a, string b)
        {
            return a + b;
        }

        public int int_add(int a, int b)
        {
            return a + b;
        }

        private int _aaa = 3;
        public int aaa
        {
            get
            {
                return _aaa;
            }

            set
            {
                _aaa = value + 1;
            }

        }

        private int[] _bbb = [0,1,2];
        public int[] bbb
        {
            get
            {
                return _bbb;
            }

            set
            {
                _bbb = value;
            }

        }

    }
}
