using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TmdbMovie.Models
{
    [DataContract]
    public class Movie
    {      
        
        [DataMember]
        public string title { get; set; }
        
        [DataMember]
        public string overview { get; set; }

        private string _PosterPath;
        [DataMember]
        public string poster_path
        {
            get
            {
                return string.Concat(Settings.UrlPosterPath, _PosterPath);
            }

            set { _PosterPath = value; }
        }

        [DataMember]
        public DateTime release_date { get; set; }
        

    }
}
