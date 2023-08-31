using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{
    public class WorkerManager : IWorkerService
    {
        private IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
        }
    }
}
