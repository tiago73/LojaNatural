using System;
using System.Collections.Generic;
using System.Text;

namespace LojaNatural.Shered.identity
{
    public abstract class Identity
    {
        public Identity()
        {
            ID = new Guid();
        }
        public Guid ID { get; set; }
    }
}
