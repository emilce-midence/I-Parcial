﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace I_Parcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal resultado = numero1 + numero2;

            MessageBox.Show("La suma es: " + resultado);
        }
    }
}
