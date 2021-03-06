using System;
using System.Collections.Generic;

#nullable disable

namespace _234Schedule_a_Brew.Models
{
    public partial class SupplierAddress
    {
        public int SupplierId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
