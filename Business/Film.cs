using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Business
{
    [DataContract]
    public class Film
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Genre { get; set; }

        [DataMember]
        public string Director { get; set; }

        [DataMember]
        public string Casting { get; set; }

        public TimeSpan Duration
        {
            get
            {
                return TimeSpan.FromMinutes(DurationInMinutes);
            }
        }

        [DataMember]
        public int DurationInMinutes { get; set; }

        [DataMember]
        public double Note { get; set; }
    }
}
