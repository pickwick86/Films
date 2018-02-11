using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

namespace Business
{
    [DataContract]
    public class Source
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Path { get; set; }

        public bool Exists { get { return Directory.Exists(Path); } }
    }
}
