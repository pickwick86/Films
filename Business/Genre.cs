using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Business
{
    [DataContract]
    public class Genre
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }
}
