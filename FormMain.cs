﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Login
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }


}
