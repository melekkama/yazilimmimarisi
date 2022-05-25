using MaterialSkin.Controls;
using Newtonsoft.Json;
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
            //Gidiş 
            TravelFactory factory = null;
            if (rb_gidis_otobus.Checked && rb_otel.Checked)
                factory = new BusHotelFactory();
            if (rb_gidis_ucak.Checked && rb_otel.Checked)
                factory = new PlaneHotelFactory();
            if (rb_gidis_otobus.Checked && rb_cadir.Checked)
                factory = new BusTentFactory();
            if (rb_gidis_ucak.Checked && rb_cadir.Checked)
                factory = new PlaneTentFactory();
            if (factory == null)
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
                return;
            }
            factory.TravelService = new TravelService();
            factory.TravelInfo = info;
            Transportation transportationGo = factory.CreateTransportation();
            Accomodation accomodation = factory.CreateAccomodation();

            //Dönüş

            if (rb_donus_otobus.Checked)
                factory = new BusHotelFactory();
            if (rb_donus_ucak.Checked)
                factory = new PlaneHotelFactory();
            factory.TravelInfo = info.Reverse();
            factory.TravelService= new TravelService();
            Transportation transportationBack = factory.CreateTransportation();

            Transportations transportations = new Transportations()
            {
                Departure = transportationGo,
                Return = transportationBack
            };

            Profile profile = new Profile(transportations, accomodation, info);
            this.Hide();
            profile.ShowDialog();
            this.Close();
            //var obj = new
            //{
            //    transportation,
            //    accomodation
            //};
            //var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
