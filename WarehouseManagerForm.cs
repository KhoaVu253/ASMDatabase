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
    public partial class WarehouseManagerForm : Form
    {
        int employeeId;
        string authorityLevel;

        public WarehouseManagerForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        public WarehouseManagerForm(object authorityLevel1, object employeeId1)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            var fr = new ManageProduct(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }
    }
}
