using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Butterfly.Service.Rest
{
    public abstract class RestDispatcher
    {        
        public void DispatchRequest(HttpContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "GET":
                    this.GET(context);
                    break;
                case "POST":
                    this.POST(context);
                    break;
                default: break;
            }
        }
        
        public static RestMethod DecodeRestMethod(HttpContext context)
        {
            RestMethod method = Serializer.Deserialize(context.Request.InputStream, typeof(RestMethod)) as RestMethod;
            
            return method;
        }
        public abstract void DispatchRestMethod(RestMethod method);
        public abstract void GET(HttpContext context);
        public abstract void POST(HttpContext context);
    }
}
