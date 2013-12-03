using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsingEFMVCwebAPI.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }


        public int ReviewId { get; set; }

        public virtual Review Review { get; set; }
    }
}