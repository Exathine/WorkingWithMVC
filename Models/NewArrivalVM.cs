using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithMVC.Models
{
    public class NewArrivalVM
    {
        public MemberInfo Member { get; set; }
        public List<GameInfo> Games { get; set; }
        public NewArrivalVM()
        {
            this.Member = new MemberInfo();
            this.Games = new List<GameInfo>();
        }
    }
}