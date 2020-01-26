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
using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FillYourDetails.xaml
    /// </summary>
    public partial class FillYourDetails : Window
    {
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;");

        public FillYourDetails()
        {
            InitializeComponent();
           
            FillComboFromServers();
            FillComboFromDivision();
            FillComboFromRole();
            FillComboFromCharacters();
            FillComboFromCharacters();
            FillComboFromCharacters();
            FillComboFromGender();
            
            
        }
        void FillComboFromServers()
        {
            
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT (Server_Name) from dbo.Servers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Server.Items.Add(dr["Server_Name"].ToString());
            }
            sqlCon.Close();
        }
       void FillComboFromDivision()
        {
            Division.Items.Clear();
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT (Name_Division) from dbo.Divisions";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Division.Items.Add(dr["Name_Division"].ToString());
            }
            sqlCon.Close();
        }

        void FillComboFromRole()
        {
            Role.Items.Clear();
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT (Name_Role) from dbo.Role";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Role.Items.Add(dr["Name_Role"].ToString());
            }
            sqlCon.Close();
        }

        void FillComboFromCharacters()
        {
            
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT (Name_Character) from dbo.Characters";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Char1.Items.Add(dr["Name_Character"].ToString());
            }
            sqlCon.Close();
        }

        void FillComboFromGender()
        {
            Gender.Items.Clear();
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT (TypeOfGender) from dbo.Gender";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Gender.Items.Add(dr["TypeOfGender"].ToString());
            }
            sqlCon.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "UPDATE tblUser SET Nickname = '" + Nickname.Text + "', Server = '" + Server.Text + "', Division = '" + Division.Text + "', Role = '" + Role.Text + "', Discord_id = '" + Contact.Text + "', Gender = '" + Gender.Text + "', Top_Character = '" + Char1.Text + "' FROM tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Confirmed");
            sqlCon.Close();

        }
        private void Char1_TextInput(object sender, TextCompositionEventArgs e)
        {
            FillComboFromCharacters();
        }

        private void Server_TextInput(object sender, TextCompositionEventArgs e)
        {
            FillComboFromServers();
            
        }

  
        private void Role_TextInput_1(object sender, TextCompositionEventArgs e)
        {
            FillComboFromRole();
        }

      

        private void Division_TextInput_1(object sender, TextCompositionEventArgs e)
        {
            FillComboFromDivision();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Table win = new Table();
            win.Show();
            
        }

        private void Gender_TextInput(object sender, TextCompositionEventArgs e)
        {
            FillComboFromGender();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "DELETE FROM dbo.ActiveUser";
            cmd.ExecuteNonQuery();
            sqlCon.Close();

        }

       

        private void Nickname_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Nickname FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Nickname.Text = sdr["Nickname"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Server_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Server FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Server.Text = sdr["Server"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Division_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Division FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Division.Text = sdr["Division"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Role_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Role FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Role.Text = sdr["Role"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Contact_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Discord_id FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Contact.Text = sdr["Discord_id"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Gender_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Gender FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Gender.Text = sdr["Gender"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Char1_Loaded(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Top_Character FROM dbo.tblUser t INNER JOIN ActiveUser a on t.UserID = a.ID WHERE t.UserID LIKE a.ID"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        Char1.Text = sdr["Top_Character"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Logowanie win = new Logowanie();
            win.Show();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
