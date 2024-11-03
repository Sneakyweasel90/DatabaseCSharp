using FinalEF.models.datalayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FinalEF
{
    public partial class Form1 : Form
    {
        private ProductsContext context = new ProductsContext();
        private Product product;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayProduct()
        {
            lblDescription.Text = product.Description;
            lblOnHandQuantity.Text = Convert.ToString(product.OnHandQuantity);
            lblUnitPrice.Text = Convert.ToString(product.UnitPrice);
        }

        private void HandleDataError(DbUpdateException ex)
        {
            string productCode = "";

            string error = "";

            var sqlException = (SqlException?)ex.InnerException;

            foreach (SqlError err in sqlException.Errors)
            {
                error += $"{err.Number} {err.Message} \n";
            }
            MessageBox.Show(error, "ERROR");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string productCode = txtGet.Text;

            if (!string.IsNullOrEmpty(productCode))
            {
                try
                {
                    product = context.Products.Find(productCode);

                    if (product != null)
                    {
                        displayProduct();
                    }
                    else
                    {
                        MessageBox.Show($"Product '{productCode}' is not found in the database.");
                        txtGet.Text = string.Empty;
                        txtGet.Focus();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please enter a product code.");
                txtGet.Text = string.Empty;
                txtGet.Focus();
                lblDescription.Text = string.Empty;
                lblOnHandQuantity.Text = string.Empty;
                lblUnitPrice.Text = string.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();


            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    product = frm.product;
                    context.Products.Add(product);
                    context.SaveChanges();
                    displayProduct();
                }
                catch (DbUpdateException ex)
                {
                    HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}