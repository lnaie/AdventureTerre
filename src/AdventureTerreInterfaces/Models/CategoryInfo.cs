﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;
using Orleans.Concurrency;

namespace AdventureTerreInterfaces.Models
{
    [Immutable]
    public class CategoryInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<String> Commands { get; set; }
    }
}
