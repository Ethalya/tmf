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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Bonus.xaml
    /// </summary>
    public partial class Bonus : Window
    {
        
        public Bonus()
        {
            InitializeComponent();
        }

        public static void addRecord(string ID, string Nick, string Server, string filepath)
        {

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(ID + "," + Nick + "," + Server);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Bleh :", ex);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string i = txtID.Text;
            string n = txtNick.Text;
            string s = txtServer.Text;

            addRecord(i, n, s, "Zapis.csv");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = "Zapis.csv";
            string st = File.ReadAllText(path);
            Import.Text = st;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
