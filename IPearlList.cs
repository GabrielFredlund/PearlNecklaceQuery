﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearl
{
    public interface IPearlList
    {
        public Guid ID { get; set; }
        public int Count();
        public int totalPrice { get;}
        public void Sort();
    }
}
