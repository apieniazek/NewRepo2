using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class GryProdGatOc
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string tytul { get; set; }

        [DataMember]
        public string nazwa { get; set; }

        [DataMember]
        public string zalozyciel { get; set; }

        [DataMember]
        public DateTime rok_zalozenia { get; set; }

        [DataMember]
        public string nazwa_gatunku { get; set; }

        [DataMember]
        public DateTime rok_wydania { get; set; }

        [DataMember]
        public string kraj { get; set; }

        [DataMember]
        public int platforma { get; set; }

        [DataMember]
        public int gry_online_pl { get; set; }
        
        [DataMember]
        public int eurogamer_com { get; set; }

        [DataMember]
        public int moja_ocena { get; set; }
    }
}