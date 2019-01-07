using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis : BaseEntity<int>
    {
    }
}
