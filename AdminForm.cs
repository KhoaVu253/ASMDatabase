using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glocery_Shop
{
    public partial class AdminForm : Form
    {
        int employeeId;
        string authorityLevel;

        public AdminForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        public AdminForm(object authorityLevel1, object employeeId1)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            var fr = new ManageEmployee(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            var fr = new ManageProduct(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            var fr = new OrderHistory(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }

        private void btnManageImport_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStatistic_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var fr = new ManageCustomer(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

