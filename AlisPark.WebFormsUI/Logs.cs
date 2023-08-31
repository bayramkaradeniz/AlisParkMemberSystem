using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.WebFormsUI
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
        }
        private ILogEntryService _logEntryService;

        private void Logs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
        private void LoadLogs()
        {
            dgvLogs.DataSource = _logEntryService.GetAll();
        }

        private void tbxMemberNameSearchLog_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxMemberNameSearchLog.Text))
            {
                dgvLogs.DataSource = _logEntryService.GetLogsByMemberName(tbxMemberNameSearchLog.Text);
            }
            else
            {
                LoadLogs();
            }
        }

        private void btnRemoveLogs_Click(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentRow != null)
            {
                try
                {
                    _logEntryService.Delete(new LogEntry
                    {
                        Id = Convert.ToInt32(dgvLogs.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Kayıt silindi!");
                    LoadLogs();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
