using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rejestracja win = new Rejestracja();
            win.Show();
            this.Close();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            SqlConnection sqlCon = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;");
            sqlCon.Open();
            string query = "SELECT *FROM tblUser WHERE Login = '" + txtLogin.Text.Trim() + "'AND Password = '" + txtPassword.Password.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                string query1 = "INSERT INTO dbo.ActiveUser(ID) SELECT UserID from dbo.tblUser WHERE Login = '" + txtLogin.Text + "'";
                SqlDataAdapter sd = new SqlDataAdapter(query1, sqlCon);
                DataTable dtbl1 = new DataTable();
                sd.Fill(dtbl1);
                FillYourDetails win = new FillYourDetails();
                win.Show();
                this.Close();

            }

            else
                MessageBox.Show("Incorrect Login or Password");

            }
    }
   
}
