﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    internal static class TextBoxBaseController
    {
        static internal void AllTextBoxBaseOnFormClear(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBoxBase tbb)
                {
                    tbb.Text = null;
                }
            }
        }
        static internal bool checkTextBoxBaseTextOnNull(TextBoxBase textBoxBase)
        {//check properties for null and by RegexController

            if (textBoxBase.Text != null)
            {
                if (textBoxBase.Text.Length > 75)
                {
                    MessageBox.Show($"{textBoxBase.Name} cannot be more than 75 symbols");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("fill in the empty requiered(*) fields");
                return true;
            }
        }
    }
}
