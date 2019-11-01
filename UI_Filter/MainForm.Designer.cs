namespace UI_Filter
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.origin = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.filterList = new System.Windows.Forms.ListBox();
            this.wishList = new System.Windows.Forms.ListBox();
            this.init = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toggle = new System.Windows.Forms.CheckBox();
            this.apply = new System.Windows.Forms.Button();
            this.loadPic = new System.Windows.Forms.Button();
            this.direction = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.PictureBox();
            this.settingTip = new System.Windows.Forms.ToolTip(this.components);
            this.filter_txt = new System.Windows.Forms.Label();
            this.wish_txt = new System.Windows.Forms.Label();
            this.togetherTip = new System.Windows.Forms.ToolTip(this.components);
            this.compare = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            this.SuspendLayout();
            // 
            // origin
            // 
            this.origin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin.Location = new System.Drawing.Point(55, 519);
            this.origin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(91, 45);
            this.origin.TabIndex = 0;
            this.origin.Text = "Origin";
            this.origin.UseVisualStyleBackColor = true;
            this.origin.Click += new System.EventHandler(this.origin_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(190, 519);
            this.output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(91, 45);
            this.output.TabIndex = 1;
            this.output.Text = "Output";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // filterList
            // 
            this.filterList.AllowDrop = true;
            this.filterList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterList.FormattingEnabled = true;
            this.filterList.ItemHeight = 23;
            this.filterList.Items.AddRange(new object[] {
            "Canny",
            "Gaussian",
            "Sharpening",
            "Median",
            "Sobel",
            "Laplacian",
            "Flip"});
            this.filterList.Location = new System.Drawing.Point(527, 72);
            this.filterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(108, 395);
            this.filterList.TabIndex = 2;
            this.filterList.DragDrop += new System.Windows.Forms.DragEventHandler(this.filterList_DragDrop);
            this.filterList.DragEnter += new System.Windows.Forms.DragEventHandler(this.filterList_DragEnter);
            this.filterList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filterList_MouseDown);
            // 
            // wishList
            // 
            this.wishList.AllowDrop = true;
            this.wishList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishList.FormattingEnabled = true;
            this.wishList.ItemHeight = 23;
            this.wishList.Location = new System.Drawing.Point(707, 72);
            this.wishList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(108, 395);
            this.wishList.TabIndex = 3;
            this.wishList.DragDrop += new System.Windows.Forms.DragEventHandler(this.wishList_DragDrop);
            this.wishList.DragEnter += new System.Windows.Forms.DragEventHandler(this.wishList_DragEnter);
            this.wishList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wishList_MouseDown);
            // 
            // init
            // 
            this.init.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(354, 516);
            this.init.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(114, 48);
            this.init.TabIndex = 4;
            this.init.Text = "InitData";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(527, 516);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 48);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(53, 72);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(416, 410);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.BackColor = System.Drawing.Color.Transparent;
            this.toggle.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle.Location = new System.Drawing.Point(53, 24);
            this.toggle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(106, 30);
            this.toggle.TabIndex = 7;
            this.toggle.Text = "Toggle";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toggle_MouseClick);
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(707, 516);
            this.apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(109, 48);
            this.apply.TabIndex = 9;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // loadPic
            // 
            this.loadPic.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPic.Location = new System.Drawing.Point(354, 15);
            this.loadPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadPic.Name = "loadPic";
            this.loadPic.Size = new System.Drawing.Size(114, 48);
            this.loadPic.TabIndex = 11;
            this.loadPic.Text = "LoadPic";
            this.loadPic.UseVisualStyleBackColor = true;
            this.loadPic.Click += new System.EventHandler(this.loadPic_Click);
            // 
            // direction
            // 
            this.direction.BackColor = System.Drawing.Color.Transparent;
            this.direction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.direction.Image = ((System.Drawing.Image)(resources.GetObject("direction.Image")));
            this.direction.Location = new System.Drawing.Point(642, 236);
            this.direction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(58, 55);
            this.direction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.direction.TabIndex = 12;
            this.direction.TabStop = false;
            this.direction.Click += new System.EventHandler(this.direction_Click);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.Transparent;
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(654, 145);
            this.setting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(34, 38);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setting.TabIndex = 13;
            this.setting.TabStop = false;
            this.setting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setting_MouseClick);
            this.setting.MouseLeave += new System.EventHandler(this.setting_MouseLeave);
            this.setting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setting_MouseMove);
            // 
            // filter_txt
            // 
            this.filter_txt.AutoSize = true;
            this.filter_txt.BackColor = System.Drawing.Color.Transparent;
            this.filter_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_txt.Location = new System.Drawing.Point(510, 30);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(153, 23);
            this.filter_txt.TabIndex = 14;
            this.filter_txt.Text = "[Filter List]";
            // 
            // wish_txt
            // 
            this.wish_txt.AutoSize = true;
            this.wish_txt.BackColor = System.Drawing.Color.Transparent;
            this.wish_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wish_txt.Location = new System.Drawing.Point(687, 30);
            this.wish_txt.Name = "wish_txt";
            this.wish_txt.Size = new System.Drawing.Size(164, 23);
            this.wish_txt.TabIndex = 15;
            this.wish_txt.Text = "[Wish Filters]";
            // 
            // compare
            // 
            this.compare.AutoSize = true;
            this.compare.BackColor = System.Drawing.Color.Transparent;
            this.compare.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.compare.Location = new System.Drawing.Point(177, 24);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(118, 30);
            this.compare.TabIndex = 17;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = false;
            this.compare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.compare_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(863, 599);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.wish_txt);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.loadPic);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.init);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.filterList);
            this.Controls.Add(this.output);
            this.Controls.Add(this.origin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter_UI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button origin;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.ListBox filterList;
        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox toggle;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button loadPic;
        private System.Windows.Forms.PictureBox direction;
        private System.Windows.Forms.PictureBox setting;
        private System.Windows.Forms.ToolTip settingTip;
        private System.Windows.Forms.Label filter_txt;
        private System.Windows.Forms.Label wish_txt;
        private System.Windows.Forms.ToolTip togetherTip;
        private System.Windows.Forms.CheckBox compare;
    }
}

