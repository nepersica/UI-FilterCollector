namespace UI_Filter
{
    partial class Threshold
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Threshold));
            this.init = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.canny = new System.Windows.Forms.Label();
            this.gaussian = new System.Windows.Forms.Label();
            this.sharpening = new System.Windows.Forms.Label();
            this.median = new System.Windows.Forms.Label();
            this.sobel = new System.Windows.Forms.Label();
            this.canny_th1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_thershold1 = new System.Windows.Forms.Label();
            this.c_threshold2 = new System.Windows.Forms.Label();
            this.canny_th2 = new System.Windows.Forms.TextBox();
            this.g_kernelsize = new System.Windows.Forms.Label();
            this.gauss_kernel = new System.Windows.Forms.TextBox();
            this.g_sigma = new System.Windows.Forms.Label();
            this.gauss_sigma = new System.Windows.Forms.TextBox();
            this.s_threshold1 = new System.Windows.Forms.Label();
            this.sharp_th1 = new System.Windows.Forms.TextBox();
            this.s_threshold2 = new System.Windows.Forms.Label();
            this.sharp_th2 = new System.Windows.Forms.TextBox();
            this.s_sigma = new System.Windows.Forms.Label();
            this.sharp_sigma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.med_kernel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sobeltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // init
            // 
            this.init.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(278, 315);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(98, 30);
            this.init.TabIndex = 0;
            this.init.Text = "Initialize";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(179, 315);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(74, 30);
            this.apply.TabIndex = 1;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // canny
            // 
            this.canny.AutoSize = true;
            this.canny.BackColor = System.Drawing.Color.Transparent;
            this.canny.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canny.Location = new System.Drawing.Point(67, 81);
            this.canny.Name = "canny";
            this.canny.Size = new System.Drawing.Size(70, 24);
            this.canny.TabIndex = 2;
            this.canny.Text = "Canny";
            // 
            // gaussian
            // 
            this.gaussian.AutoSize = true;
            this.gaussian.BackColor = System.Drawing.Color.Transparent;
            this.gaussian.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussian.Location = new System.Drawing.Point(48, 141);
            this.gaussian.Name = "gaussian";
            this.gaussian.Size = new System.Drawing.Size(106, 24);
            this.gaussian.TabIndex = 3;
            this.gaussian.Text = "Gaussian";
            // 
            // sharpening
            // 
            this.sharpening.AutoSize = true;
            this.sharpening.BackColor = System.Drawing.Color.Transparent;
            this.sharpening.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharpening.Location = new System.Drawing.Point(39, 201);
            this.sharpening.Name = "sharpening";
            this.sharpening.Size = new System.Drawing.Size(130, 24);
            this.sharpening.TabIndex = 4;
            this.sharpening.Text = "Sharpening";
            // 
            // median
            // 
            this.median.AutoSize = true;
            this.median.BackColor = System.Drawing.Color.Transparent;
            this.median.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.median.Location = new System.Drawing.Point(64, 261);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(82, 24);
            this.median.TabIndex = 5;
            this.median.Text = "Median";
            // 
            // sobel
            // 
            this.sobel.AutoSize = true;
            this.sobel.BackColor = System.Drawing.Color.Transparent;
            this.sobel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobel.Location = new System.Drawing.Point(71, 321);
            this.sobel.Name = "sobel";
            this.sobel.Size = new System.Drawing.Size(70, 24);
            this.sobel.TabIndex = 6;
            this.sobel.Text = "Sobel";
            this.sobel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sobel_MouseClick);
            this.sobel.MouseLeave += new System.EventHandler(this.sobel_MouseLeave);
            this.sobel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sobel_MouseMove);
            // 
            // canny_th1
            // 
            this.canny_th1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canny_th1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.canny_th1.Location = new System.Drawing.Point(191, 81);
            this.canny_th1.Name = "canny_th1";
            this.canny_th1.Size = new System.Drawing.Size(55, 26);
            this.canny_th1.TabIndex = 9;
            this.canny_th1.Text = "50";
            this.canny_th1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.canny_th1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canny_th1_keypress);
            this.canny_th1.Leave += new System.EventHandler(this.canny_th1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = ">> Set the Filters\' thresholds";
            // 
            // c_thershold1
            // 
            this.c_thershold1.AutoSize = true;
            this.c_thershold1.BackColor = System.Drawing.Color.Transparent;
            this.c_thershold1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_thershold1.Location = new System.Drawing.Point(180, 65);
            this.c_thershold1.Name = "c_thershold1";
            this.c_thershold1.Size = new System.Drawing.Size(77, 14);
            this.c_thershold1.TabIndex = 11;
            this.c_thershold1.Text = "threshold1";
            // 
            // c_threshold2
            // 
            this.c_threshold2.AutoSize = true;
            this.c_threshold2.BackColor = System.Drawing.Color.Transparent;
            this.c_threshold2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_threshold2.Location = new System.Drawing.Point(285, 65);
            this.c_threshold2.Name = "c_threshold2";
            this.c_threshold2.Size = new System.Drawing.Size(77, 14);
            this.c_threshold2.TabIndex = 12;
            this.c_threshold2.Text = "threshold2";
            // 
            // canny_th2
            // 
            this.canny_th2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canny_th2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.canny_th2.Location = new System.Drawing.Point(296, 81);
            this.canny_th2.Name = "canny_th2";
            this.canny_th2.Size = new System.Drawing.Size(55, 26);
            this.canny_th2.TabIndex = 13;
            this.canny_th2.Text = "150";
            this.canny_th2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.canny_th2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canny_th2_KeyPress);
            this.canny_th2.Leave += new System.EventHandler(this.canny_th2_Leave);
            // 
            // g_kernelsize
            // 
            this.g_kernelsize.AutoSize = true;
            this.g_kernelsize.BackColor = System.Drawing.Color.Transparent;
            this.g_kernelsize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_kernelsize.Location = new System.Drawing.Point(176, 125);
            this.g_kernelsize.Name = "g_kernelsize";
            this.g_kernelsize.Size = new System.Drawing.Size(84, 14);
            this.g_kernelsize.TabIndex = 14;
            this.g_kernelsize.Text = "kernel size";
            // 
            // gauss_kernel
            // 
            this.gauss_kernel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauss_kernel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gauss_kernel.Location = new System.Drawing.Point(191, 141);
            this.gauss_kernel.Name = "gauss_kernel";
            this.gauss_kernel.Size = new System.Drawing.Size(55, 26);
            this.gauss_kernel.TabIndex = 15;
            this.gauss_kernel.Text = "9";
            this.gauss_kernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gauss_kernel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gauss_kernel_KeyPress);
            this.gauss_kernel.Leave += new System.EventHandler(this.gauss_kernel_Leave);
            // 
            // g_sigma
            // 
            this.g_sigma.AutoSize = true;
            this.g_sigma.BackColor = System.Drawing.Color.Transparent;
            this.g_sigma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_sigma.Location = new System.Drawing.Point(302, 125);
            this.g_sigma.Name = "g_sigma";
            this.g_sigma.Size = new System.Drawing.Size(42, 14);
            this.g_sigma.TabIndex = 16;
            this.g_sigma.Text = "sigma";
            // 
            // gauss_sigma
            // 
            this.gauss_sigma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauss_sigma.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gauss_sigma.Location = new System.Drawing.Point(296, 141);
            this.gauss_sigma.Name = "gauss_sigma";
            this.gauss_sigma.Size = new System.Drawing.Size(55, 26);
            this.gauss_sigma.TabIndex = 17;
            this.gauss_sigma.Text = "1";
            this.gauss_sigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gauss_sigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gauss_sigma_KeyPress);
            this.gauss_sigma.Leave += new System.EventHandler(this.gauss_sigma_Leave);
            // 
            // s_threshold1
            // 
            this.s_threshold1.AutoSize = true;
            this.s_threshold1.BackColor = System.Drawing.Color.Transparent;
            this.s_threshold1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_threshold1.Location = new System.Drawing.Point(285, 185);
            this.s_threshold1.Name = "s_threshold1";
            this.s_threshold1.Size = new System.Drawing.Size(77, 14);
            this.s_threshold1.TabIndex = 18;
            this.s_threshold1.Text = "threshold1";
            // 
            // sharp_th1
            // 
            this.sharp_th1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharp_th1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sharp_th1.Location = new System.Drawing.Point(296, 201);
            this.sharp_th1.Name = "sharp_th1";
            this.sharp_th1.Size = new System.Drawing.Size(55, 26);
            this.sharp_th1.TabIndex = 19;
            this.sharp_th1.Text = "1.5";
            this.sharp_th1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sharp_th1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sharp_th1_KeyPress);
            // 
            // s_threshold2
            // 
            this.s_threshold2.AutoSize = true;
            this.s_threshold2.BackColor = System.Drawing.Color.Transparent;
            this.s_threshold2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_threshold2.Location = new System.Drawing.Point(390, 185);
            this.s_threshold2.Name = "s_threshold2";
            this.s_threshold2.Size = new System.Drawing.Size(77, 14);
            this.s_threshold2.TabIndex = 20;
            this.s_threshold2.Text = "threshold2";
            // 
            // sharp_th2
            // 
            this.sharp_th2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharp_th2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sharp_th2.Location = new System.Drawing.Point(401, 201);
            this.sharp_th2.Name = "sharp_th2";
            this.sharp_th2.Size = new System.Drawing.Size(55, 26);
            this.sharp_th2.TabIndex = 21;
            this.sharp_th2.Text = "-0.5";
            this.sharp_th2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sharp_th2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sharp_th2_KeyPress);
            // 
            // s_sigma
            // 
            this.s_sigma.AutoSize = true;
            this.s_sigma.BackColor = System.Drawing.Color.Transparent;
            this.s_sigma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_sigma.Location = new System.Drawing.Point(197, 185);
            this.s_sigma.Name = "s_sigma";
            this.s_sigma.Size = new System.Drawing.Size(42, 14);
            this.s_sigma.TabIndex = 22;
            this.s_sigma.Text = "sigma";
            // 
            // sharp_sigma
            // 
            this.sharp_sigma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharp_sigma.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sharp_sigma.Location = new System.Drawing.Point(191, 201);
            this.sharp_sigma.Name = "sharp_sigma";
            this.sharp_sigma.Size = new System.Drawing.Size(55, 26);
            this.sharp_sigma.TabIndex = 23;
            this.sharp_sigma.Text = "1";
            this.sharp_sigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sharp_sigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sharp_sigma_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "kernel size";
            // 
            // med_kernel
            // 
            this.med_kernel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_kernel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.med_kernel.Location = new System.Drawing.Point(191, 261);
            this.med_kernel.Name = "med_kernel";
            this.med_kernel.Size = new System.Drawing.Size(55, 26);
            this.med_kernel.TabIndex = 25;
            this.med_kernel.Text = "3";
            this.med_kernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.med_kernel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.med_kernel_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 378);
            this.Controls.Add(this.med_kernel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sharp_sigma);
            this.Controls.Add(this.s_sigma);
            this.Controls.Add(this.sharp_th2);
            this.Controls.Add(this.s_threshold2);
            this.Controls.Add(this.sharp_th1);
            this.Controls.Add(this.s_threshold1);
            this.Controls.Add(this.gauss_sigma);
            this.Controls.Add(this.g_sigma);
            this.Controls.Add(this.gauss_kernel);
            this.Controls.Add(this.g_kernelsize);
            this.Controls.Add(this.canny_th2);
            this.Controls.Add(this.c_threshold2);
            this.Controls.Add(this.c_thershold1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canny_th1);
            this.Controls.Add(this.sobel);
            this.Controls.Add(this.median);
            this.Controls.Add(this.sharpening);
            this.Controls.Add(this.gaussian);
            this.Controls.Add(this.canny);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.init);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Threshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label canny;
        private System.Windows.Forms.Label gaussian;
        private System.Windows.Forms.Label sharpening;
        private System.Windows.Forms.Label median;
        private System.Windows.Forms.Label sobel;
        private System.Windows.Forms.TextBox canny_th1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label c_thershold1;
        private System.Windows.Forms.Label c_threshold2;
        private System.Windows.Forms.TextBox canny_th2;
        private System.Windows.Forms.Label g_kernelsize;
        private System.Windows.Forms.TextBox gauss_kernel;
        private System.Windows.Forms.Label g_sigma;
        private System.Windows.Forms.TextBox gauss_sigma;
        private System.Windows.Forms.Label s_threshold1;
        private System.Windows.Forms.TextBox sharp_th1;
        private System.Windows.Forms.Label s_threshold2;
        private System.Windows.Forms.TextBox sharp_th2;
        private System.Windows.Forms.Label s_sigma;
        private System.Windows.Forms.TextBox sharp_sigma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox med_kernel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip sobeltip;
    }
}