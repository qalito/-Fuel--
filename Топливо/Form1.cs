using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Топливо
{
    public partial class Form1 : Form
    {
        int vid = 0;
        double Ras = 1;
        double Sto = 1;
        double Rash = 1;
        bool Ch = false;
        public bool allax = false;
        public string halay;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = vid;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                Rash = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                textBox2.Text = textBox2.Text.Replace(".", ",");

            }
            catch (Exception ex)
            {

            }
            try
            {
                Rash = Convert.ToDouble(textBox2.Text.Replace(" ", ""));
                textBox2.Text = textBox2.Text.Replace(" ", "");

            }
            catch (Exception ex)
            {

            }
            try
            {
                while ((textBox1.Text[textBox1.Text.Length - 1] == ',') || (textBox1.Text[textBox1.Text.Length - 1] == '.'))
                {

                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
                Ras = Convert.ToDouble(textBox1.Text.Remove(textBox1.Text.Length - 1));
            }
            catch (Exception ex)
            {

            }
            try
            {
                while ((textBox2.Text[textBox2.Text.Length - 1] == ',') || (textBox2.Text[textBox2.Text.Length - 1] == '.'))
                {

                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);


                }
                Rash = Convert.ToDouble(textBox2.Text.Remove(textBox2.Text.Length - 1));
            }
            catch (Exception ex)
            {

            }
            try
            {
                while ((textBox2.Text[0] == '0') && (textBox2.Text.Length > 1) && (textBox2.Text[1] != ',') && (textBox2.Text[1] != '.'))
                {
                    Rash = Convert.ToDouble(textBox2.Text.Substring(1));
                    textBox2.Text = textBox2.Text.Substring(1);
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                while ((textBox1.Text[0] == '0') && (textBox1.Text.Length > 1) && (textBox1.Text[1] != ',') && (textBox1.Text[1] != '.'))

                {
                    Ras = Convert.ToDouble(textBox1.Text.Substring(1));
                    textBox1.Text = textBox1.Text.Substring(1);
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                Ras = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                textBox1.Text = textBox1.Text.Replace(".", ",");
            }
            catch (Exception ex)
            {

            }
            try
            {
                Ras = Convert.ToDouble(textBox1.Text.Replace(" ", ""));
                textBox1.Text = textBox1.Text.Replace(" ", "");
            }
            catch (Exception ex)
            {

            }
            bool f = false;
            allax = true;
            try
            {
                Rash = Convert.ToDouble(textBox2.Text);
                Ras = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректно введённые данные!\nВсе поля должны быть корректно заполнены!\nПовторите попытку!", "Ошибка!", MessageBoxButtons.OK);


                checkBox1.Checked = false;
                comboBox1.SelectedIndex = 0;
                allax = false;

            }

            if ((Ras == 0) || (Rash == 0) || (Ras < 0) || (Rash < 0)) { MessageBox.Show("Неккоректно введённые данные!\n Введённые значения должны быть больше 0!", "Ошибка!", MessageBoxButtons.OK); }
            else if (allax == true)
            {
                int tudaobr = 1;
                if (checkBox1.Checked) { tudaobr = 2; }
                if (((Ras / 100) * Sto * Rash * tudaobr) > 0.01)
                {
                    halay = Convert.ToString(Math.Round(((Ras / 100) * Sto * Rash * tudaobr), 2));
                }
                else halay = Convert.ToString(((Ras / 100) * Sto * Rash * tudaobr));

                label1.Text = "Необходимое сумма для совершения поездки - " + halay + "BYN";

            }




            try
            {
                while ((textBox2.Text[0] == ',') && (Convert.ToInt32(textBox2.Text[1]) >= 0) || (Convert.ToInt32(textBox2.Text[1]) <= 0))
                {
                    textBox2.Text = "0" + textBox2.Text;
                    Rash = Convert.ToDouble("0" + textBox2.Text);

                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                while ((textBox1.Text[0] == ',') && (Convert.ToInt32(textBox1.Text[1]) >= 0) || (Convert.ToInt32(textBox1.Text[1]) <= 0))
                {
                    textBox1.Text = "0" + textBox1.Text;
                    Ras = Convert.ToDouble("0" + textBox1.Text);

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        vid = 0; Sto = 1.48;

                    }
                    break;

                case 1:
                    {
                        vid = 1; Sto = 1.59;
                    }
                    break;

                case 2:
                    {
                        vid = 2; Sto = 1.59;
                    }
                    break;

                case 3:
                    {
                        vid = 3; Sto = 0.85;
                    }
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox1.Focus();
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }

        }
    }
}
