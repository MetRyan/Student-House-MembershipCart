using BussinenssObject.Models;
using Microsoft.Extensions.Configuration;
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

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ICustomerRepository repository = new CustomerRepository();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("jsconfig1.json", true, true).Build();
            var adminUser = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            if (adminUser == txtUsername.Text && adminPassword == txtPassword.Text)
            {
                Homepage f = new Homepage();// chinh lai qua trang admin
                f.ShowDialog();
            }
            else
            {

                Boolean check = repository.CheckLogin(txtUsername.Text, txtPassword.Text);
                if (check)
                {
                    string email = txtUsername.Text;
                    this.Hide();
                    CustomerManagement getCustomerbyEmail = repository.GetCustomerByEmail(email);
                    Homepage f = new Homepage()

                    {
                        CustomerManagement = getCustomerbyEmail,
                    };
                    f.ShowDialog();
                    f.Close();
                    /*Customer*//**/
                    //                   asd@gmail.com
                    //                     123123

                    // admin
                    //               admin@fstore.com
                    //admin@@
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
