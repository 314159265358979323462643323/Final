using System;
using System.Collections.Generic;

#nullable disable

namespace _234Schedule_a_Brew.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public int AppUserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
