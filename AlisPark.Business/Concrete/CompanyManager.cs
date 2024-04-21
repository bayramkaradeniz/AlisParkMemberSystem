using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace AlisPark.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;
        private IWorkerDal _workerDal;

        public CompanyManager(ICompanyDal companyDal,IWorkerDal workerDal)
        {
            _companyDal = companyDal;
            _workerDal = workerDal;
        }


        public void AddWorker(Worker worker)
        {
            _workerDal.Add(worker);
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }
    }
}
