using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Получение выбранной даты
            DateTime selectedDate = dateTimePicker1.Value;

            // Проверка, какой RadioButton выбран
            if (radioButton1.Checked)
            {
                // Формат "дд/мм/гггг"
                label1.Text = selectedDate.ToString("dd/MM/yyyy");
            }
            else if (radioButton2.Checked)
            {
                // Формат "дд месяц гггг"
                label1.Text = selectedDate.ToString("dd MMMM yyyy");
            }
            else if (radioButton3.Checked)
            {
                // Формат "дд-е число месяца гггг-го года"
                label1.Text = selectedDate.ToString("dd-е число MMMM yyyy-го года");
            }
        }
    }
}