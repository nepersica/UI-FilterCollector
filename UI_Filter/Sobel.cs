using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Filter
{
    public partial class Sobel : Form
    {
        Data_th data;
        Checking condition = new Checking();
        string sb_x = "0";  string sb_y = "1";
        public Sobel()
        {
            InitializeComponent();
        }

        public void Set_Data(Data_th th_data)
        {
            this.data = th_data;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            sb_x = sobel_x.Text;
            data.Set_Sbx(Convert.ToInt32(sobel_x.Text));
            sb_y = sobel_y.Text;
            data.Set_Sby(Convert.ToInt32(sobel_y.Text));
        }

        public TextBox Get_Sbx()
        {
            return sobel_x;
        }
        public TextBox Get_Sby()
        {
            return sobel_y;
        }

        public void sobel_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(sobel_x, e);
        }
        private void sobel_x_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(sobel_x, sender);
        }

        private void sobel_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(sobel_y, e);
        }

        private void sobel_y_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(sobel_y, sender);
        }
        
        public void Initialize_sb()
        {
            sobel_x.Text = "0"; sobel_y.Text = "1";
        }

        private void sobel_x_TextChanged(object sender, EventArgs e)
        {
            //this.sobel_x.KeyPress += new EventHandler(sobel_x_KeyPress);
        }
    }
}
