using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace top_shop_models
{
    public class Order
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public virtual Client Client { get; set; }

        public virtual ICollection<ItemOrder> ItemOrders { get; set; }

    }
}
