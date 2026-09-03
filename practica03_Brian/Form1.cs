using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica03_Brian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbcelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtkelvin.Clear();
            txtcelsius.Clear();
            txtfahrenheit.Clear();

            rbCelsius.Checked = false;
            rbFahrenheit.Checked = false;
            rbKelvin.Checked = false;
            txtkelvin.Enabled = true;
            txtfahrenheit.Enabled = true;
            txtcelsius.Enabled = true;

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtcelsius.Text != "" || txtfahrenheit.Text != "" || txtkelvin.Text != "")
            {
                if (!string.IsNullOrEmpty(txtcelsius.Text))
                {
                    if (rbCelsius.Checked)
                    {
                        txtfahrenheit.Enabled = false;
                        txtkelvin.Enabled = false;
                    }
                    float Ce = float.Parse(txtcelsius.Text); float fa = (Ce * 9f / 5f) + 32; float ke = Ce + 273;
                    txtfahrenheit.Text = fa.ToString(); txtkelvin.Text = ke.ToString();
                }
                else if (!string.IsNullOrEmpty(txtfahrenheit.Text))
                {
                    if (rbFahrenheit.Checked)
                    {
                        txtcelsius.Enabled = false; txtkelvin.Enabled = false;
                    }
                    float fa = float.Parse(txtfahrenheit.Text); float ce = (fa - 32) * 5.0f / 9.0f; float ke = ce + 273; txtcelsius.Text = ce.ToString(); txtkelvin.Text = ke.ToString();
                }
                else if (!string.IsNullOrEmpty(txtkelvin.Text))
                {
                    if (rbKelvin.Checked)
                    {
                        txtfahrenheit.Enabled = false;
                        txtcelsius.Enabled = false;
                    }
                    float ke = float.Parse(txtkelvin.Text);
                    float ce = ke - 273;
                    float fa = (ce * 9f / 5f) + 32;
                    txtfahrenheit.Text = fa.ToString();
                    txtcelsius.Text = ce.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numericos para el calculo de temperatura", "Error de valores", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

    }
}
