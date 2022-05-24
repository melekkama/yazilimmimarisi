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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            var travelInfo = new TravelInfo
            {
                Dates = new Dates
                {
                    StartTime = dtp_start.Value,
                    EndTime = dtp_end.Value
                },
                Addresses = new Addresses
                {
                    DepartureAddress = new Address() { City = cb_kalkıs.SelectedItem.ToString() },
                    DestinationAddress = new Address() { City = cb_varıs.SelectedItem.ToString() }
                }
            };
            var form = new Options(travelInfo);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
