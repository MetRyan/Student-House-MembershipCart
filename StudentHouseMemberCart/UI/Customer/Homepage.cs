using BussinenssObject.Models;

namespace UI
{
    public partial class Homepage : Form
    {// khai b�o ?? truy?n object t? login v�o
        public CustomerManagement CustomerManagement { get; set; }
        public Homepage()
        {
            InitializeComponent();
        }
    }
}