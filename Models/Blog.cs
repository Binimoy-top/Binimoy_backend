using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test111binimoy.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string BlogsName{ get; set; }

        public string Blogcategory { get; set; }

        public string date { get; set; }
        public string FullBlog { get; set; }
    }

}