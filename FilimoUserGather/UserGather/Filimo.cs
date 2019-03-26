using FilimoUserGather.UserGather.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilimoUserGather.UserGather
{
    public class Filimo
    {
        public UserGathred UG { get; private set; }

        public Filimo(UserGathred ug)
        { this.UG = ug; }

        private List<String> GUrls( String Link )
        {
            List<String> Links = new List<string>();
            Links = UserGather.MovieGenerator.GetMovies(Link);

            if (Links == null)
            {
                MessageBox.Show("Error internet connection or other's !");
                return null;
            }

            return Links;
        }

        public void Begin()
        {
            var u = GUrls(UserInputs.GenreLink);

            if (u == null)
            {
                MessageBox.Show("Error internet connection or other's ! please");
            }

            foreach (var url in u)
                Task.Factory.StartNew(() => { GetUsernames(url); }).Wait();
        }

        private void GetUsernames(String link)
        {
            try
            {
                var resp2 = XNetHttpRequest.Get("https://www.filimo.com/m/" + link);

                if (!resp2.Item1)
                    return;

                String cid = FilimoContentParser.Cid(resp2.Item2);
                
                String address = String.Format("https://www.filimo.com/star/comment/list/uid/{0}/perpage/{1}/curoffset/20/commentid/{2}/moretype/forward", link, UserInputs.Count, cid);

                var resp = XNetHttpRequest.Get(address);
                if (!resp.Item1)
                    return;

                var usernames = UserGather.FilimoContentParser.ParseCollection(resp.Item2, UserGather.Statics.UsernamePattern);
                List<String> users = new List<string>();

                foreach (Match username in usernames)
                {
                    String value = username.Groups[1].Value;
                    UG.Call(value);
                }
            }
            catch
            {

            }
        }
    }
}
