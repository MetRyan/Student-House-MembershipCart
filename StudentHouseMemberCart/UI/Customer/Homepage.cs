using BussinenssObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI.Customer
{
    public partial class Homepage : Form
    {// khai b�o ?? truy?n object t? login v�o
        public Customer CustomerManagement { get; set; }
        public Homepage()
        {
            InitializeComponent();
        }
            }
}