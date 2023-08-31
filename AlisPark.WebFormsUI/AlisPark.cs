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
    public partial class AlisPark : Form
    {
        public AlisPark()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _workerService = InstanceFactory.GetInstance<IWorkerService>();

        }
        private IMemberService _memberService;
        private ICategoryService _categoryService;
        private ILogEntryService _logEntryService;
        private IWorkerService _workerService;
        private void AlisPark_Load(object sender, EventArgs e)
        {
            
            LoadCategories();
            LoadMembers();
        }

        private void LoadMembers()
        {
            dgvMember.DataSource = _memberService.GetAll();
        }

        private void LoadCategories()
        {

            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";

            cbxCurrentWorker.DataSource = _workerService.GetAll();
            cbxCurrentWorker.DisplayMember = "WorkerUserName";
            cbxCurrentWorker.ValueMember = "WorkerId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvMember.DataSource = _memberService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxMemberNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxMemberNameSearch.Text))
            {
                dgvMember.DataSource = _memberService.GetProductsByMemberName(tbxMemberNameSearch.Text);
            }
            else
            {
                LoadMembers();
            }
        }


        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMember.CurrentRow;
            tbxMemberNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[4].Value;
            tbxBalanceUpdate.Text = row.Cells[5].Value.ToString();
            tbxMemberSurnameUpdate.Text = row.Cells[2].Value.ToString();
            tbxMemberPhoneUpdate.Text = row.Cells[3].Value.ToString();

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //if (tbxUserNameLogLogin.Text == "admin" && tbxPasswordLogLogin.Text == "Huxx.09")
            //{
            //    Logs Logs = new Logs();
            //    Logs.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            //}
            Logs Logs = new Logs();
            Logs.Show();

        }

        private void btnMemberAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                _memberService.Add(new Member
                {
                    CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                    MemberName = tbxMemberNameAdd.Text,
                    MemberSurname = tbxMemberSurnameAdd.Text,
                    Balance = Convert.ToDecimal(tbxBalanceAdd.Text),
                    MemberPhone = tbxMemberPhoneAdd.Text
                });
                _logEntryService.LogForAdd(new Worker
                {
                    WorkerUserName = cbxCurrentWorker.Text,
                },
                new Member
                {
                    MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                    MemberName = tbxMemberNameAdd.Text,
                    MemberSurname = tbxMemberSurnameAdd.Text,
                    Balance = Convert.ToDecimal(tbxBalanceAdd.Text),
                });
                MessageBox.Show("Üye Eklendi.");
                LoadMembers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnMemberUpdate_Click_1(object sender, EventArgs e)
        {
            _memberService.Update(new Member
            {
                MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                MemberName = tbxMemberNameUpdate.Text,
                MemberSurname = tbxMemberSurnameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                Balance = Convert.ToDecimal(tbxBalanceUpdate.Text),
                MemberPhone = tbxMemberPhoneUpdate.Text,
            });
            _logEntryService.LogForUpdate(new Worker
            {
                WorkerUserName = cbxCurrentWorker.Text,
            },
            new Member
            {
                MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                MemberName = tbxMemberNameUpdate.Text,
                MemberSurname = tbxMemberSurnameUpdate.Text,
                Balance = Convert.ToDecimal(tbxBalanceUpdate.Text),
            });
            MessageBox.Show("Üye Güncellendi.");
            LoadMembers();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvMember.CurrentRow != null)
            {
                try
                {
                    _memberService.Delete(new Member
                    {
                        MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value)
                    });
                    //MessageBox.Show("Üye silindi!");
                    LoadMembers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}

