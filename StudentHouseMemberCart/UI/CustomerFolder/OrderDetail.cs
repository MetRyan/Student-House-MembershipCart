using BussinenssObject.Models;
using Repository.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI.Customer
{
    public partial class OrderDetail : Form
    {
        OrderRepository orderRepository = new OrderRepository();
        bool filter = false;
        bool search = false;

        //
        BindingSource source;
        BindingSource customerSource;
        IEnumerable<string> customerList = null;
        //

        IEnumerable<Order> dataSource;
        IEnumerable<Order> searchResult;
        IEnumerable<Order> filterResult;
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            txtCustomerId.Enabled = false;
            txtOrderId.Enabled = false;
            txtEmail.Enabled = false;
            txtCustomerName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtPaymentMethod.Enabled = false;
            txtPrice.Enabled = false;
            txtServiceName.Enabled = false;
            txtServiceId.Enabled = false;
            txtStatus.Enabled = false;
            txtNote.Enabled = false;
            dtpDateCreated.Enabled = false;
            dtpDateCompleted.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadOrderList()
        {
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    IQueryable<OrderManagement> query = context.OrderManagements; // OrderManagement(s) ?

                    // Assuming you have a list of unique customer names in your database
                    customerList = query.Select(order => order.CustomerName)
                                        .Where(name => !string.IsNullOrEmpty(name.Trim()))
                                        .OrderBy(name => name)
                                        .Distinct()
                                        .Prepend("All")
                                        .ToList();

                    if (customerList.Count() > 0)
                    {
                        customerSource = new BindingSource();
                        customerSource.DataSource = customerList;
                        cbOrders.DataSource = null;
                        cbOrders.DataSource = customerSource;
                    }

                    source = new BindingSource();
                    source.DataSource = filter ? filterResult : query.ToList();

                    txtCustomerId.DataBindings.Clear();
                    txtOrderId.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtCustomerName.DataBindings.Clear();
                    txtAddress.DataBindings.Clear();
                    txtPhone.DataBindings.Clear();
                    txtPaymentMethod.DataBindings.Clear();
                    txtPrice.DataBindings.Clear();
                    txtServiceName.DataBindings.Clear();
                    txtServiceId.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();
                    txtNote.DataBindings.Clear();
                    dtpDateCreated.DataBindings.Clear();
                    dtpDateCompleted.DataBindings.Clear();

                    txtCustomerId.DataBindings.Add("Text", source, "CustomerId");
                    txtOrderId.DataBindings.Add("Text", source, "OrderId");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
                    txtAddress.DataBindings.Add("Text", source, "Address");
                    txtPhone.DataBindings.Add("Text", source, "Phone");
                    txtPaymentMethod.DataBindings.Add("Text", source, "PaymentMethod");
                    txtPrice.DataBindings.Add("Text", source, "Price");
                    txtServiceName.DataBindings.Add("Text", source, "ServiceName");
                    txtServiceId.DataBindings.Add("Text", source, "ServiceId");
                    txtStatus.DataBindings.Add("Text", source, "Status");
                    txtNote.DataBindings.Add("Text", source, "Note");
                    dtpDateCreated.DataBindings.Add("Value", source, "DateCreated");
                    dtpDateCompleted.DataBindings.Add("Value", source, "DateCompleted");

                    if (query.Count() >= 0)
                    {
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order List");
            }
        }

        private void cbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbOrders.DataSource != null)
                {
                    string orders = cbOrders.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(orders))
                    {
                        IEnumerable<OrderManagement> searchResult;
                        if (search)
                        {
                            searchResult = orderRepository.FilterOrderByServiceName(orders, this.searchResult);
                        }
                        else
                        {
                            searchResult = orderRepository.FilterOrderByServiceName(orders, dataSource);
                        }

                        if (searchResult.Any())
                        {
                            filterResult = searchResult;
                            filter = true;
                            LoadOrderList();
                        }
                        else
                        {
                            MessageBox.Show("No result found!", "Search order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
