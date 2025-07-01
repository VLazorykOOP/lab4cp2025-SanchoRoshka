using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlcoholSalesApp
{
    public partial class MainForm : Form
    {
        string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AlcoholSales;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Drinks", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Drinks (Type, Brand, Manufacturer, Expiration, Supplier, Price) " +
                               "VALUES (@Type, @Brand, @Manufacturer, @Expiration, @Supplier, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@Expiration", dateTimePickerExp.Value);
                cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    string query = "UPDATE Drinks SET Type=@Type, Brand=@Brand, Manufacturer=@Manufacturer, Expiration=@Expiration, Supplier=@Supplier, Price=@Price WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                    cmd.Parameters.AddWithValue("@Expiration", dateTimePickerExp.Value);
                    cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Drinks WHERE Brand LIKE @search OR Supplier LIKE @search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
                txtBrand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
                txtManufacturer.Text = dataGridView1.CurrentRow.Cells["Manufacturer"].Value.ToString();
                dateTimePickerExp.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Expiration"].Value);
                txtSupplier.Text = dataGridView1.CurrentRow.Cells["Supplier"].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            }
        }
    }
}
