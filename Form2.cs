using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                lstBandau.Items.Add(txtHoten.Text);
                txtHoten.Text = "";
                txtHoten.Focus();
            }
        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            while (lstBandau.SelectedItems.Count > 0)
            {
                lstKetqua.Items.Add(lstBandau.SelectedItems[0]);
                lstBandau.Items.Remove(lstBandau.SelectedItems[0]);
            }
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.AddRange(lstBandau.Items);
            lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            while (lstKetqua.SelectedItems.Count > 0)
            {
                lstBandau.Items.Add(lstKetqua.SelectedItems[0]);
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[0]);
            }
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            lstBandau.Items.AddRange(lstKetqua.Items);
            lstKetqua.Items.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            for (int i = lstBandau.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstBandau.Items.RemoveAt(lstBandau.SelectedIndices[i]);
            }
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}