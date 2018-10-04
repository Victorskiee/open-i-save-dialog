using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciąg_arytmetyczny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "1";
            textBox4.Text = "Tutaj pojawią się kolejne wyrazy ciągu arytmetycznego...";
            label5.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ile1 = Convert.ToInt32(textBox3.Text);
                if (ile1 <= 0)
                {
                    MessageBox.Show("Ilość wyrazów ciągu arytmetycznego musi być większa od 0!");
                }
            }

            catch
            {
                ;
            }
            int pierwszy, drugi, ile, suma, roznica, dodatkowa;
            try
            {
                pierwszy = Convert.ToInt32(textBox1.Text);
                drugi = Convert.ToInt32(textBox2.Text);
                ile = Convert.ToInt32(textBox3.Text);

                suma = pierwszy;
                roznica = drugi - pierwszy;
                dodatkowa = roznica;

                textBox4.Text = Convert.ToString(pierwszy);
                string napis = textBox4.Text;

                for (int i = 1; i < ile; i++)
                {
                    suma = suma + pierwszy + roznica;
                    napis = napis + ',' + Convert.ToString(pierwszy + roznica);
                    textBox4.Text = napis;
                    roznica = roznica + dodatkowa;

                }
                textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);

                label5.Text = Convert.ToString(suma);

            }
            
            catch
            {
                MessageBox.Show("Nieprawidłowe dane!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vlo.gda.pl");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem tego programu jest Wiktor " +
                "Krasiński.", "Ciąg arytmetyczny");

        }
    }
}
