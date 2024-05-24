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

            labelidd.Text = " Id will be set automatically";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   // SQL  komutuyla tablodaki verileri gridview da gosterme
            string query = "SELECT * FROM Table_Medicines";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();  
            orderForm.ShowDialog();
        }
    }
}
