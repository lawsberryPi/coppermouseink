using System;
using System.Collections.Generic;

namespace CopperMouseNetVue.Model
{
    public partial class Table
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string UserCart { get; set; }
        public byte[] UserImage { get; set; }
    }
}
