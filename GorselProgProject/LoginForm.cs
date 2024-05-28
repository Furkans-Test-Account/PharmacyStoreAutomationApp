using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;

namespace GorselProgProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Label textleri 
            labelH1.Text = "Welcome back!";
            labelH2.Text = "You need to log in before continuing.";
            buttonLogin.Text = "Log in";
            labelDate.Text = "Today is : " + DateTime.Now.ToString("D"); // guncel takvim gosterme        
            labelUser.Text = "Username :";
            labelPassword.Text = "Password :";
            linkLabelReset.Text = "Forgot your password ?";
            labelVersion.Text = "v2.5565";






        }
        // SQL server baglanti
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F3JACGL\SQLEXPRESS;Initial Catalog=DB_MedicineDepot;Integrated Security=True;");

        // linklabel'a hyperlink ekleme
        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/shorts/EMn2bPMldd8";

            try
            {

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // varsayilan tarayicida acmak icin gereken kod
                });
            }
            catch (Exception ex) // hata yakalama
            {

                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = string.Empty;

            
            try
            {   // SQL SERVER'a baglanti ve veri cekme
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Password FROM Table_DepoAdmins WHERE UserName =@p1", connection);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxUser.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    password = reader["password"].ToString();

                }
                //yanlis kullaci adi veya sifre de hata gösterimi
                if (password == string.Empty || password != textBoxPassword.Text)
                {

                    MessageBox.Show("Invalid username or password!");

                    // textboxlarin bosaltilmasi
                    textBoxUser.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Connection error! {ex.Message}");
            }
            finally
            {

                connection.Close();
            }



        }

      
    }
}
    

        

