﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APPR_QuizMester_lj3p1
{
    public partial class Form3 : Form
    {
        private string _username;

        public Form3(string username)
        {
            InitializeComponent();
            _username = username;

        }
    }
}
