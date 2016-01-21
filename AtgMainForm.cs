using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TiT.PTS
{
    public partial class AtgMainForm : Form
    {
        private PTS _pts;
        private MainForm _mainForm;

        private AtgControl _atgControl1;
        private AtgControl _atgControl2;
        private AtgControl _atgControl3;
        private AtgControl _atgControl4;

        public AtgMainForm()
        {
            InitializeComponent();
        }

        public AtgMainForm(PTS parent, MainForm mnForm)
        {
            InitializeComponent();
            this.PTS = parent;
            this._mainForm = mnForm;

            foreach (Control ctrl in tableLayoutPanel.Controls)
                if (ctrl is AtgControl)
                    ((AtgControl)(ctrl)).PTS = parent;
        }

        public PTS PTS
        {
            get
            {
                return _pts;
            }
            set
            {
                _pts = value;
            }
        }

        public MainForm MainForm
        {
            get
            {
                return _mainForm;
            }
        }

        public bool AtgHasUniqueID(int AtgID)
        {
            int counter = 0;

            foreach (Control ctrl in tableLayoutPanel.Controls)
                if (ctrl is AtgControl)
                    if (((AtgControl)(ctrl)).AtgID == AtgID)
                        counter++;

            if (counter == 1)
                return true;
            else
                return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtgMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
