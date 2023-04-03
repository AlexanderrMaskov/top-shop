using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_shop_models
{
    public class ItemWarehouse
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        [StringLength(500)]public string? Comment { get; set; }
        [Required] public virtual Warehouse Warehouse { get; set; }
        [Required] public virtual Item Item { get; set; }

    }
}
