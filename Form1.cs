using System;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo");
                return;
            }

            long total = 0;

            if (chkClean.Checked) total += 100000;
            if (chkWhitening.Checked) total += 1200000;
            if (chkXRay.Checked) total += 200000;

            total += (long)numFilling.Value * 80000;

            txtTotal.Text = total.ToString()+" VND";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}