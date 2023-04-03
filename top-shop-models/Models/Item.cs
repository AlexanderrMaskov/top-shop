using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_shop_models;

namespace top_shop_models
{
    public class Item
    {
        public Guid Id { get; set; }
        [Required][StringLength(30)] public string Name { get; set; }
        [Required][StringLength(1000)] public string Description { get; set; }
        public double Price { get; set; }


        [Required] public virtual ItemType ItemType { get; set; }
        [Required] public virtual Provider Provider { get; set; }

        public virtual ICollection<ItemWarehouse> ItemWarehouse { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }

    }
}
