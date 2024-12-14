namespace Glocery_Shop
{
    public partial class SaleForm : Form
    {
        private int employeeId;
        private string authorityLevel;

        public SaleForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLevel = authorityLevel;
        }

        public SaleForm(object authorityLevel, object employeeId)
        {
            InitializeComponent();
            this.employeeId = Convert.ToInt32( employeeId);
            this.authorityLevel = authorityLevel.ToString();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            var fr = new ManageCustomer(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            var fr = new OrderHistory(authorityLevel, employeeId);
            Hide();
            fr.ShowDialog();
        }
    }
}
