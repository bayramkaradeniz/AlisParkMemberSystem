using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class Worker:IEntity
    {
        public int WorkerId { get; set; }
        public string WorkerFullName { get; set; }
    }
}
