using Repository.IRepository;
using Repository.Repository;


namespace UI.Customer
{
    public partial class Register : Form
    {
        ICustomerRepository customer = new CustomerRepository();
        string connectionString = GetConnectionString();

        static private string GetConnectionString()
        {
            return "Data Source=DESKTOP-IDK73G0;Initial Catalog=StudentHouseMembership;Integrated Security=True";
        }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            //add customer to database







        }
    }
}


