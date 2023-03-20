using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_Pythagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berechne_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_kath_a.Text)) // Textbox A leer
                {
                    double kathB = Convert.ToDouble(textBox_kath_b.Text);
                    double hypoC = Convert.ToDouble(textBox_hypo_c.Text);

                    double kathA = Math.Pow(kathB, 2) + Math.Pow(hypoC, 2);

                    textBox_kath_a.Text = kathA.ToString();
                }
                if (String.IsNullOrEmpty(textBox_kath_b.Text)) // Textbox B leer
                {
                    double kathA = Convert.ToDouble(textBox_kath_a.Text);
                    double hypoC = Convert.ToDouble(textBox_hypo_c.Text);
                    double kathB = Math.Pow(kathA, 2) + Math.Pow(hypoC, 2);

                    textBox_kath_b.Text = kathB.ToString();
                }
                if (String.IsNullOrEmpty(textBox_hypo_c.Text)) // Textbox C leer
                {
                    double kathA = Convert.ToDouble(textBox_kath_a.Text);
                    double kathB = Convert.ToDouble(textBox_kath_b.Text);
                    double hypoC = Math.Pow(kathA, 2) + Math.Pow(kathB, 2);

                    textBox_hypo_c.Text = hypoC.ToString();
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Bitte nur zwei Felder füllen.");
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Bitte geben Sie mindestens zwei Werte in Zentimetern an.", "Fehler");
            }

            

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (textBox_kath_a.Text != string.Empty || textBox_kath_b.Text != string.Empty || textBox_hypo_c.Text != string.Empty)
            {
                textBox_kath_a.Text = "";
                textBox_kath_b.Text = "";
                textBox_hypo_c.Text = "";
            }
        }

    }
}
