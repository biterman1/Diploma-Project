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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this.dBDataSet.Замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Ассортимент". При необходимости она может быть перемещена или удалена.
            this.ассортиментTableAdapter.Fill(this.dBDataSet.Ассортимент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet1.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.dBDataSet1.Тип_товара);


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
