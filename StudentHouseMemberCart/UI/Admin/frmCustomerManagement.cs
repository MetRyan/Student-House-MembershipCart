using BussinenssObject.Models;
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
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }
        BindingSource source;

        ICustomerRepository repository = new CustomerRepository();
        public void LoadCustomerList()
        {
            /*
                        txtCustomerId.Enabled = false;
                        txtCustomerName.Enabled = false;
                        txtCustomerBirhday.Enabled = false;
                        txtCustomerStatus.Enabled = false;
                        txtEmail.Enabled = false;
                        txtTelephone.Enabled = false;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        */
            dgvlistview.ReadOnly = true;

            try
            {
                var CustomerList = repository.GetCustomer();
                BindingSource source = new BindingSource();
                source.DataSource = CustomerList;
                txtCustomerID.DataBindings.Clear();
                txtDateCreated.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastname.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtSex.DataBindings.Clear();

                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                txtDateCreated.DataBindings.Add("Text", source, "DateCreated");
                txtDateOfBirth.DataBindings.Add("Text", source, "Dob");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastname.DataBindings.Add("Text", source, "LastName");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtSex.DataBindings.Add("Text", source, "Sex");

                dgvlistview.DataSource = null;
                dgvlistview.DataSource = source;

                //  List<CustomerManagement> Customer = repository.GetCustomer();
                /*                if (Customer.Count == 0)
                                {
                                    btnSearch.Enabled = false;
                                    txtSearch.Enabled = false;
                                    cbSearchType.Enabled = false;
                                    btnDelete.Enabled = false;
                                    btnUpdate.Enabled = false;

                                }
                                else
                                {

                                    btnSearch.Enabled = true;
                                    txtSearch.Enabled = true;
                                    cbSearchType.Enabled = true;
                                    btnDelete.Enabled = true;
                                    btnUpdate.Enabled = true;
                                }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }


        }
        private void reset()
        {
            txtCustomerID.Text = "";
            txtDateCreated.Text = "";
            txtDateOfBirth.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtPhone.Text = "";
            txtSex.Text = "";


        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {

            List<CustomerManagement> CustomerList = repository.GetCustomer().ToList();
            DialogResult d;

            if (CustomerList.Count == 0)
            {
                btnDelete.Enabled = false;
                return;
            }
            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var CustomerId = GetSelectedCUstomerID();
                CustomerManagement CustomerObject = repository.GetCustomerbyId(CustomerId);
                repository.DeleteCustomer(CustomerObject);
                LoadCustomerList();
            }
        }
        private int GetSelectedCUstomerID()
        {

            int rowIndex = dgvlistview.CurrentCell.RowIndex;
            int row = (int)dgvlistview.Rows[rowIndex].Cells["CarId"].Value;
            return row;
        }

        //bang Customer  chắc admin không cần tạo create -> mà trang Staff sẽ Create 
        /*  private void btnCreate_Click(object sender, EventArgs e)
          {
              frmCardetail frmCreateCar = new frmCardetail()
              {
                  InserorUpdate = false,
              };
              if (frmCreateCar.ShowDialog() == DialogResult.OK) ;
              {
                  LoadCarList();

              }

          }*/
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvlistview.Rows.Count > 0)
            {
                if (dgvlistview.ReadOnly == true)
                {
                    dgvlistview.ReadOnly = false;


                    dgvlistview.DefaultCellStyle.BackColor = Color.Aquamarine;

                }
                else
                {
                    dgvlistview.ReadOnly = true;

                    dgvlistview.DefaultCellStyle.BackColor = Color.White;

                }

            }
        }
        /* public List<CarInformation> SearchByType(String keyword, String searchBy)

         {
             searchBy = cbSearchType.Text;
             keyword = txtSearch.Text;
             return repository.SearchCarbyType(keyword, searchBy);

         }*/
        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            txtCustomerID.Enabled = false;
            txtDateCreated.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastname.Enabled = false;
            txtPhone.Enabled = false;
            txtSex.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text;
            String searchBy = cbSearchType.SelectedItem as string;
            DialogResult d;
            if (keyword == null || searchBy == null)
            {

                d = MessageBox.Show("Please enter 2 field", "Error Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }
            if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(searchBy))
            {

                dgvListviewCar.DataSource = repository.SearchCarbyType(keyword, searchBy);
                var result = repository.SearchCarbyType(keyword, searchBy);
                MessageBox.Show("Tìm thấy " + result.Count + " kết quả!");
            }


        }

        private void btnCarManament_Click(object sender, EventArgs e)
        {
            frmCustomerManagment frm = new frmCustomerManagment();
            this.Hide();
            frm.ShowDialog();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            List<CarInformation> carlist = repository.GetCarList().ToList();
            DialogResult d;

            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var customerId = GetSelectedCarID();
                CarInformation carObject = repository.GetCarListbyId(customerId);
                repository.DeleteCar(carObject);
                LoadCarList();
            }



        }
    }



}
