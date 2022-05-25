using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace yazilimmimarisi
{
    public partial class Profile : MaterialForm
    {
        private readonly Transportations transportations;
        private readonly Accomodation accomodation;
        private readonly TravelInfo info;

        public Profile(Transportations transportations, Accomodation accomodation,TravelInfo info)
        {
            this.transportations = transportations;
            this.accomodation = accomodation;
            this.info = info;
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                FirstName = tb_firstName.Text,
                LastName = tb_lastName.Text,
                IdentityNumber = tb_tc.Text,
                PhoneNumber = tb_telNo.Text,
                Email = tb_email.Text
            };

            var reservation = new Reservation()
            {
                User = user,
                TravelInfo = info,
                Accomodation = accomodation,
                Transportations=transportations
            };

            Database.Reservations.Add(reservation);
            MessageBox.Show("Rezervasyonunuz başarıyla kaydedildi.");
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            var reservation = Database.Reservations.FirstOrDefault();
            if (reservation == null)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktop, "report.json");
            var json = JsonConvert.SerializeObject(reservation,Formatting.Indented);
            File.WriteAllText(reportPath, json);
            MessageBox.Show("Rapor Masaüstüne oluşturuldu");
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            var reservation = Database.Reservations.FirstOrDefault();
            if (reservation == null)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }

            XmlSerializer MySerializer = new XmlSerializer(typeof(Reservation));
            TextWriter TW = new StringWriter();
            MySerializer.Serialize(TW, reservation);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktop, "report.xml");
            File.WriteAllText(reportPath, TW.ToString());
            MessageBox.Show("Rapor Masaüstüne oluşturuldu");
        }
    }
}
