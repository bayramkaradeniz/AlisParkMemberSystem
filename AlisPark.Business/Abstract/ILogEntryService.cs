using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface ILogEntryService
    {
        List<LogEntry> GetAll();
        List<LogEntry> GetLogsByMemberName(string memberName);
        void LogForAdd(Worker worker,Member member);
        void LogForUpdate(Worker worker, Member member);
        void Delete(LogEntry logEntry);
    }
}
