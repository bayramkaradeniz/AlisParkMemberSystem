using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.Entities.Concrete
{
    public class Table : IEntity
    {
        [Key]
        public int TableId { get; set; }
        public List<TableEvent> TableEvents { get; set; }
        public decimal Balance { get; set; }
        
    }
}
