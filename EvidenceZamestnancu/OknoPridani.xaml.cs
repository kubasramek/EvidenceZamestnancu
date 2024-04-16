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

namespace EvidenceZamestnancu
{
    /// <summary>
    /// Interakční logika pro OknoPridani.xaml
    /// </summary>
    public partial class OknoPridani : Window
    {
        public string Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumN { get; set; }
        public Zamestnanec Zamestnanec { get; set; }
        public OknoPridani()
        {
            InitializeComponent();
           
            Id = TBid.Text;
            Jmeno = TBjmeno.Text;
            Prijmeni = TBprijmeni.Text;
            DatumN = Datum.SelectedDate ?? DateTime.Now;
        }
    }
}
