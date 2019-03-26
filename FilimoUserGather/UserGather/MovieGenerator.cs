using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilimoUserGather.UserGather
{
    public static class MovieGenerator
    {
        public static List<String> GetMovies(String link)
        {
            var resp = XNetHttpRequest.Get(link);

            if (resp.Item1)
            {
                List<String> links = new List<string>();
                var col = FilimoContentParser.ParseCollection(resp.Item2, Statics.MoviesPattern);

                foreach (System.Text.RegularExpressions.Match m in col)
                    links.Add(m.Groups[1].Value);

                return links;
            }
            else
                return null;
        }
    }
}
