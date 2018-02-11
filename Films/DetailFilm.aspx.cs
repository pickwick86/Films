using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Business;

namespace Films
{
    public partial class DetailFilm : System.Web.UI.Page
    {
        private const string KEY = "f477f8ffd4619877e8ed3f0f79bed635";

        private const string JSON_PATH = @"https://api.themoviedb.org/3/search/movie?api_key={0}&query={1}&language=fr";

        private const string IMAGE_PATH = @"https://image.tmdb.org/t/p/w500/{0}";

        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new WebClient() { Encoding = Encoding.UTF8 };

            string title = PersistenceManager.Instance.Films[0].Title;

            string url = string.Format(JSON_PATH, KEY, GetTitleForURL(title));

            var result = client.DownloadString(url);

            Result film;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                var data = (RootObject)serializer.ReadObject(ms);
                film = data.results[0];
            }

            string affiche = string.Format(IMAGE_PATH, film.poster_path);

            _affiche.ImageUrl = affiche;
            _title.Text = film.title;
            _summary.Text = film.overview;
        }

        private string GetTitleForURL(string title)
        {
            return title.Replace(' ', '+');
        }
    }
}