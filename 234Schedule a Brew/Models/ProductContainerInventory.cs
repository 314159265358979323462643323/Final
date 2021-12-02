﻿using System;
using System.Collections.Generic;

#nullable disable

namespace _234Schedule_a_Brew.Models
{
    public partial class ProductContainerInventory
    {
        public int ContainerSizeId { get; set; }
        public int QuantityDirty { get; set; }
        public int QuantityClean { get; set; }

        public virtual ProductContainerSize ContainerSize { get; set; }
    }
}
