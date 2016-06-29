﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public bool IsAvailable { get; set; }
        public virtual IEnumerable<BaseProduct> Products { get; set; }
    }
}