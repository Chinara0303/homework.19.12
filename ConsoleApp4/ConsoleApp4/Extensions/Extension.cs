using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Extensions
{
    public static class Extension
   {
        public static bool Finder(this string sentence,string k)
        {
           bool result = false;
            int j = 0;
            int i = 0;
            int kcount = 0;
            for ( i=0; i < sentence.Length; i++)
            {
                if (sentence[i] == k[j])
                {
                    j++;
                    kcount++;
                }
                else
                {
                    j = 0;
                    kcount = 0;
                }
                if (kcount == k.Length)
                {
                    result = true;
                    break;
                }
            }
            return result;
       }
   }
}
