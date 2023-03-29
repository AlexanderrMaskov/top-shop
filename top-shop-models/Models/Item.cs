using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_shop_models.Models;

namespace top_shop_models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        public virtual ItemType ItemType { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<ItemWarehouse> ItemWarehouse { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }

    }
}
