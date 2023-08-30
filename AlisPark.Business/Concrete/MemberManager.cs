using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetAll()
        {
            //Business code            
            return _memberDal.GetAll();
        }

        public List<Member> GetProductsByCategory(int categoryId)
        {
            return _memberDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Member> GetProductsByProductName(string memberName)
        {
            return _memberDal.GetAll(p => p.MemberName.ToLower().Contains(memberName.ToLower()));
        }

        public void Add(Member product)
        {
            ValidationTool.Validate(new MemberValidator(), product);
            _memberDal.Add(product);
        }

        public void Update(Member product)
        {
            ValidationTool.Validate(new MemberValidator(), product);
            _memberDal.Update(product);
        }

        public void Delete(Member product)
        {
            try
            {
                _memberDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }
    }
}
