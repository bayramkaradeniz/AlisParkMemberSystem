using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{

    public interface IMemberService
    {
        List<Member> GetAll();
        List<Member> GetProductsByCategory(int categoryId);
        List<Member> GetProductsByProductName(string memberName);
        void Add(Member product);
        void Update(Member product);
        void Delete(Member product);
    }


}
