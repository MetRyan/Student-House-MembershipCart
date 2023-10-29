using Microsoft.Extensions.Configuration;
using Repository.IRepository;
using Repository.Repository;
using BussinenssObject.Models;

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
                Customer.Homepage f = new Customer.Homepage();// chinh lai qua trang admin
                f.ShowDialog();
            }
            else
            {

                Boolean check = repository.CheckLogin(txtUsername.Text, txtPassword.Text);
                if (check)
                {
                    string email = txtUsername.Text;
                    this.Hide();
                    CustomerT getCustomerbyEmail = repository.GetCustomerByEmail(email);
                    Customer.Homepage f = new Customer.Homepage()

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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
