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
    public partial class StaffDetail : Form
    {

        public bool InserorUpdate { get; set; }
        public int getStaffId { get; set; }



        IStaffRepository repository = new StaffRepository();

        public StaffDetail()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void StaffDetail_Load(object sender, EventArgs e)
        {
            if (InserorUpdate)
            {


                staff getStaff = repository.getStaffbyId(getStaffId);

                txtStaffId.DataBindings.Add("Text", getStaff, "StaffId");
                txtStaffName.DataBindings.Add("Text", getStaff, "StaffName");
                txtEmail.DataBindings.Add("Text", getStaff, "Email");
                txtPhone.DataBindings.Add("Text", getStaff, "Phone");
                dtpdob.DataBindings.Add("Text", getStaff, "Dob");
                cbSex.DataBindings.Add("Text", getStaff, "ManufaSexcturerId");
                cbStatus.DataBindings.Add("Text", getStaff, "Status");
                txtAdress.DataBindings.Add("Text", getStaff, "Address");
                txtPassword.DataBindings.Add("Text", getStaff, "Password");

                // validatoin -> khi input bi loi khong hien new input
                txtStaffId.CausesValidation = false;
                txtStaffName.CausesValidation = false;
                txtEmail.CausesValidation = false;
                txtPhone.CausesValidation = false;
                dtpdob.CausesValidation = false;
                cbStatus.CausesValidation = false;
                txtAdress.CausesValidation = false;
                txtPassword.CausesValidation = false;
                cbSex.CausesValidation = false;

                /*           txtCarName.DataBindings.Add("Text", car, "CarName", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarDescription.DataBindings.Add("Text", car, "CarDescription", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtNumberOfDoor.DataBindings.Add("Text", car, "NumberOfDoors", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSeatingCapacity.DataBindings.Add("Text", car, "SeatingCapacity", false, DataSourceUpdateMode.OnPropertyChanged);
                           cbFuelType.DataBindings.Add("Text", car, "FuelType", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtManufacturer.DataBindings.Add("Text", car, "ManufacturerId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSupplierID.DataBindings.Add("Text", car, "SupplierId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarStatus.DataBindings.Add("Text", car, "CarStatus", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarRenting.DataBindings.Add("Text", car, "CarRentingPricePerDay", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtYear.DataBindings.Add("Text", car, "Year", false, DataSourceUpdateMode.OnPropertyChanged); ;*/

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           /* txtStaffId.DataBindings.Add("Text", getStaff, "StaffId");
            txtStaffName.DataBindings.Add("Text", getStaff, "StaffName");
            txtEmail.DataBindings.Add("Text", getStaff, "Email");
            txtPhone.DataBindings.Add("Text", getStaff, "Phone");
            dtpdob.DataBindings.Add("Text", getStaff, "Dob");
            cbSex.DataBindings.Add("Text", getStaff, "ManufaSexcturerId");
            cbStatus.DataBindings.Add("Text", getStaff, "Status");
            txtAdress.DataBindings.Add("Text", getStaff, "Address");
            txtPassword.DataBindings.Add("Text", getStaff, "Password");*/
            try
            {
                if (  txtStaffName.Text == ""
                    || txtEmail.Text == "" || txtPhone.Text == "" || dtpdob.Text == ""
                    || cbSex.Text == "" || cbStatus.Text == "" || txtAdress.Text == ""
                    || txtPassword.Text == "" )
                {
                    MessageBox.Show("All fields are required!", "Staff Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String StaffName;
                    String Email;
                    String Phone;
                    DateTime dob ;
                    String txtAdress;
                    String status; 

                    if (!int.TryParse(txtNumberOfDoor.Text, out numberOfDoors))
                    {
                        MessageBox.Show("Number of Doors must be an integer.", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!byte.TryParse(txtCarStatus.Text, out carStatus) || (carStatus != 1 && carStatus != 0))
                    {
                        MessageBox.Show("Car Status must be 1 or 0", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!decimal.TryParse(txtCarRenting.Text, out carRentingPrice))
                    {
                        MessageBox.Show("Car Renting Price must be a valid numeric value.", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!int.TryParse(txtSupplierID.Text, out supplierId))
                    {
                        MessageBox.Show("Supplier ID must be an integer.", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!int.TryParse(txtManufacturer.Text, out manufacturerId))
                    {
                        MessageBox.Show("Manufacturer ID must be an integer.", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (!int.TryParse(txtYear.Text, out year) || year < 1900 || year > DateTime.Now.Year)
                    {
                        MessageBox.Show("Year must be a valid year.", "Car Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var p = new CarInformation
                        {
                            CarName = txtCarName.Text,
                            CarDescription = txtCarDescription.Text,
                            NumberOfDoors = int.Parse(txtNumberOfDoor.Text),
                            SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                            FuelType = cbFuelType.Text,
                            Year = year,
                            ManufacturerId = manufacturerId,
                            SupplierId = supplierId,
                            CarStatus = carStatus,
                            CarRentingPricePerDay = carRentingPrice
                        };

                        /*  CarName = txtCustomerName.Text,
                          CarDescription = DateTime.Parse(txtCustomerBirthday.Text),
                          CustomerStatus = byte.Parse(txtCustomerStatus.Text),
                          Email = txtEmail.Text,
                          Password = txtPassword.Text,
                          Telephone = txtTelephone.Text,*/
                        if (InserorUpdate == false)
                        {


                            repository.AddCar(p);
                            MessageBox.Show("Success", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                        else
                        {
                            p.CarId = getCarID;

                            repository.UpdateCar(p);
                            Close();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error oddddccurred: {ex.Message}", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
