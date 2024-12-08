using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.pname = txtProductName.Text;
            product.packSize = txtPackSize.Text;
            product.location = txtLocation.Text;
            product.generic = txtGeneric.Text;
            product.expiryDate = ExpiryDate.Value;
            product.sale_rate = Convert.ToInt32(txtSaleRate.Text);
            product.purchase_rate = Convert.ToInt32(txtPurchaseRate.Text);
            product.ptype = cmbType.Text;
            db.products.InsertOnSubmit(product);
            db.SubmitChanges();
            MessageBox.Show("Data Successfully Inserted");
        }
    }
}
