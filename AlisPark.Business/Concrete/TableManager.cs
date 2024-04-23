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
using System.Web.UI.WebControls;
using Table = AlisPark.Entities.Concrete.Table;

namespace AlisPark.Business.Concrete
{
    public class TableManager : ITableService
    {
        private ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }
        public Table CreateTable()
        {
            List<TableEvent> tEvents = new List<TableEvent>();
            Table table = new Table();
            table.TableId = 0;
            table.Balance = 0.0m;
            table.TableEvents = tEvents;
            _tableDal.Add(table);
            return table; 
        }

        public bool Reset(Table table)
        {
            throw new NotImplementedException();
        }

        public bool Save(Table table)
        {
            throw new NotImplementedException();
        }

        public List<Table> GetAll()
        {
            //Business code            
            return _tableDal.GetAll();
        }

        public List<Table> GetTableByTableId(int tableId)
        {
            return _tableDal.GetAll(p => p.TableId == tableId);
        }

        public void Add(Table table)
        {
          //  ValidationTools.FluentValidate(new MemberValidator(), table);
            _tableDal.Add(table);
        }

        public void Update(Table member)
        {
          //  ValidationTools.FluentValidate(new MemberValidator(), table);
            _tableDal.Update(member);
        }

        public void Delete(Table table)
        {
            try
            {
                _tableDal.Delete(table);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }   

        public void AddNewTable()
        {
            throw new NotImplementedException();
        }


    }
}
