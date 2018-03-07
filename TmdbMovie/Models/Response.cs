using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TmdbMovie.Models
{
    [DataContract]
    public class Response<T>
    {
        [DataMember]
        public IReadOnlyList<T> results { get; private set; }

        [DataMember]
        public int page { get; private set; }

        [DataMember]
        public int total_pages { get; private set; }

        [DataMember]
        public int total_results { get; private set; }
    }

}
