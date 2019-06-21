using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CaNa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.dBDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Вміст_замовлення". При необходимости она может быть перемещена или удалена.
            this.вміст_замовленняTableAdapter.Fill(this.dBDataSet.Вміст_замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this.dBDataSet.Замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.dBDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.dBDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Книга_продаж". При необходимости она может быть перемещена или удалена.
            this.книга_продажTableAdapter.Fill(this.dBDataSet.Книга_продаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Замовлення_Запрос". При необходимости она может быть перемещена или удалена.
            this.замовлення_ЗапросTableAdapter.Fill(this.dBDataSet.Замовлення_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Вміст_замовлення_Запрос". При необходимости она может быть перемещена или удалена.
            this.вміст_замовлення_ЗапросTableAdapter.Fill(this.dBDataSet.Вміст_замовлення_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Ассортимент". При необходимости она может быть перемещена или удалена.
            this.ассортиментTableAdapter.Fill(this.dBDataSet.Ассортимент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Комоди". При необходимости она может быть перемещена или удалена.
            this.комодиTableAdapter.Fill(this.dBDataSet.Комоди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Шафи". При необходимости она может быть перемещена или удалена.
            this.шафиTableAdapter.Fill(this.dBDataSet.Шафи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Ліжка". При необходимости она может быть перемещена или удалена.
            this.ліжкаTableAdapter.Fill(this.dBDataSet.Ліжка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Крісла". При необходимости она может быть перемещена или удалена.
            this.кріслаTableAdapter.Fill(this.dBDataSet.Крісла);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Крісла". При необходимости она может быть перемещена или удалена.
            this.кріслаTableAdapter.Fill(this.dBDataSet.Крісла);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Дивани". При необходимости она может быть перемещена или удалена.
            this.диваниTableAdapter.Fill(this.dBDataSet.Дивани);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
        }

        private void диваниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            Divan divan = new Divan();
            divan.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void кріслаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = true;
        }

        private void ліжкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void шафиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox4.Visible = true;
        }

        private void комодиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
        }

        private void оновитиБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.ассортиментBindingSource.EndEdit();
                this.ассортиментTableAdapter.Update(this.dBDataSet.Ассортимент);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox7.Visible = true;
        }

        private void покупціToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox8.Visible = true;
        }

        private void базаЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox9.Visible = true;
        }

        private void книгаПродажToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox10.Visible = true;
        }

        private void статистикаПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = true;
        }

        private void статистикаАсортиментаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox12.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox11.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox10.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = false;
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            groupBox12.Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void диваниBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void замовленняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Update N = new Update();
            N.ShowDialog();

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void запитНаПереглядToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator7_RefreshItems(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ассортиментTableAdapter.FillBy(this.dBDataSet.Ассортимент);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ЗапитНаПереглядПрибуткуЗаРікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            
                
        }
    }
}
