using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Human
    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        protected internal int BornYear { get; set; }
        private protected string BornCity { get; set; }
    }
}
