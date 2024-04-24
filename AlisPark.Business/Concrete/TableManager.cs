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
using System.Text.RegularExpressions;
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
            List<Table> tables = new List<Table>();
            tables = _tableDal.GetAll(p => p.TableName.ToLower().Contains("masa".ToLower()));

            int greatestTableNumber = 0;
            foreach(Table tab in tables)
            {                
                int number = Convert.ToInt32(Regex.Match(tab.TableName, @"\d+").Value);
                if (number > greatestTableNumber) 
                    greatestTableNumber = number;
            }


            List<TableEvent> tEvents = new List<TableEvent>();
            Table table = new Table();
         //   table.TableId = 0;
            table.TableBalance = 0.0m;
            table.TableEvents = tEvents;
            table.TableName = "MASA " + (greatestTableNumber + 1); // TODO: CUSTOMIZE "MASA" WORD
            _tableDal.Add(table);
            return table; 
        }

        public Table GetTableByTableName(string tableName)
        {
            return _tableDal.Get(p => p.TableName.ToLower().Contains(tableName.ToLower()));
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
