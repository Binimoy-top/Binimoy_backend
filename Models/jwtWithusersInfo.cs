using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test111binimoy.Models
{
    public class jwtWithusersInfo
    {
        public string token { get; set; }
        public virtual Users Users { get; set; }

    }
}