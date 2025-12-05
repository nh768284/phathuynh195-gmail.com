using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class Form1 : Form
    {
        CustomerBLL bll = new CustomerBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string result = bll.SaveCustomer(
                txtName.Text,
                txtPhone.Text,
                txtAddress.Text
            );

            MessageBox.Show(result);
        }
    }
}

