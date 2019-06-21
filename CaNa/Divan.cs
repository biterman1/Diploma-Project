using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaNa
{
    public partial class Divan : Form
    {
        public Divan()
        {
            InitializeComponent();
        }
        private void Divan_Load(object sender, EventArgs e)
        {
            this.диваниTableAdapter1.Fill(this.dBDataSet.Дивани);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.диваниTableAdapter1.FillBy(this.dBDataSet.Дивани);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
