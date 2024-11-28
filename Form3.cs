using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_ChieuT5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(txtFirstName.Text);
            newitem.SubItems.Add(txtLastName.Text);
            newitem.SubItems.Add(txtPhone.Text);
            listView1.Items.Add(newitem);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];

            selectedItem.Text = txtFirstName.Text;
            selectedItem.SubItems[1].Text = txtLastName.Text;
            selectedItem.SubItems[2].Text = txtPhone.Text;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa mục này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item); // Xóa mục được chọn

                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                txtFirstName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
