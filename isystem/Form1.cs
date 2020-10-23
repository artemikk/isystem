using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            listBox1.DataSource = студентыBindingSource;
            listBox1.DisplayMember = "Фамилия";
            listBox2.DataSource = студентыBindingSource;
            listBox2.DisplayMember = "Имя";
            listBox3.DataSource = студентыBindingSource;
            listBox3.DisplayMember = "Отчество";
            listBox4.DataSource = студентыBindingSource;
            listBox4.DisplayMember = "Группа";
            listBox5.DataSource = студентыBindingSource;
            listBox5.DisplayMember = "Пол";
            listBox6.DataSource = студентыBindingSource;
            listBox6.DisplayMember = "Дата_рождения";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.databaseDataSet.Преподаватели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.databaseDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Кураторы". При необходимости она может быть перемещена или удалена.
            this.кураторыTableAdapter.Fill(this.databaseDataSet.Кураторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.databaseDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Кураторы". При необходимости она может быть перемещена или удалена.

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
