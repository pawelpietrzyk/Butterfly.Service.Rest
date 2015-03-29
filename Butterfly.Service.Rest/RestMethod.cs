using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Butterfly.Service.Rest
{
    [DataContract]
    public class RestMethod
    {
        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public object Param { get; set; }
    }
}
