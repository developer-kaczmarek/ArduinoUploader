////////////////////////////////////////////////////////////////////
//      Hello, User                                               //
//      Author: Marta Kaczmarek (developer-kaczmarek)             //
//      Web-site to connect: https://vk.com/programmer.kaczmarek  //
//      Arduino Uploader - GUI wrapper for AVRDUDE                //
//      This is my school project. Do not judge strictly.         //
//      05.02.2017                                                //
////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoUploader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.ForeColor = ColorTranslator.FromHtml("#446CB3");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/raccoon_lina");
        }

        
    }
}
