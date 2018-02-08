using System;
using System.Linq;
            
namespace Apv.AV.Common
{
    public static class CommonExtensions
    {
        public static bool IsIn(this string source, string[] lst)
        {
            return lst.Where(a => a.Trim().ToLower() == source.Trim().ToLower()).Any();
        }
    }
}
