﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_shop_models
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        [Required][StringLength(100)] public string Name { get; set; }

    }
}
