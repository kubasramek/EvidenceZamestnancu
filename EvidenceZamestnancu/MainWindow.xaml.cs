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

namespace EvidenceZamestnancu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OknoPridani oknoPridani = new OknoPridani();
            oknoPridani.ShowDialog();

            if(oknoPridani.DialogResult == true)
            {
                var novyZamestnanec = new Zamestnanec
                {
                    ID = oknoPridani.Id,
                    Jmeno = oknoPridani.Jmeno,
                    Prijmeni = oknoPridani.Prijmeni,
                    DatNarozeni = oknoPridani.DatumN
                };
                Seznam.Items.Add(novyZamestnanec);
            }
        }
    }
}
