﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();           
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormBrowser browser = new ChildFormBrowser();
            browser.MdiParent = this;
            browser.Show();
        }
    } 
}
