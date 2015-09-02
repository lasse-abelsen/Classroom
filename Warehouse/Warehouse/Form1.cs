using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayItemsBelowThreshold();
        }

        private static void DisplayItemsBelowThreshold()
        {
            string ItemsBelowThreshold = null;

            using (DataClassesDataContext dc = new DataClassesDataContext())
            {
                var BelowThreshold = dc.Products
                    .Where(p => p.CurrentAmount > p.MinAmount)
                    .Select(p => p.Name);

                string BelowThr = "";

                foreach (var item in BelowThreshold)
                {
                    BelowThr += item.ToString() + "\n";
                }

                ItemsBelowThreshold += BelowThr;
                //MessageBox.Show("The following are below threshold:" + BelowThr);
            }

            MessageBox.Show("The following Items are below minimum:\n" + ItemsBelowThreshold);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.warehouseDBDataSet.Product);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var nokia = dc.Products
                .Where((p => p.Name == "Nokia 3310"))
                .Select(p => p.PriceDKK);

            foreach (var q in nokia)
            {
                MessageBox.Show(q.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var prod = ProductFilter.ProductPriceRange(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            foreach (var p in prod)
            {
                var item = p.Name + Environment.NewLine;
                richTextBox1.AppendText(item);
            }
        }
    }
}
