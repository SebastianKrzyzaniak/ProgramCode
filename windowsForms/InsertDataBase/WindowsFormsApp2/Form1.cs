﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Broker b;
        Person p; 
        public Form1()
        {
            InitializeComponent();
            b = new Broker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Person();
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            b.Insert(p);

        }
    }
}
