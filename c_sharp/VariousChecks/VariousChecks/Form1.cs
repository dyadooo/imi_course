﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VariousChecks
{
    public partial class Form1 : Form
    {

        private string getDescription(string Type)
        {
            try
            {
                StreamReader sr = new StreamReader(Type);
                string description = sr.ReadToEnd();
                sr.Close();
                return description;
            }
            catch(Exception ex)
                {
                return "ERROR: "+ex.Message;
                }
        }
        public bool isLNF(string egn)
        {
            string strRegex = @"^[0-9]{10}$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(egn)) return false;
            int[] weights = { 21, 19, 17, 13, 11, 9, 7, 3, 1 };
            int[] digits = new int[10];
            int tenth = 0;
            digits = egn.Select(x => int.Parse(x.ToString())).ToArray();
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += digits[i] * weights[i];
            }
            tenth = sum % 10;
            if (tenth != digits[9])
            {
                return false;
            }
            return true;
        }

        public bool isEGN(string egn)
        {
            string strRegex = @"^[0-9]{10}$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(egn)) return false;
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int[] digits = new int[10];
            int tenth = 0;
            int sum = 0;
            digits = egn.Select(x => int.Parse(x.ToString())).ToArray();
            for (int i = 0; i < 9; i++)
            {
                sum += digits[i] * weights[i];
            }
            int t = sum % 11;
            if (t != 10)
            {
                tenth = t;
            }
            else
            {
                tenth = 0;
            }
            if (tenth != digits[9])
            {
                return false;
            }
            return true;
        }

        public bool isEIK9(string eik)
        {
            string strRegex = @"^[0-9]{9}$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(eik)) return false;
            int[] weights = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] second_weights = { 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] digits = new int[9];
            int ninth = 0;
            int sum = 0;
            digits = eik.Select(x => int.Parse(x.ToString())).ToArray();
            for (int i = 0; i < 8; i++)
            {
                sum += digits[i] * weights[i];
            }
            int t = sum % 11;
            if (t != 10)
            {
                ninth = t;
            }
            else
            {
                sum = 0;
                for (int i = 0; i < 8; i++)
                {
                    sum += digits[i] * second_weights[i];
                }
                t = sum % 11;
                if (t != 10)
                {
                    ninth = t;
                }
                else
                {
                    ninth = 0;
                }
            }
            if (ninth != digits[8])
            {
                return false;
            }
            return true;
        }

        public bool isEIK13(string eik)
        {
            string strRegex = @"^[0-9]{13}$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(eik)) return false;
            if (!isEIK9(eik.Substring(0, 9)))
            {
                return false;
            }
            if (!re.IsMatch(eik)) return false;
            int[] weights = { 2, 7, 3, 5 };
            int[] second_weights = { 4, 9, 5, 7 };
            int[] digits = new int[13];
            int thirtteenth = 0;
            digits = eik.Select(x => int.Parse(x.ToString())).ToArray();
            int sum = 0;
            for (int i = 9; i < 13; i++)
            {
                sum += digits[i] * weights[i];
            }
            int t = sum % 11;
            if (t != 10)
            {
                thirtteenth = t;
            }
            else
            {
                sum = 0;
                for (int i = 9; i < 13; i++)
                {
                    sum += digits[i] * weights[i];
                }
                t = sum % 11;
                if (t != 10)
                {
                    thirtteenth = t;
                }
                else
                {
                    thirtteenth = 0;
                }
            }
            if (thirtteenth != digits[12])
            {
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            pictureBoxResult.Visible = false;
            textBoxDescription.Text = getDescription("EGN.txt");
        }

        private void buttonCHECK_Click(object sender, EventArgs e)
        {
            bool result = false;
            string item = textBoxItem.Text;
            RadioButton CheckedButton = groupBoxItems.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            switch (CheckedButton.Text)
            {
                case "ЕГН":
                    result = isEGN(item);
                    break;
                case "ЕИК9":
                    result = isEIK9(item);
                    break;
                case "ЕИК13":
                    result = isEIK13(item);
                    break;
                case "ЛНЧ":
                    result = isLNF(item);
                    break;
                default:
                    break;
            }
            if (result)
            {
                pictureBoxResult.Visible = true;
                pictureBoxResult.ImageLocation = "OK.png";
            }
            else
            {
                pictureBoxResult.Visible = true;
                pictureBoxResult.ImageLocation = "NOK.png";
            }
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonEGN_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            textBoxDescription.Text = getDescription("EGN.txt");  
        }

        private void radioButtonEIK9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            textBoxDescription.Text = getDescription("EIK9.txt");
        }

        private void radioButtonEIK13_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            textBoxDescription.Text = getDescription("EIK13.txt");
        }

        private void radioButtonLNF_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            textBoxDescription.Text = getDescription("LNF.txt");
        }
    }
}
