using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace UI_Filter
{
    class Checking
    {
        public bool Check_condition(TextBox textbox, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == 8))   // || e.KeyChar == '.' 
            {
                MessageBox.Show("   숫자만 입력해주세요.   ");
                textbox.Text.Replace(e.KeyChar.ToString(), "");
                return false;
            }
            return true;
        }

        public void NoneEmpty(TextBox textbox, object sender)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                MessageBox.Show("   값을 입력해주세요.   ");
                textbox.Focus();
            }
        }
    }
}
