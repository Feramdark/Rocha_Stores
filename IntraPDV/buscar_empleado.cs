﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntraPDV
{
    public partial class buscar_empleado : Form
    {
        public buscar_empleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buscar_empleado_Load(object sender, EventArgs e)
        {
            

        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
        }
    }
}
