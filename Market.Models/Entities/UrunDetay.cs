using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class UrunDetay : BaseEntity<Guid>
    {
        public UrunDetay()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
