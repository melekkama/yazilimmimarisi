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
    public partial class Profile : MaterialForm
    {
        public Profile()
        {
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
            Database.Users.Add(user);

        }
    }
}
