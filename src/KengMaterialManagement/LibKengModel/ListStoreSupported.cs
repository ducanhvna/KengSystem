using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibKengModel
{
    [KnownType(typeof(StoreSupported))]
    [DataContract]
    public class ListStoreSupported
    {
        [DataMember]
        public List<StoreSupported> StoreCategories { get; set; }
    }
    [DataContract]
    public class StoreSupported
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }
}
