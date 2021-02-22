using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Temperatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isOkayCel = false;
        bool isOkayFah = false;
        bool isOkayKel = false;
        private void txt_Cel_Changed(object sender, EventArgs e)
        {
            if (isOkayCel == true)
            {
                ConvertionFromCelsius();
            }
        }

        private void txt_Fah_Changed(object sender, EventArgs e)
        {
            if (isOkayFah == true)
            {
                ConvertionFromFahrenheit();
            }
            
        }

        private void txt_Kel_Changed(object sender, EventArgs e)
        {
            if(isOkayKel == true)
            {
                ConvertionFromKelvin();
            }
        }
        private void ConvertionFromCelsius()
        {
            textBoxFah.Text = null;
            textBoxKel.Text = null;
            if (textBoxCel.Text.StartsWith("-"))
            {
                try
                {
                    float cel = float.Parse(textBoxCel.Text);
                    float fah = (9f / 5f) * (cel + 32);
                    textBoxFah.Text = fah.ToString();
                    float kel = cel + 273;
                    textBoxKel.Text = kel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("I expect that you entering a negative value, aren't you ?? :D");
                    textBoxFah.Text = null;
                    textBoxKel.Text = null;
                }
            }
            else
            {
                try
                {
                    float cel = float.Parse(textBoxCel.Text);
                    float fah = (9f / 5f) * (cel + 32);
                    textBoxFah.Text = fah.ToString();
                    float kel = cel + 273;
                    textBoxKel.Text = kel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("Please enter a degree as a number...");
                    textBoxCel.Text = null;
                    textBoxFah.Text = null;
                    textBoxKel.Text = null;
                }
            }
        }
        private void ConvertionFromFahrenheit()
        {
            textBoxCel.Text = null;
            textBoxKel.Text = null;
            if (textBoxFah.Text.StartsWith("-"))
            {
                try
                {
                    float fah = float.Parse(textBoxFah.Text);
                    float cel = (5f / 9f) * (fah - 32);
                    textBoxCel.Text = cel.ToString();
                    float kel = (5f / 9f) * (fah - 32) + 273;
                    textBoxKel.Text = kel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("I expect that you entering a negative value, aren't you ?? :D");
                    textBoxCel.Text = null;
                    textBoxKel.Text = null;
                }
            }
            else
            {
                try
                {
                    float fah = float.Parse(textBoxFah.Text);
                    float cel = (5f / 9f) * (fah - 32);
                    textBoxCel.Text = cel.ToString();
                    float kel = (5f / 9f) * (fah - 32) + 273;
                    textBoxKel.Text = kel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("Please enter a degree as a number...");
                    textBoxCel.Text = null;
                    textBoxFah.Text = null;
                    textBoxKel.Text = null;
                }
            }
        }
        private void ConvertionFromKelvin()
        {
            textBoxCel.Text = null;
            textBoxFah.Text = null;
            if(textBoxKel.Text.StartsWith("-"))
            {
                try
                {
                    float kel = float.Parse(textBoxKel.Text);
                    float fah = (9f / 5f) * (kel - 273) + 32;
                    textBoxFah.Text = fah.ToString();
                    float cel = kel - 273;
                    textBoxCel.Text = cel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("I expect that you entering a negative value, aren't you ?? :D");
                    textBoxCel.Text = null;
                    textBoxFah.Text = null;
                }
            }
            else{
                try
                {
                    float kel = float.Parse(textBoxKel.Text);
                    float fah = (9f / 5f) * (kel - 273) + 32;
                    textBoxFah.Text = fah.ToString();
                    float cel = kel - 273;
                    textBoxCel.Text = cel.ToString();
                }
                catch (Exception)
                {
                    lbl_warning.Visible = true;
                    lbl_warning.Text = ("Please enter a degree as a number...");
                    textBoxCel.Text = null;
                    textBoxFah.Text = null;
                    textBoxKel.Text = null;
                }
            }
            
        }

        private void txt_Cel_Click(object sender, EventArgs e)
        {
            isOkayCel = true;
            isOkayFah = false;
            isOkayKel = false;
            textBoxFah.ReadOnly.Equals(true);
            textBoxKel.ReadOnly.Equals(true);
            textBoxFah.Text = null;
            textBoxKel.Text = null;
        }

        private void txt_Fah_Click(object sender, EventArgs e)
        {
            isOkayCel = false;
            isOkayFah = true;
            isOkayKel = false;
            textBoxCel.ReadOnly.Equals(true);
            textBoxKel.ReadOnly.Equals(true);
            textBoxCel.Text = null;
            textBoxKel.Text = null;
        }

        private void txt_Kel_Click(object sender, EventArgs e)
        {
            isOkayCel = false;
            isOkayFah = false;
            isOkayKel = true;
            textBoxCel.ReadOnly.Equals(true);
            textBoxFah.ReadOnly.Equals(true);
            textBoxCel.Text = null;
            textBoxFah.Text = null;
        }
    }
}
