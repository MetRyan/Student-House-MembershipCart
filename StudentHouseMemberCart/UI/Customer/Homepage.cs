using BussinenssObject.Models;

namespace UI
{
    public partial class Homepage : Form
    {// khai báo ?? truy?n object t? login vào
        public CustomerManagement CustomerManagement { get; set; }
        public Homepage()
        {
            InitializeComponent();
        }
    }
}