﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    //Student: Gurvir Singh #301108852
    //File: Final Test
    //Course: Programming 2
    //Section: 001

    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
