using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] frasi = new string[10]; int i;
        string[] prezzo = new string[10];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInserisci_Click(object sender, RoutedEventArgs e)
        {
            frasi[i] = TxtInserisci.Text;
            prezzo[i] = TxtPrezzo.Text;
            i++;
            if (i == 10)
            {
                BtnInserisci.IsEnabled = false;
                BtnPubblica.IsEnabled = true;
                BtnStampa.IsEnabled = true;
            }
            TxtInserisci.Clear();
            TxtInserisci.Focus();
            TxtPrezzo.Clear();
            TxtPrezzo.Focus();
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            lblrisultato.Content = "";
            for (int i = 0; i < frasi.Length; i++)
            {
                lblrisultato.Content += $"{frasi[i] } {prezzo[i]}\n";
            }
        }

        private void BtnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter w = new StreamWriter("pubblica.txt", false, Encoding.UTF8);
            for (int i = 0; i < frasi.Length; i++)
            {
                w.WriteLine($"{frasi[i]} {prezzo[i]}\n");
            }
            w.Flush();
            w.Close();
        }
    }
}