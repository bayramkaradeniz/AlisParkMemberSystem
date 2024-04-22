using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AlisPark.Business.Abstract
{
    public interface ITableService
    {
        Table CreateTable(); // returns created table or throws exception
        bool Save(Table table); // bool; whether succesful or not
        bool Reset(Table table); // bool; whether succesful or not
        void Add(Table table); 
        void Delete(Table table);
        void Update(Table table);
        List<Table> GetTableByTableId(int tableId);
        List<Table> GetAll();
    }
}
