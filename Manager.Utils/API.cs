using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Utils
{
    public static class API
    {

        public const uint MAX_PATH = 255;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        public static extern uint GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
            string lpszLongPath,
            [MarshalAs(UnmanagedType.LPTStr)]
            StringBuilder lpszShortPath,
            uint cchButter);

    }
}
