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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace curencyconverter
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            apihelper.initclt();
        }

  
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {

        }

        private void convertir_Click(object sender, RoutedEventArgs e)
        {
            loadlbl(cmbdepuis.SelectedValue.ToString(), cmbvers.SelectedValue.ToString(), int.Parse(crncytxt.Text));
        }
        
        private async Task loadlbl(string a, string b, int c)
        {
            var price1 = await curencyprossessor.loadprice(a,b,c);
            lblcrncy.Content = price1.price.ToString();
          
        }

        private void rfrsh_Click(object sender, RoutedEventArgs e)
        {
            lblcrncy.Content = "";
            crncytxt.Text = "0";

        }

        private void wpfform_Loaded(object sender, RoutedEventArgs e)
        {
            string btc = "btc-bitcoin";
            string eur = "eur-euro-token";
            string neur = "ncc-neurochain";
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom");
            dt.Columns.Add("ID");
            dt.Rows.Add("select",0);
            dt.Rows.Add("Bitcoin", btc);
            dt.Rows.Add("Euro", eur);
            dt.Rows.Add("Neurochain", neur);
            cmbdepuis.ItemsSource = dt.DefaultView;
            cmbdepuis.DisplayMemberPath = "Nom";
            cmbdepuis.SelectedValuePath = "ID";
            string usd = "usd-us-dollars";
            string euth = "eth-ethereum";
            string xrp = "xrp-xrp";
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Nom");
            dt2.Columns.Add("ID");
            dt2.Rows.Add("select", 0);
            dt2.Rows.Add("USD", usd);
            dt2.Rows.Add("Ethereum", euth);
            dt2.Rows.Add("XRP", xrp);
            cmbvers.ItemsSource = dt2.DefaultView;
            cmbvers.DisplayMemberPath = "Nom";
            cmbvers.SelectedValuePath = "ID";

        }
    }
}
