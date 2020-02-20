﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01___Exemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campo Obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Visual Studio 20196";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult bolinha = MessageBox.Show("Tem certeza que deseja apertar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (bolinha == System.Windows.Forms.DialogResult.Yes)
                MessageBox.Show(" Apertou Sim ");
            else
                MessageBox.Show(" Apertou Não ");
        }
    }
}
