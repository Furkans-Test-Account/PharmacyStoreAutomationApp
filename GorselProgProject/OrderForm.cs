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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgProject
{
    public partial class OrderForm : Form
    {
        //sehir listesi (collections)
        private List<string> cityItems = new List<string>();
        public OrderForm()
        {
            InitializeComponent();

            labelChoice.Text = "Please choose complaint reason ";
            labelCity.Text = "Plase choose city :";

            comboBoxList.Items.Add("Services");
            comboBoxList.Items.Add("Transfer");
            comboBoxList.Items.Add("Application");
            comboBoxList.Items.Add("Advice");
            comboBoxList.Items.Add("Another");

            //listeye item ekleme
            cityItems.Add("İstanbul");
            cityItems.Add("Ankara");
            cityItems.Add("İzmir");
            cityItems.Add("Bursa");
            cityItems.Add("Gaziantep");
            cityItems.Add("Kayseri");
            cityItems.Add("Konya");
            cityItems.Add("Antalya");
            cityItems.Add("Mersin");
            cityItems.Add("Diyarbakır");
            cityItems.Add("Eskişehir");
            cityItems.Add("Denizli");
            cityItems.Add("Samsun");
            cityItems.Add("Şanlıurfa");
            cityItems.Add("Malatya");
            listBoxCity.DataSource = cityItems;

        }
        string complaint = string.Empty;

        private void searchItem(string searchText)
        {
            listBoxCity.ClearSelected();


            // listedeki sehilerler icinde yazilan texti arama (searchbar)
            for (int i = 0; i < cityItems.Count; i++)
            {
                // to lower kullanarak buyuk-kucuk harf duyarliligini kaldiriyorum
                if (cityItems[i].ToLower().Contains(searchText.ToLower()))
                {
                    listBoxCity.SelectedIndex = i;
                    return;
                }
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {



        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
           
            // secilen itemleri listelerden alma 
            string selectedCity = listBoxCity.SelectedItem.ToString();
         
            string selectedComboBox = comboBoxList.SelectedItem.ToString();
            
            // richtextbox'a yazilanlari alma
            string richText= richTextBoxMail.Text;

            
            string combinedText = $"Selected City: {selectedCity}{Environment.NewLine}" +
                                  $"Selected Country: {selectedComboBox}{Environment.NewLine}" +
                                  $"Rich Text Content:{Environment.NewLine}{richText}";

            try
            {
                // dosya yolunu secme 
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "UserMail.txt");

                // birlestirilmis verileri yazdirma 
                File.WriteAllText(filePath, combinedText);

                MessageBox.Show("Mail sent succesfully!" );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void OrderForm_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchItem(textBoxSearch.Text);
        }
    }
}
