﻿using MaterialSkin.Controls;
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
        public Options()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }


    }
}