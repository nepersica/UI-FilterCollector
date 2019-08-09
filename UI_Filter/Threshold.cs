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
    public partial class Threshold : Form
    {
        Data_th data = new Data_th();
        Checking condition = new Checking();
        Sobel s_th = new Sobel();

        public Threshold()
        {
            InitializeComponent();
            s_th.Set_Data(data);
        }

        public Data_th Get_Data()
        {
            return data;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            data.Set_Cth1(Convert.ToInt32(canny_th1.Text));
            data.Set_Cth2(Convert.ToInt32(canny_th2.Text));
            data.Set_Gkernel(Convert.ToInt32(gauss_kernel.Text));
            data.Set_Gsigma(Convert.ToInt32(gauss_sigma.Text));
            data.Set_Mth(Convert.ToInt32(med_kernel.Text));
            data.Set_Shsigma(Convert.ToInt32(sharp_sigma.Text));
            data.Set_Shth1(Convert.ToDouble(sharp_th1.Text));
            data.Set_Shth2(Convert.ToDouble(sharp_th2.Text));
        }
        
        private void canny_th1_keypress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(canny_th1, e);
        }
        private void canny_th1_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(canny_th1, sender);
        }

        public void Initialize_txt()
        {
            Sobel sb = new Sobel();
            canny_th1.Text = "50"; canny_th2.Text = "150";
            gauss_kernel.Text = "9";    gauss_sigma.Text = "1";
            sharp_sigma.Text = "1"; sharp_th1.Text = "1.5"; sharp_th2.Text = "0.5";
            med_kernel.Text = "3";
            sb.Initialize_sb();
        }

        private void canny_th2_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(canny_th2, e);
        }
        private void canny_th2_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(canny_th2, sender);
        }

        private void gauss_kernel_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(gauss_kernel, e);
        }
        private void gauss_kernel_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(gauss_kernel, sender);
        }

        private void gauss_sigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(gauss_sigma, e);
        }
        private void gauss_sigma_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(gauss_sigma, sender);
        }

        private void sharp_sigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(sharp_sigma, e);
        }
        private void sharp_sigma_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(sharp_sigma, sender);
        }

        private void sharp_th1_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(sharp_th1, e);
        }
        private void sharp_th1_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(sharp_th1, sender);
        }

        private void sharp_th2_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(sharp_th2, e);
        }
        private void sharp_th2_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(sharp_th2, sender);
        }

        private void med_kernel_KeyPress(object sender, KeyPressEventArgs e)
        {
            condition.Check_condition(med_kernel, e);
        }
        private void med_kernel_Leave(object sender, EventArgs e)
        {
            condition.NoneEmpty(med_kernel, sender);
        }

        private void sobel_MouseClick(object sender, MouseEventArgs e)
        {
            s_th.ShowDialog();
            data.Get_Sbx(); data.Get_Sby();
            //s_th.
            //WriteLine();
        }
        // Sobel Tooltip
        private void sobel_MouseMove(object sender, MouseEventArgs e)
        {
            this.sobeltip.ToolTipTitle = "Click!";
            this.sobeltip.IsBalloon = true;
            this.sobeltip.SetToolTip(this.sobel, "Can set the Sobel's thresholds.");
        }

        private void sobel_MouseLeave(object sender, EventArgs e)
        {
            this.sobeltip.Hide(this);
        }

        private void init_Click(object sender, EventArgs e)
        {
            data.Initialize();
            Initialize_txt();
        }

    }
}
