using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
     public static class Vars
    {
        public static List<string> Files = new List<string>();

        public static int numberOfSong = 0;

        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }

        internal static object GetFileName(string[] fileNames)
        {
            throw new NotImplementedException();
        }
    }
}
