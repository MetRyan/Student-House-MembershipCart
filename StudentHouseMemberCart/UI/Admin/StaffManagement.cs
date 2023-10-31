using BussinenssObject;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Admin
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }
        IStaffRepository repository = new StaffRepository();

        public void LoadStaffList()
        {
            txtStaffId.Enabled = false;
            txtStaffName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtdob.Enabled = false;
            txtSex.Enabled = false;
            txtStatus.Enabled = false;
            txtAdress.Enabled = false;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            try
            {
                var StaffList = repository.getStaffs();
                BindingSource source = new BindingSource();
                source.DataSource = StaffList;

                txtStaffId.DataBindings.Clear();

                txtStaffName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtdob.DataBindings.Clear();
                txtSex.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtAdress.DataBindings.Clear();



                txtStaffId.DataBindings.Add("Text", source, "CustomerId");
                txtStaffName.DataBindings.Add("Text", source, "CustomerName");
                txtEmail.DataBindings.Add("Text", source, "CustomerBirthday");
                txtPhone.DataBindings.Add("Text", source, "CustomerStatus");
                txtdob.DataBindings.Add("Text", source, "Email");
                txtSex.DataBindings.Add("Text", source, "Telephone");

                txtStatus.DataBindings.Add("Text", source, "Email");
                txtAdress.DataBindings.Add("Text", source, "Telephone");

                dgv.DataSource = null;
                dgv.DataSource = source;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            txtStaffId.Enabled = false;
            txtStaffName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtdob.Enabled = false;
            txtSex.Enabled = false;
            txtStatus.Enabled = false;
            txtAdress.Enabled = false;


            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void reset()
        {
            txtStaffId.Text = "";
            txtStaffName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtdob.Text = "";
            txtSex.Text = "";
            txtPhone.Text = "";
            txtAdress.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {



        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StaffDetail frm = new StaffDetail()
            {
                InserorUpdate = false,
            };
            if (frm.ShowDialog() == DialogResult.OK) ;
            {
                LoadStaffList();

            }
        }
        private int GetselecttedStaffId()
        {

            int rowIndex = dgv.CurrentCell.RowIndex;
            int row = (int)dgv.Rows[rowIndex].Cells["StaffId"].Value;
            return row;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<staff> CustomerList = repository.getStaffs().ToList();
            DialogResult d;
            if (CustomerList.Count == 0)
            {
                btnDelete.Enabled = false;
                return;
            }
            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var StaffId = GetselecttedStaffId();
                staff staffObject = repository.getStaffbyId(StaffId);
                repository.deleteStaff(staffObject);
                LoadStaffList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StaffDetail frm = new StaffDetail()
            {
                InserorUpdate = true,
                getStaffId = GetselecttedStaffId(),
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStaffList();

            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
