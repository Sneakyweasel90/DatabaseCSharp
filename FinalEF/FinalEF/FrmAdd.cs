using FinalEF.models.datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalEF
{
    public partial class FrmAdd : Form
    {
        public Product product { get; set; }


        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SetProduct();
                MessageBox.Show($"Product has been added to the database.");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SetProduct()
        {
            product = new Product();

            product.ProductCode = txtProductCode.Text;
            product.Description = txtDescription.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.OnHandQuantity = Convert.ToInt32(txtQuantOnHand.Text);

        }

        private bool isValid()
        {
            int error = 0;
            string errorMessage = "";
            decimal unitPrice = -1;
            int onHand = -1;

            if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                error++;
                errorMessage += "Product code is required. \n";
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                error++;
                errorMessage += "Description is required. \n";
            }
            if (string.IsNullOrEmpty(txtUnitPrice.Text) || !decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                error++;
                errorMessage += "Please enter a valid unit price greater than 0. \n";
            }
            if (string.IsNullOrEmpty(txtQuantOnHand.Text) || !int.TryParse(txtQuantOnHand.Text, out onHand) || onHand <= 0)
            {
                error++;
                errorMessage += "Please enter a valid quantity on hand.";
            }
            if (error > 0)
            {
                MessageBox.Show(errorMessage);
                return false;
            }
            else
            {
                return true;
            }
        }


        private void FrmAdd_Load(object sender, EventArgs e)
        {
            this.Text = "Update Product.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}