﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(textBox1.Text=="COTIL")
            {
                label1.Text = "Acertou!";
            }
            
            else
            
            {
                label1.Text = "Errouuu!";
            }*/
            
           switch(textBox1.Text)
            {
                case "COTIL":
                    label1.Text = "Acertou: COTIL!";
                    break;
                case "UNICAMP":
                    label1.Text = "Acertou: UNICAMP!";
                    break;
                default:
                    label1.Text = " Escreveu " + textBox1.Text;
                    break;

            }
        }

        


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
