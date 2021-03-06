﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tag_extracter.Functionality;

namespace tag_extracter
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            tb_scanDir.Text = @"c:\music";
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = @"M:\iTunes\iTunes Media\Music";
            fbd.ShowDialog();

            tb_scanDir.Text = fbd.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderCrawler fc = new FolderCrawler();
            var def = fc.crawlDirectories(tb_scanDir.Text, true);
            def.RemoveAll(d => d.numberOfFiles == "0");
            dgv_results.DataSource = def;
        }
    }
}
