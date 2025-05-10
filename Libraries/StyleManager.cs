using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DeskEtu
{
    internal class StyleManager
    {
        // Login Screen 
        public static void TextBox_ActivateStyle(TextBox TXT , Color Co)
        {
            if (TXT.Text == TXT.Tag.ToString())
                TXT.Text = "";

            TXT.ForeColor = Color.Black;
            TXT.BackColor = Co;
        }
        public static void TextBox_DeactivateStyle(TextBox TXT)
        {
            if (TXT.Text == "")
                TXT.Text = TXT.Tag.ToString();

            TXT.ForeColor = Color.Gray;
            TXT.BackColor = Color.White;
        }
        public static void TextBox_WhenLeave(TextBox TXT)
        {
            if (TXT.Text == "")
            {
                TXT.Text = TXT.Tag.ToString();
                TXT.ForeColor = Color.Gray;
            }
        }
        public static void Button_ActivateStyle(Button BTN)
        {
            BTN.ForeColor = Color.Black;
        }
        public static void Button_DeactivateStyle(Button BTN)
        {
            BTN.ForeColor = Color.White;
        }

        // List Screen (For the base class)
        public static void ComboBox_ActivateStyle(ComboBox CB)
        {
            if (CB.Text == CB.Tag.ToString())
                CB.Text = "";

            CB.ForeColor = Color.Black;
        }
        public static void ComboBox_DeactivateStyle(ComboBox CB)
        {
            if (CB.Text == "")
                CB.Text = CB.Tag.ToString();

            CB.ForeColor = Color.Gray;
            CB.BackColor = Color.White;
        }

        // List Screens (Derived Classes) - Menu 
        public static void Label_ActivateStyle(Label LBL)
        {
            LBL.ForeColor = Color.FromArgb(41, 146,146);
        }

        public static void Label_DeactivateStyle(Label LBL)
        {
            LBL.ForeColor = Color.FromArgb(0, 102,102);
        }

        public static void LabelChangeBackColor(Label Lbl , Color Co)
        {
            Lbl.BackColor = Co; 
        }
    }
}
