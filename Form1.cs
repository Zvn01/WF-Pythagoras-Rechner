using System;
using System.Media;
using System.Windows.Forms;


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

                // Hypothenuse C rausfinden

                if (textBox_kath_a.Text != "" && textBox_kath_b.Text != "") 
                {
                    double kathA = Convert.ToDouble(textBox_kath_a.Text);
                    double kathB = Convert.ToDouble(textBox_kath_b.Text);                   
                    double hypoC = Math.Sqrt(kathA * kathA + kathB * kathB);

                    textBox_hypo_c.Text = hypoC.ToString();
                }

                // Kathete B rausfinden

                else if (textBox_kath_a.Text != "" && textBox_hypo_c.Text != "") 
                {
                    double kathA = Convert.ToDouble(textBox_kath_a.Text);
                    double hypoC = Convert.ToDouble(textBox_hypo_c.Text);

                    if (hypoC < kathA)
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Die Hypotenuse C darf nicht kleiner sein als die Kathete B", "Fehler");
                    }
                    else
                    {
                        double kathB = Math.Sqrt(hypoC * hypoC - kathA * kathA);
                        textBox_kath_b.Text = kathB.ToString();
                    }
 
                }

                // Kathete A rausfinden

                else if (textBox_kath_b.Text != "" && textBox_hypo_c.Text != "") 
                {
                    double kathB = Convert.ToDouble(textBox_kath_b.Text);
                    double hypoC = Convert.ToDouble(textBox_hypo_c.Text);
                    if (hypoC < kathB)
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Die Hypotenuse C darf nicht kleiner sein als die Kathete B", "Fehler");
                    }
                    else
                    {
                        double kathA = Math.Sqrt(hypoC * hypoC - kathB * kathB);
                        textBox_kath_a.Text = kathA.ToString();
                    }
                }
    
            }
            catch (Exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Füllen Sie 2 Felder mit Zahlen aus.", "Fehler");
            }

            

        }
      
        // Clear Button
        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (textBox_kath_a.Text != string.Empty || textBox_kath_b.Text != string.Empty || textBox_hypo_c.Text != string.Empty)
            {
                textBox_kath_a.Text = "";
                textBox_kath_b.Text = "";
                textBox_hypo_c.Text = "";
            }
        }

        // Blockieren nicht genutzter Textboxen bei der Berechnung
        private void textBox_kath_a_TextChanged(object sender, EventArgs e)
        {
            if (textBox_kath_a.Text == "")
            {
                textBox_kath_b.Enabled = true;
                textBox_hypo_c.Enabled = true;
            }
            else if (textBox_kath_b.Text != "" && textBox_hypo_c.Text == "")
            {
                textBox_kath_b.Enabled = true;
                textBox_hypo_c.Enabled = false;
            }
            else if (textBox_hypo_c.Text != "" && textBox_kath_b.Text == "")
            {
                textBox_hypo_c.Enabled = true;
                textBox_kath_b.Enabled = false;
            }
        }

        private void textBox_kath_b_TextChanged(object sender, EventArgs e)
        {
            if (textBox_kath_b.Text == "")
            {
                textBox_kath_a.Enabled = true;
                textBox_hypo_c.Enabled = true;
            }
            else if (textBox_hypo_c.Text != "")
            {
                textBox_kath_b.Enabled = false;
                textBox_kath_a.Enabled = true;

            }
            else if (textBox_kath_a.Text != "")
            {
                textBox_kath_b.Enabled = true;
                textBox_hypo_c.Enabled = false;
            }
            else
            {
                textBox_kath_a.Enabled = true;
                textBox_kath_b.Enabled = true;
                textBox_hypo_c.Enabled = true;
            }
        }

        private void textBox_hypo_c_TextChanged(object sender, EventArgs e)
        {
            if (textBox_hypo_c.Text == "")
            {
                textBox_kath_b.Enabled = true;
                textBox_kath_a.Enabled = true;
            }
            else if (textBox_kath_a.Text == "" && textBox_kath_b.Text != "")
            {
                textBox_kath_a.Enabled = false;
                textBox_kath_b.Enabled = true;
            }
            else if (textBox_kath_b.Text == "" && textBox_kath_a.Text != "")
            {
                textBox_kath_a.Enabled = true;
                textBox_kath_b.Enabled = false;
            }
        }
    }
}
