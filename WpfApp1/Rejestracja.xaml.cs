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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtPassword.Password != txtConfirmPassword.Password)
                MessageBox.Show("Password do not match");

            else if (txtPassword.Password == "" || txtName.Text == "")
                MessageBox.Show("Please fill mandatory fields");

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {

                    sqlCon.Open();
                    bool exists = false;
                    using (SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.tblUser where Login = @Login", sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@Login", txtName.Text);
                        exists = (int)sqlCmd.ExecuteScalar() > 0;
                    }
                    if (exists)
                        MessageBox.Show("This username has been using by another user");

                    else
                    {

                        using (SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon))
                        {
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@Login", txtName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password.Trim());
                            sqlCmd.ExecuteNonQuery();
                            Clear();

                            Logowanie win = new Logowanie();
                            win.Show();
                            this.Close();
                        }
                    }
                }
            }
        
        }
        void Clear()
        {
            txtName.Text = txtPassword.Password = txtConfirmPassword.Password;
        }
     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Logowanie win = new Logowanie();
            win.Show();
            this.Close();
        }
    }
}