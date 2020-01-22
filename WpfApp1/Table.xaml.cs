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
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = TeammateFinder; Integrated Security=True;");
        public Table()
        {
            InitializeComponent();
          
        }
    

       

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlCon.Open();
            string Query = "SELECT Nickname, Server, Division,Role, Discord_id,Gender,Top_Character FROM dbo.tblUser";
            SqlCommand createCommand = new SqlCommand(Query, sqlCon);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("dbo.tblUser");
            da.Fill(dt);
            TableGrid.ItemsSource = dt.DefaultView;
            TableGrid.Columns[0].Visibility = 0;
            da.Update(dt);
            sqlCon.Close();


        }

        private void TableGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
