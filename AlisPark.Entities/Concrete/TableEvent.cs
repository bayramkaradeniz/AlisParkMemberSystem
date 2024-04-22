using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class TableEvent : IEntity
    {
        [Key]
        public int TableEventId { get; set; }
        public DateTime Date { get; set; }
        public int Adet { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public Table Table { get; set; }
    }
}
