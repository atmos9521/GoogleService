﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGoogleExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            get_google_excel_form GetGoogleExcelForm = new get_google_excel_form();
            GetGoogleExcelForm.ShowDialog();
            Application.Exit();
        }

        private void get_google_excel_btn_Click(object sender, EventArgs e)
        {
            get_google_excel_form GetGoogleExcelForm = new get_google_excel_form();
            GetGoogleExcelForm.ShowDialog();
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
