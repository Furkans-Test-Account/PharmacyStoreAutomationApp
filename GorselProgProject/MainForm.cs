using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace GorselProgProject
{
    public partial class MainForm : Form


    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F3JACGL\SQLEXPRESS;Initial Catalog=DB_MedicineDepot;Integrated Security=True;");

        public MainForm()
        {
            InitializeComponent();
            
            // ID SQL tarafindan belirlenecek (primary key )
            labelidd.Text = " ID will be set automatically";
           
        }

        // Verileri ekleme-gosterme metodu
        private void showData()
        {
            // SQL  komutuyla db' deki tablodaki verileri gridview da gosterme
            string query = "SELECT * FROM Table_Medicines";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                // Veri tabanına yeni veri ekleme 
                SqlCommand SqlCmd = new SqlCommand("INSERT INTO Table_Medicines (MedicineName,LicenseNumber,LicenseOwner,ProductionPlace,Price,ExprationDate,InStock) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", connection);
                SqlCmd.Parameters.AddWithValue("@P1", textBoxName.Text);
                SqlCmd.Parameters.AddWithValue("@P2", Convert.ToInt32(textBoxNumber.Text));
                SqlCmd.Parameters.AddWithValue("@P3", textBoxOwner.Text);
                SqlCmd.Parameters.AddWithValue("@P4", textBoxPlace.Text);
                SqlCmd.Parameters.AddWithValue("@P5", Convert.ToInt32(textBoxPrice.Text));
                SqlCmd.Parameters.AddWithValue("@P6", dateTimePicker1.Value.ToShortDateString());
                SqlCmd.Parameters.AddWithValue("@P7", true);
                SqlCmd.ExecuteNonQuery();

                // metot cagirma
                showData();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

       
       
    }
}
