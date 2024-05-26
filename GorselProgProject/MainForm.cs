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
using System.Data.SqlTypes;

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
        private void DisplayData()
        {
            // SQL  komutuyla db' deki tablodaki verileri gridview da gosterme
            string query = "SELECT * FROM Table_Medicines";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        // BUTTON ADD
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
                SqlCmd.Parameters.AddWithValue("@P7", Convert.ToBoolean(checkBoxStock.Checked));
                SqlCmd.ExecuteNonQuery();

                // metot cagirma
                DisplayData();

                LoadingForm loadingForm = new LoadingForm();
                loadingForm.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error data adding: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }


        // DATA GRIDVIEW 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // tiklanan satirin verilerini getirme (null gelemez)
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            labeliD.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxNumber.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxOwner.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxPlace.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            // return value date olmali
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[6].Value;
            //return value bool olmali
            checkBoxStock.Checked = Convert.ToBoolean(dataGridView1.Rows[selectedRow].Cells[5].Value);
        }


        // Guncelleme icin  gereken sql query komutlari  
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                // Update komutu ile Sql de guncelleme 
                SqlCommand SqlCmd = new SqlCommand("UPDATE Table_Medicines SET MedicineName=@P1,LicenseNumber=@P2,LicenseOwner=@P3,ProductionPlace=@P4,Price=@P5,ExprationDate=@P6,InStock=@P7 WHERE ID =@P8", connection);
                SqlCmd.Parameters.AddWithValue("@P1", textBoxName.Text);
                SqlCmd.Parameters.AddWithValue("@P2", Convert.ToInt32(textBoxNumber.Text));
                SqlCmd.Parameters.AddWithValue("@P3", textBoxOwner.Text);
                SqlCmd.Parameters.AddWithValue("@P4", textBoxPlace.Text);
                SqlCmd.Parameters.AddWithValue("@P5", Convert.ToInt32(textBoxPrice.Text));
                SqlCmd.Parameters.AddWithValue("@P6", dateTimePicker1.Value.ToShortDateString());
                SqlCmd.Parameters.AddWithValue("@P7", Convert.ToBoolean(checkBoxStock.Checked));
                SqlCmd.Parameters.AddWithValue("@P8", labeliD.Text);
                SqlCmd.ExecuteNonQuery();
            }
            catch(Exception ex)  
            {
                MessageBox.Show($"Error updating :{ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            DisplayData();

        }
    }
}
