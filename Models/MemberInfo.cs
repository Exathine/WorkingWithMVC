using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithMVC.Models
{
    public class MemberInfo
    {
        public MemberInfo()
        {
            this.Contact = new ContactInfo();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ContactInfo Contact { get; set; }
    }
}