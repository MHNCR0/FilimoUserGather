using System;
using System.Text.RegularExpressions;

namespace FilimoUserGather.UserGather
{
    public static class FilimoContentParser
    {
        public static MatchCollection ParseCollection(String s, String pattern) { return Regex.Matches(s, pattern); }

        public static String Cid(String r) { return Regex.Match(r, Statics.CidPattern).Groups[1].Value.Replace("'", "").Replace("(", "").Replace(")", ""); }

        
    }
}
