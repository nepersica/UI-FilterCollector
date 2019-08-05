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
        Filter_explain explain = new Filter_explain();
        Picbox_state state = Picbox_state.NONE;
        Thread thread = null;

        public MainForm()
        {
            InitializeComponent();
            output.Hide(); origin.Hide();

        }

        // origin button
        private void origin_Click(object sender, EventArgs e)
        {
            toggle_stop();

            pictureBox.BackgroundImage = data.Get_Orgpic();
            state = Picbox_state.ORIGINAL;
        }

        // output button
        private void output_Click(object sender, EventArgs e)
        {                        
            if (IsAplDataNull() != true)
            {
                toggle_stop();

                if (toggle.Checked == false)
                {
                    if(thread != null)
                        thread.Join();
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
                toggle_stop();
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
        }

        // reset button
        private void reset_Click(object sender, EventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }

            Empty_wishList();
        }

        private void Empty_wishList()
        {
            foreach (string filter in data.Get_List())
            {
                filterList.Items.Add(filter);
                wishList.Items.Remove(filter);
            }
            data.Init_List();
        }

        // apply button
        private void apply_Click(object sender, EventArgs e)
        {
            Applying filter = new Applying();
            if (data.IsOrgpicNull() == true) { return; }
            if (data.Get_List()?.Any() != true)
            { MessageBox.Show("   필터 목록이 비어있습니다.   \n   필터를 선택해주세요.   "); }

            Bitmap pic = filter.Applied_Filters(data);
            pictureBox.BackgroundImage = pic;
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
                    thread.Join();
                    thread = null;
                    pictureBox.BackgroundImage = data.Get_Orgpic();
                }
                else
                {
                    thread = new Thread(new ThreadStart(Toggling));
                    thread.Start();
                }
            }
            else
            {
                toggle.Checked = false;
            }
        }

        //private void toggle_CheckedChanged(object sender, EventArgs e)
        //{
            
        //}

        private void toggle_stop()      // Original, Output 버튼 누르면 toggle 종료.
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

        // Wish List
        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (data.IsOrgpicNull() == true) { return; }
        }

        // Drag and Drop FilterList items to WishList
        private void filterList_MouseDown(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }
            if (filterList.Items.Count == 0) return;
            int index = filterList.IndexFromPoint(e.X, e.Y);
            if (index == -1) return;

            /// 오류~
            string s = filterList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
                filterList.Items.RemoveAt(filterList.IndexFromPoint(e.X, e.Y));
        }

        private void wishList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void wishList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                data.Add_Item(str);
                wishList.Items.Add(str);
            }
            data.Print_List();
            WriteLine();
        }

        // Drag and Drop WishList items to FilterList
        private void wishList_MouseDown(object sender, MouseEventArgs e)
        {
            if (data.IsOrgpicNull() == true) { return; }
            if (wishList.Items.Count == 0) return;
            int index = wishList.IndexFromPoint(e.X, e.Y);
            if (index == -1) return;

            string s = wishList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
                wishList.Items.RemoveAt(wishList.IndexFromPoint(e.X, e.Y));
        }
        private void filterList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void filterList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                data.Trash_Item(str);
                filterList.Items.Add(str);
            }
            data.Print_List();
            WriteLine();
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


    }
}