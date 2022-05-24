using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimmimarisi
{
    public partial class Options : MaterialForm
    {
        private readonly TravelInfo info;

        public Options(TravelInfo info)
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
            this.info = info;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TravelFactory factory = null;
            if (rb_otobus.Checked && rb_otel.Checked)
                factory = new BusHotelFactory();
            if (rb_ucak.Checked && rb_otel.Checked)
                factory = new PlaneHotelFactory();
            if (rb_otobus.Checked && rb_cadir.Checked)
                factory = new BusTentFactory();
            if (rb_ucak.Checked && rb_cadir.Checked)
                factory = new PlaneTentFactory();
            if (factory == null)
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
                return;
            }
            factory.TravelService = new TravelService();
            factory.TravelInfo = info;  
            Transportation transportation = factory.CreateTransportation();
            Accomodation accomodation = factory.CreateAccomodation();
        }
    }
}
