﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Territories
    {
        public int Id { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
    }
}
