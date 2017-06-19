using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Web.Model
{
    public class Retorno
    {
        public int Error { get; set; }
        public string MsgError { get; set; }

        public object Object { get; set; }


    }
}