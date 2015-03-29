using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Butterfly.Service.Rest
{
    [DataContract]
    public class RestHandler
    {
        [DataMember]
        public RestHandlerEnum Handler { get; set; }

        [DataMember]
        public string Name { get; set; }        
    }

    public enum RestHandlerEnum
    {
        Salary        
    }
}
