using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{
    public class LogEntryManager : ILogEntryService
    {
        private ILogEntryDal _logEntryDal;
        public LogEntryManager(ILogEntryDal logEntryDal)
        {
            _logEntryDal = logEntryDal;
        }
        public void LogForAdd(Worker worker, Member member)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"{worker.WorkerUserName}"+" "+$"{member.MemberName}"+" "+$"{member.MemberSurname}" +
                        $" İsimli Yeni Bir Üye Oluşturdu ve " +
                        $"Yeni Üyenin Hesap Bakiyesini {member.Balance} ₺ Olarak Belirledi.";
                };
                _logEntryDal.Add(logEntry);
            }
        }

        public List<LogEntry> GetAll()
        {
            return _logEntryDal.GetAll();
        }

        public void Delete(LogEntry logEntry)
        {
            try
            {
                _logEntryDal.Delete(logEntry);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }
        }

        public void LogForUpdate(Worker worker, Member member)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"{worker.WorkerUserName} İsimli Çalışan Tarafından"+$"{member.MemberName}" +" "+$"{member.MemberSurname}" +
                        $"İsimli Kullanıcının Hesap Bakiyesi {member.Balance} ₺ Olarak Belirlendi.";
                };
                _logEntryDal.Add(logEntry);
            }
        }
    }
}
