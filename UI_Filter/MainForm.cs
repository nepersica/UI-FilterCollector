using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Console;    // like <iostream>
using OpenCvSharp;              // OpenCV 라이브러리.


namespace UI_Filter
{
    public partial class MainForm : Form   // Partial class : 하나의 클래스를 2개 이상의 파일에 나누어 정의할 수 있음.
    {
        enum Picbox_state
        {
            NONE, ORIGINAL, OUTPUT
        }

        Data data = new Data();
        Data_th th_data = new Data_th();
        Filter filter = new Filter();
        Line_DragnDrop line = new Line_DragnDrop();
        Picbox_state state = Picbox_state.NONE;
        Thread toggle_thread = null;


        int previousPoint = 182;

        public MainForm()
        {
            InitializeComponent();
            output.Hide(); origin.Hide();
            filterList.AllowDrop = true; wishList.AllowDrop = true;
            wishList.AllowDrop = true; filterList.AllowDrop = true;
        }

        // origin button
        private void origin_Click(object sender, EventArgs e)
        {
            Toggle_stop();
            compare_stop();

            pictureBox.BackgroundImage = data.Get_Orgpic();
            state = Picbox_state.ORIGINAL;
        }

        // output button
        private void output_Click(object sender, EventArgs e)
        {
            if (IsAplDataNull() != true)
            {
                Toggle_stop();
                compare_stop();

                if (toggle.Checked == false)
                {
                    if (toggle_thread != null)
                        toggle_thread.Join();
                }
                pictureBox.BackgroundImage = data.Get_Aplpic();
                state = Picbox_state.OUTPUT;
            }
            else
            {
                toggle.Checked = false;
            }
        }

        // load button
        private void loadPic_Click(object sender, EventArgs e)
        {
            string file_path = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\A\Desktop\Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file_path = ofd.FileName;   // 선택된 파일의 풀 경로를 저장.
                Toggle_stop();
                compare_stop();
            }
            else
                return;

            Mat selected_pic;
            selected_pic = Cv2.ImRead(@file_path);

            Bitmap pic_bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(selected_pic);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.BackgroundImage = pic_bitmap;
            state = Picbox_state.ORIGINAL;

            data.Set_Orgpic(pic_bitmap);
            data.Set_Aplpic(null);

            output.Show(); origin.Show();

            th_data.Initialize();
        }

        // initPic button
        private void init_Click(object sender, EventArgs e)
        {
            data.Set_Orgpic(null); data.Set_Aplpic(null);
            pictureBox.BackgroundImage = null;
            state = Picbox_state.NONE;
            Empty_wishList();
            output.Hide(); origin.Hide();
            toggle.Checked = false;
            compare.Checked = false;
            th_data.Initialize();
        }

        // reset button 
        private void Reset_Click(object sender, EventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }

            Empty_wishList();
        }

        private void Empty_wishList()
        {
            foreach (string filter in data.Get_List())
            {
                if (!filterList.Items.Contains(filter))
                {
                    filterList.Items.Add(filter);
                    wishList.Items.Remove(filter);
                }
            }
            //data.Init_List();
        }

        // apply button
        private void apply_Click(object sender, EventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }
            if (data.Get_List()?.Any() != true)
            { MessageBox.Show("   필터 목록이 비어있습니다.   \n   필터를 선택해주세요.   "); }
            Bitmap pic = filter.Applied_Filters(data);
            if (compare.Checked == true)
            {
                pictureBox.BackgroundImage = line.Redrawing(data.Get_Orgpic(), pic);
            }
            else
            {
                pictureBox.BackgroundImage = pic;
            }
            state = Picbox_state.OUTPUT; 
            data.Set_Aplpic(pic);
        }

        // toggle check
        private void toggle_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsAplDataNull() != true)
            {
                if (data.IsOrgpicNull() == true)
                    toggle.Checked = false;

                if (toggle.Checked == false)
                {
                    toggle_thread.Join();
                    toggle_thread = null;
                    pictureBox.BackgroundImage = data.Get_Orgpic();
                }
                else
                {
                    compare.Checked = false;
                    toggle_thread = new Thread(new ThreadStart(Toggling));
                    toggle_thread.Start();
                }
            }
            else
            {
                toggle.Checked = false;
            }
        }

        private void Toggle_stop()      // Original, Output 버튼 누르면 toggle 종료.
        {
            if (toggle.Checked == true)
            {
                toggle.Checked = false;
                pictureBox.BackgroundImage = data.Get_Orgpic();
            }
        }

        private void Toggling()
        {
            while (toggle.Checked == true)
            {
                if (state == Picbox_state.ORIGINAL)
                {
                    pictureBox.BackgroundImage = data.Get_Aplpic();
                    state = Picbox_state.OUTPUT;
                }
                else
                {
                    pictureBox.BackgroundImage = data.Get_Orgpic();
                    state = Picbox_state.ORIGINAL;
                }
                Thread.Sleep(1000);
            }
        }

        private bool IsAplDataNull()
        {
            if (data.Get_Aplpic() == null)
            {
                MessageBox.Show("   필터를 먼저 적용시켜 주세요!   ");
                return true;
            }
            else
                return false;
        }

        // filterList 2 wishList
        private void filterList_MouseDown(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }
            int index = filterList.IndexFromPoint(e.X, e.Y);
            if (index == -1) return;
            if (e.Button == MouseButtons.Right)
            {
                //filter.ControlThreshold
            }
            wishList.DoDragDrop(filterList.SelectedItem.ToString(), DragDropEffects.Copy);
        }
        private void wishList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void wishList_DragDrop(object sender, DragEventArgs e)
        {
            string item = (string)e.Data.GetData(DataFormats.Text);
            if (wishList.Items.Contains(item))
            {
            }
            else
            {
                data.Add_Item(item);
                wishList.Items.Add(item);
                filterList.Items.Remove(item);
            }
        }

        // wishList 2 filterList
        private void wishList_MouseDown(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }
            int index = wishList.IndexFromPoint(e.X, e.Y);
            if (index == -1) return;
            filterList.DoDragDrop(wishList.SelectedItem.ToString(), DragDropEffects.Copy);
        }
        private void filterList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void filterList_DragDrop(object sender, DragEventArgs e)
        {
            string item = (string)e.Data.GetData(DataFormats.Text);
            if (filterList.Items.Contains(item))
            {
            }
            else
            {
                data.Trash_Item(item);
                filterList.Items.Add(item);
                wishList.Items.Remove(item);
            }
        }

        private void direction_Click(object sender, EventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }

            foreach (string item in filterList.Items)
            {
                wishList.Items.Add(item);
                data.Add_Item(item);
            }
            filterList.Items.Clear();
        }

        private void setting_MouseMove(object sender, MouseEventArgs e)
        {
            this.settingTip.ToolTipTitle = "Setting";
            this.settingTip.IsBalloon = true;
            this.settingTip.SetToolTip(this.setting, "Set the Filters' thresholds.");
        }

        private void setting_MouseLeave(object sender, EventArgs e)
        {
            this.settingTip.Hide(this);
        }

        private void setting_MouseClick(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }

            filter.Control_Threshold();
        }

        private void compare_MouseClick(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { compare.Checked = false; }
            if (data.Get_Aplpic() == null)
            {
                MessageBox.Show("   필터를 먼저 적용시켜주세요.   ");
                compare.Checked = false;
            }
            if (compare.Checked == true)
            {
                Toggle_stop();
                pictureBox.BackgroundImage = line.Init_Line(data);
            }
            else
            {
                pictureBox.BackgroundImage = data.Get_Orgpic();
            }
        }

        public bool DraggingFromPicBox = false;

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)  // 마우스 이동
        {
            if (compare.Checked == true)
            {
                if (data.IsOrgpicNull() == true) { return; }
                if (e.Button == MouseButtons.Left)
                {
                    if (Math.Abs(previousPoint - e.Location.X) < 10)
                    {
                        DraggingFromPicBox = true;
                        line.Check_Position(e.Location, pictureBox, data);
                    }                                            
                }
            }
            else { }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (DraggingFromPicBox)
            {
                if (Math.Abs(previousPoint-e.Location.X) < 5)
                    return;

                if (compare.Checked == true)
                {
                    previousPoint = e.Location.X;
                    if (previousPoint < 0)
                    {
                        previousPoint = 0;
                    }
                    else if (previousPoint >= pictureBox.Width)
                    {
                        previousPoint = pictureBox.Width-1;
                    }
                    Bitmap bmp = line.Cal_xCoord(previousPoint / (double)pictureBox.Width, data.Get_Orgpic(), data.Get_Aplpic(), pictureBox);
                    
                    pictureBox.BackgroundImage = bmp;

                    pictureBox.Refresh();                    
                }
            }
            else { }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (DraggingFromPicBox)
            {
                DraggingFromPicBox = false;
            }
        }

        private void compare_stop()
        {
            if (compare.Checked == true)
            {
                compare.Checked = false;
                pictureBox.BackgroundImage = data.Get_Orgpic();
            }
        }


    }
}