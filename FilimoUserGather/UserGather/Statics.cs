using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilimoUserGather.UserGather
{
    public static class Statics
    {
        public static String CidPattern = "onmouseout=\"commentDeselect(.*?)\">";
        public static String UsernamePattern = "<span class=\"username\" title=\"(.*?)\">";
        public static String MoviesPattern = "<a href=\"https://www.filimo.com/m/(.*?)\" class=\"thumbnail-movie\" data-dir=\"column\">";
    }
}
